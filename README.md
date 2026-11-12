
# Projet-C-2026-UJEPH-secret
Un app desktop pour gérer des secrets

# Mon espace personnel

Application de bureau Windows Forms réalisée en .NET 10. Elle permet à plusieurs comptes de gérer séparément leurs secrets, leurs activités journalières et leurs contacts dans une base MySQL.

## Fonctionnement

- Au premier démarrage, l'application demande de créer le premier compte. Aux démarrages suivants, elle demande une authentification.
- Une fois connecté, l'utilisateur peut créer un autre compte depuis **Modules > Nouveau Compte Utilisateur**. Après la création, l'application ouvre la session de ce nouveau compte.
- L'option **Déconnexion** demande une confirmation, puis présente l'écran de connexion. Une connexion réussie ouvre une session pour le compte choisi.
- La fermeture de la fenêtre principale demande une confirmation. Une animation de chargement s'affiche lors d'une création de compte, d'une connexion, d'une déconnexion confirmée ou d'une fermeture confirmée.
- Le menu **Modules** donne accès aux secrets, aux activités journalières et aux contacts.
- Chaque module permet d'ajouter et de consulter des entrées. Un double-clic sur une ligne ouvre sa modification; le bouton de suppression permet de la retirer après confirmation.
- L'accès au module **Secrets** est protégé par le code secret du compte, demandé à chaque ouverture.

## Comptes et confidentialité des données

Chaque compte possède un identifiant `users.id`. Cet identifiant est enregistré dans la colonne `user_id` de chaque secret, activité et contact.

Les listes sont chargées avec un filtre sur l'identifiant du compte connecté. Les mises à jour et les suppressions vérifient également cet identifiant. Ainsi, un utilisateur ne voit et ne modifie que les entrées qui lui appartiennent. Les identifiants `id` des entrées sont distincts de `user_id` : ils sont générés séparément par chaque table.

Les noms d'utilisateur sont uniques dans la base. Le mot de passe de connexion et le code secret sont hachés avec PBKDF2-SHA256, un sel aléatoire de 16 octets et 120 000 itérations. Ils ne sont pas stockés en clair. Le mot de passe enregistré dans le module **Secrets**, en revanche, est actuellement conservé tel quel dans la colonne `password_value` de MySQL.

Le formulaire demande un mot de passe d'au moins 6 caractères et un code secret d'au moins 4 caractères. Bien que l'étiquette parle d'un code à 4 chiffres, le code vérifie actuellement sa longueur, sans imposer que ses caractères soient des chiffres.

## Prérequis

- Windows.
- .NET 10 SDK.
- MySQL Server 8 ou compatible, démarré et accessible avec le compte configuré.
- Visual Studio 2026 avec la charge de travail **Développement .NET Desktop**, si vous souhaitez utiliser Visual Studio.

Le projet utilise le package NuGet `MySqlConnector`.

## Base de données

Le script SQL se trouve dans `projet_c#_ROMEUS_Eliezer_Joel_Levi/database.sql`. Il crée la base `romeus_app` et les tables si elles n'existent pas.

L'application effectue aussi cette initialisation au démarrage : elle crée la base configurée si nécessaire, puis crée les tables manquantes. Le serveur MySQL doit néanmoins être installé, démarré et accessible avec les droits suffisants pour créer la base.

La configuration se trouve dans `projet_c#_ROMEUS_Eliezer_Joel_Levi/appsettings.json` :

```json
{
  "ConnectionString": "Server=localhost;Port=3306;Database=romeus_app;User ID=root;Password=VOTRE_MOT_DE_PASSE;SslMode=None;AllowUserVariables=True;"
}
```

La configuration fournie utilise `localhost`, le port `3306`, la base `romeus_app` et l'utilisateur `root` sans mot de passe. Remplacez ces valeurs selon votre installation MySQL. Ne distribuez pas une chaîne contenant un vrai mot de passe.

### Tables

- `users` : identifiant du compte, nom d'utilisateur unique, hash du mot de passe, hash du code secret et date de création.
- `secrets` : identifiant, `user_id`, titre, nom d'utilisateur associé au secret, mot de passe du coffre, notes et date de création.
- `activities` : identifiant, `user_id`, date, titre, description et statut.
- `contacts` : identifiant, `user_id`, prénom, nom, téléphone, e-mail et notes.

Les colonnes `user_id` sont des clés étrangères vers `users.id`. La suppression d'un compte dans la base entraîne la suppression en cascade de ses secrets, activités et contacts.

## Lancement

1. Ouvrez `projet_c#_ROMEUS_Eliezer_Joel_Levi.slnx` dans Visual Studio, ou ouvrez le fichier projet `projet_c#_ROMEUS_Eliezer_Joel_Levi/projet_c#_ROMEUS_Eliezer_Joel_Levi.csproj` avec le SDK .NET.
2. Configurez `projet_c#_ROMEUS_Eliezer_Joel_Levi/appsettings.json` pour votre serveur MySQL.
3. Restaurez les packages NuGet et compilez le projet dans Visual Studio, ou exécutez ces commandes depuis le dossier du dépôt :

   ```powershell
   dotnet restore "projet_c#_ROMEUS_Eliezer_Joel_Levi/projet_c#_ROMEUS_Eliezer_Joel_Levi.csproj"
   dotnet build "projet_c#_ROMEUS_Eliezer_Joel_Levi/projet_c#_ROMEUS_Eliezer_Joel_Levi.csproj"
   dotnet run --project "projet_c#_ROMEUS_Eliezer_Joel_Levi/projet_c#_ROMEUS_Eliezer_Joel_Levi.csproj"
   ```

4. Lancez l'application. Créez le premier compte ou connectez-vous à un compte existant.

## Interface

Palette principale : teal `#00AA99`, turquoise `#00DAC6`, aqua `#00C5B5`, blanc cassé `#F7F3F1` et corail `#E29777`.
 eb8dd3f (Premier commit)

