using MySqlConnector;
using System.Text.Json;

namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Data;

// Cette classe centralise toutes les communications entre l'application et MySQL.
// Les formulaires l'utilisent pour lire, ajouter, modifier et supprimer les données.
public sealed class AppData
{
    // Chaîne de connexion lue dans appsettings.json.
    public string ConnectionString { get; }

    public AppData()
    {
        // AppContext.BaseDirectory correspond au dossier depuis lequel l'application est exécutée.
        var path = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
        if (!File.Exists(path))
            throw new InvalidOperationException("Le fichier appsettings.json est introuvable.");

        // Le fichier JSON est transformé en dictionnaire clé/valeur.
        var settings = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(path));
        ConnectionString = settings?["ConnectionString"] ?? throw new InvalidOperationException("ConnectionString est absente d'appsettings.json.");
    }

    // Crée les tables nécessaires si elles n'existent pas encore.
    // Cette méthode est appelée au démarrage de l'application.
    public async Task InitializeAsync()
    {
        // Une connexion qui contient Database=romeus_app échoue si la base n'existe pas encore.
        // On se connecte donc d'abord au serveur sans sélectionner de base.
        var builder = new MySqlConnectionStringBuilder(ConnectionString);
        var databaseName = builder.Database;
        if (string.IsNullOrWhiteSpace(databaseName))
            throw new InvalidOperationException("Le nom de la base est absent de ConnectionString.");

        builder.Database = string.Empty;
        await using (var serverConnection = new MySqlConnection(builder.ConnectionString))
        {
            await serverConnection.OpenAsync();
            var safeDatabaseName = databaseName.Replace("`", "``", StringComparison.Ordinal);
            await using var createDatabase = new MySqlCommand($"CREATE DATABASE IF NOT EXISTS `{safeDatabaseName}` CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci", serverConnection);
            await createDatabase.ExecuteNonQueryAsync();
        }

        // La base existe maintenant; on peut ouvrir la connexion habituelle.
        await using var connection = new MySqlConnection(ConnectionString);
        await connection.OpenAsync();

        // Chaque instruction utilise IF NOT EXISTS pour pouvoir être exécutée plusieurs fois.
        var commands = new[]
        {
            // Compte de connexion et hash du mot de passe/code secret.
            "CREATE TABLE IF NOT EXISTS users (id INT AUTO_INCREMENT PRIMARY KEY, username VARCHAR(80) NOT NULL UNIQUE, password_hash VARCHAR(300) NOT NULL, secret_code_hash VARCHAR(300) NOT NULL, created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP)",
            // Secrets appartenant à un utilisateur.
            "CREATE TABLE IF NOT EXISTS secrets (id INT AUTO_INCREMENT PRIMARY KEY, user_id INT NOT NULL, title VARCHAR(150) NOT NULL, username VARCHAR(150) NULL, password_value TEXT NOT NULL, notes TEXT NULL, created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP, FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE)",
            // Activités planifiées par un utilisateur.
            "CREATE TABLE IF NOT EXISTS activities (id INT AUTO_INCREMENT PRIMARY KEY, user_id INT NOT NULL, activity_date DATE NOT NULL, title VARCHAR(150) NOT NULL, description TEXT NULL, status VARCHAR(30) NOT NULL DEFAULT 'À faire', FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE)",
            // Contacts enregistrés par un utilisateur.
            "CREATE TABLE IF NOT EXISTS contacts (id INT AUTO_INCREMENT PRIMARY KEY, user_id INT NOT NULL, first_name VARCHAR(80) NOT NULL, last_name VARCHAR(80) NOT NULL, phone VARCHAR(50) NULL, email VARCHAR(150) NULL, notes TEXT NULL, FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE)"
        };

        // Exécute chaque commande SQL de création.
        foreach (var sql in commands)
            await using (var command = new MySqlCommand(sql, connection)) await command.ExecuteNonQueryAsync();
    }

    // Vérifie si au moins un utilisateur existe déjà.
    // Cette information permet de choisir entre création de compte et connexion.
    public async Task<bool> HasUserAsync()
    {
        await using var connection = new MySqlConnection(ConnectionString);
        await connection.OpenAsync();
        await using var command = new MySqlCommand("SELECT EXISTS(SELECT 1 FROM users)", connection);
        return Convert.ToInt32(await command.ExecuteScalarAsync()) == 1;
    }

    public async Task<int> CreateUserAsync(string username, string passwordHash, string secretCodeHash)
    {
        await using var connection = new MySqlConnection(ConnectionString);
        await connection.OpenAsync();
        await using var command = new MySqlCommand("INSERT INTO users(username,password_hash,secret_code_hash) VALUES(@u,@p,@s); SELECT LAST_INSERT_ID();", connection);
        // Les paramètres empêchent d'injecter du SQL dans les valeurs saisies.
        command.Parameters.AddWithValue("@u", username); command.Parameters.AddWithValue("@p", passwordHash); command.Parameters.AddWithValue("@s", secretCodeHash);
        // LAST_INSERT_ID() renvoie l'identifiant du nouvel utilisateur.
        return Convert.ToInt32(await command.ExecuteScalarAsync());
    }

    // Recherche un utilisateur par son nom. Retourne null s'il n'existe pas.
    public async Task<UserRecord?> FindUserAsync(string username)
    {
        await using var connection = new MySqlConnection(ConnectionString);
        await connection.OpenAsync();
        await using var command = new MySqlCommand("SELECT id,username,password_hash,secret_code_hash FROM users WHERE username=@u", connection);
        command.Parameters.AddWithValue("@u", username);
        await using var reader = await command.ExecuteReaderAsync();
        return await reader.ReadAsync() ? new UserRecord(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)) : null;
    }

    // Les trois méthodes suivantes récupèrent les données d'un seul utilisateur.
    // La fonction QueryAsync évite de répéter le code de connexion et de lecture.
    public Task<List<SecretRecord>> GetSecretsAsync(int userId) => QueryAsync("SELECT id,title,username,password_value,notes FROM secrets WHERE user_id=@u ORDER BY title", userId, r => new SecretRecord(r.GetInt32(0), r.GetString(1), r.IsDBNull(2) ? "" : r.GetString(2), r.GetString(3), r.IsDBNull(4) ? "" : r.GetString(4)));
    public Task<List<ActivityRecord>> GetActivitiesAsync(int userId) => QueryAsync("SELECT id,activity_date,title,description,status FROM activities WHERE user_id=@u ORDER BY activity_date DESC", userId, r => new ActivityRecord(r.GetInt32(0), r.GetDateTime(1), r.GetString(2), r.IsDBNull(3) ? "" : r.GetString(3), r.GetString(4)));
    public Task<List<ContactRecord>> GetContactsAsync(int userId) => QueryAsync("SELECT id,first_name,last_name,phone,email,notes FROM contacts WHERE user_id=@u ORDER BY last_name,first_name", userId, r => new ContactRecord(r.GetInt32(0), r.GetString(1), r.GetString(2), r.IsDBNull(3) ? "" : r.GetString(3), r.IsDBNull(4) ? "" : r.GetString(4), r.IsDBNull(5) ? "" : r.GetString(5)));

    private async Task<List<T>> QueryAsync<T>(string sql, int userId, Func<MySqlDataReader, T> map)
    {
        var result = new List<T>();
        // Ouvre une connexion uniquement pendant la durée de la requête.
        await using var connection = new MySqlConnection(ConnectionString); await connection.OpenAsync();
        await using var command = new MySqlCommand(sql, connection); command.Parameters.AddWithValue("@u", userId);
        // map transforme chaque ligne MySQL en objet C#.
        await using var reader = await command.ExecuteReaderAsync(); while (await reader.ReadAsync()) result.Add(map(reader)); return result;
    }

    // Une Id égale à zéro signifie qu'il faut créer une nouvelle ligne.
    // Sinon, la ligne existante est mise à jour.
    public async Task SaveSecretAsync(int userId, SecretRecord item) => await ExecuteAsync(item.Id == 0 ? "INSERT INTO secrets(user_id,title,username,password_value,notes) VALUES(@u,@title,@name,@pass,@notes)" : "UPDATE secrets SET title=@title,username=@name,password_value=@pass,notes=@notes WHERE id=@id AND user_id=@u", userId, item.Id, (c) => { c.Parameters.AddWithValue("@title", item.Title); c.Parameters.AddWithValue("@name", item.Username); c.Parameters.AddWithValue("@pass", item.Password); c.Parameters.AddWithValue("@notes", item.Notes); });
    public async Task SaveActivityAsync(int userId, ActivityRecord item) => await ExecuteAsync(item.Id == 0 ? "INSERT INTO activities(user_id,activity_date,title,description,status) VALUES(@u,@date,@title,@description,@status)" : "UPDATE activities SET activity_date=@date,title=@title,description=@description,status=@status WHERE id=@id AND user_id=@u", userId, item.Id, c => { c.Parameters.AddWithValue("@date", item.Date); c.Parameters.AddWithValue("@title", item.Title); c.Parameters.AddWithValue("@description", item.Description); c.Parameters.AddWithValue("@status", item.Status); });
    public async Task SaveContactAsync(int userId, ContactRecord item) => await ExecuteAsync(item.Id == 0 ? "INSERT INTO contacts(user_id,first_name,last_name,phone,email,notes) VALUES(@u,@first,@last,@phone,@email,@notes)" : "UPDATE contacts SET first_name=@first,last_name=@last,phone=@phone,email=@email,notes=@notes WHERE id=@id AND user_id=@u", userId, item.Id, c => { c.Parameters.AddWithValue("@first", item.FirstName); c.Parameters.AddWithValue("@last", item.LastName); c.Parameters.AddWithValue("@phone", item.Phone); c.Parameters.AddWithValue("@email", item.Email); c.Parameters.AddWithValue("@notes", item.Notes); });

    private async Task ExecuteAsync(string sql, int userId, int id, Action<MySqlCommand> parameters)
    {
        await using var connection = new MySqlConnection(ConnectionString); await connection.OpenAsync(); await using var command = new MySqlCommand(sql, connection);
        // user_id est toujours ajouté afin qu'un utilisateur ne puisse modifier que ses propres données.
        command.Parameters.AddWithValue("@u", userId); if (id > 0) command.Parameters.AddWithValue("@id", id); parameters(command); await command.ExecuteNonQueryAsync();
    }

    // Supprime une ligne dans l'un des trois modules.
    public async Task DeleteAsync(string table, int userId, int id)
    {
        // La table ne peut pas être fournie librement par l'utilisateur.
        // Cette vérification protège la partie dynamique de la requête SQL.
        if (!new[] { "secrets", "activities", "contacts" }.Contains(table)) throw new ArgumentException("Table non autorisée.");
        await ExecuteAsync($"DELETE FROM {table} WHERE id=@id AND user_id=@u", userId, id, _ => { });
    }
}

// Records simples utilisés pour transporter les données entre MySQL et les formulaires.
public record UserRecord(int Id, string Username, string PasswordHash, string SecretCodeHash);
public record SecretRecord(int Id, string Title, string Username, string Password, string Notes);
public record ActivityRecord(int Id, DateTime Date, string Title, string Description, string Status);
public record ContactRecord(int Id, string FirstName, string LastName, string Phone, string Email, string Notes);
