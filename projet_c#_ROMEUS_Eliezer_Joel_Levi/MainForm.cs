using projet_c__ROMEUS_Eliezer_Joel_Levi.Data;
using projet_c__ROMEUS_Eliezer_Joel_Levi.Forms;
using projet_c__ROMEUS_Eliezer_Joel_Levi.Security;

namespace projet_c__ROMEUS_Eliezer_Joel_Levi;

public partial class MainForm : Form
{
    private AppData? data;
    private UserSession? session;

    // Constructeur utilisé par l'application après une connexion réussie.
    public MainForm(AppData data, UserSession session) : this()
    {
        this.data = data;
        this.session = session;
        welcomeLabel.Text = $"Bonjour {session.Username} !";
        this.Text = $"{session.Username}'s Personnal Space ";
    }

    // Constructeur nécessaire au Designer de Visual Studio.
    public MainForm()
    {
        InitializeComponent();
        FormClosing += MainForm_FormClosing;
    }

    private async void secretsButton_Click(object? sender, EventArgs e) => await OpenSecrets();
    private async void activitiesButton_Click(object? sender, EventArgs e) => await OpenModule(ModuleType.Activities);
    private async void contactsButton_Click(object? sender, EventArgs e) => await OpenModule(ModuleType.Contacts);
    private async void secretsMenuItem_Click(object? sender, EventArgs e) => await OpenSecrets();
    private async void activitiesMenuItem_Click(object? sender, EventArgs e) => await OpenModule(ModuleType.Activities);
    private async void contactsMenuItem_Click(object? sender, EventArgs e) => await OpenModule(ModuleType.Contacts);
    private void logoutMenuItem_Click(object? sender, EventArgs e)
    {
        var result = MessageBox.Show(
            "Voulez-vous vous déconnecter ?",
            "Déconnexion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (result == DialogResult.Yes)
        {
            Hide();
            ShowLoadingForm();

            if (data is null)
            {
                Show();
                return;
            }

            using var loginForm = new Form1(data, false);
            if (loginForm.ShowDialog() == DialogResult.OK && loginForm.Session is not null)
            {
                session = loginForm.Session;
                welcomeLabel.Text = $"Bonjour {session.Username} !";
                Text = $"{session.Username}'s Personal Space";
            }

            Show();
            Activate();
        }
    }

    private async Task OpenSecrets()
    {
        if (data is null || session is null) return;
        var user = await data.FindUserAsync(session.Username);
        if (user is null) return;

        using var prompt = new CodePromptForm();
        if (prompt.ShowDialog(this) != DialogResult.OK || !PasswordHasher.Verify(prompt.Code, user.SecretCodeHash))
        {
            MessageBox.Show("Code secret incorrect.", "Accès refusé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        using var form = new ModuleForm(data, session, ModuleType.Secrets);
        form.ShowDialog(this);
    }

    private async Task OpenModule(ModuleType type)
    {
        if (data is null || session is null) return;
        await Task.CompletedTask;
        using var form = new ModuleForm(data, session, type);
        form.ShowDialog(this);
    }





    private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var result = MessageBox.Show(
            "Quitter l'application ?",
            "Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
        else
        {
            Hide();
            ShowLoadingForm();
        }

    }

    private void ShowLoadingForm()
    {
        using var loadingForm = new loading();
        loadingForm.ShowDialog();
    }

    private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (data is null) return;

        Hide();
        using var registrationForm = new Form1(data, true)
        {
            FormBorderStyle = FormBorderStyle.FixedToolWindow
        };

        if (registrationForm.ShowDialog() == DialogResult.OK && registrationForm.Session is not null)
        {
            // La création réussie ouvre immédiatement la session du nouveau compte.
            session = registrationForm.Session;
            welcomeLabel.Text = $"Bonjour {session.Username} !";
            Text = $"{session.Username}'s Personal Space";
        }

        Show();
        Activate();
    }
}

