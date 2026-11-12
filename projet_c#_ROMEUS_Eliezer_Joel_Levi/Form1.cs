using projet_c__ROMEUS_Eliezer_Joel_Levi.Data;
using projet_c__ROMEUS_Eliezer_Joel_Levi.Forms;
using projet_c__ROMEUS_Eliezer_Joel_Levi.Security;

namespace projet_c__ROMEUS_Eliezer_Joel_Levi
{
    public partial class Form1 : Form
    {
        private readonly AppData? data;
        private readonly bool firstLaunch;
        public UserSession? Session { get; private set; }

        public Form1()
        {
            InitializeComponent();

        }

        public Form1(AppData data, bool firstLaunch) : this()
        {


            this.data = data;
            this.firstLaunch = firstLaunch;
            titleLabel.Text = firstLaunch ? "Salut !" : "Bon Retour !!!";

            button1.Text = firstLaunch ? "Créer le Compte" : "Se Connecter";
            secretCodeLabel.Text = "Code secret des secrets (4 chiffres)";
            secretCodeLabel.Visible = firstLaunch;
            secretCodeTextBox.Visible = firstLaunch;
            label1.Visible = firstLaunch;
            button1.Location = firstLaunch
                ? new Point(50, 359)
                : new Point(50, 292);
            this.Size =  firstLaunch ? new(503, 503) : new Size(500, 423);
        }




        private async void button1_ClickAsync(object? sender, EventArgs e)
        {


            if (data is null) return;
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || passwordTextBox.Text.Length < 6 || (firstLaunch && secretCodeTextBox.Text.Length < 4))
            {
                MessageBox.Show("Indiquez un nom, un mot de passe d'au moins 6 caractères et un code secret.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Empêche plusieurs clics pendant l'opération asynchrone.
                button1.Enabled = false;
                var username = usernameTextBox.Text.Trim();

                if (firstLaunch)
                {
                    // Les mots de passe ne sont jamais enregistrés en clair.
                    // PasswordHasher crée un hash avec un sel aléatoire.
                    var id = await data.CreateUserAsync(username, PasswordHasher.Hash(passwordTextBox.Text), PasswordHasher.Hash(secretCodeTextBox.Text));
                    Session = new UserSession(id, username);
                    ShowLoadingForm();
                }
                else
                {
                    // Recherche l'utilisateur puis vérifie son mot de passe haché.
                    var user = await data.FindUserAsync(username);
                    if (user is null || !PasswordHasher.Verify(passwordTextBox.Text, user.PasswordHash))
                    {
                        MessageBox.Show("Identifiants invalides.", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    Session = new UserSession(user.Id, user.Username);
                    ShowLoadingForm();

                }

                // DialogResult.OK indique à Program.cs que l'authentification est réussie.
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                // Affiche une erreur de connexion ou de base de données.
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Réactive le bouton même si une erreur s'est produite.
                button1.Enabled = true;
            }
        }

        private void ShowLoadingForm()
        {
            using var loadingForm = new loading();
            Hide();
            loadingForm.ShowDialog();
        }

    }
}
