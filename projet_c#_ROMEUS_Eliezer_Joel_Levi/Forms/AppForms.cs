using MySqlConnector;
using projet_c__ROMEUS_Eliezer_Joel_Levi.Data;
using projet_c__ROMEUS_Eliezer_Joel_Levi.Security;
using System.Text.Json;

namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Forms;

internal static class Palette
{
    public static readonly Color Teal = Color.FromArgb(0, 170, 153);
    public static readonly Color Turquoise = Color.FromArgb(0, 218, 198);
    public static readonly Color Aqua = Color.FromArgb(0, 197, 181);
    public static readonly Color Cream = Color.FromArgb(247, 243, 241);
    public static readonly Color Coral = Color.FromArgb(226, 151, 119);
    public static readonly Color Ink = Color.FromArgb(35, 63, 65);
}

public sealed class LoginForm : Form
{
    private readonly AppData data;
    private readonly bool firstLaunch;
    private readonly TextBox username = new(), password = new(), code = new();
    private readonly Label heading = new(); private readonly Button submit = new();
    public UserSession? Session { get; private set; }

    public LoginForm(AppData data, bool firstLaunch)
    {
        this.data = data; this.firstLaunch = firstLaunch; Text = "Mon espace personnel"; StartPosition = FormStartPosition.CenterScreen; ClientSize = new Size(480, 430); BackColor = Palette.Cream; FormBorderStyle = FormBorderStyle.FixedSingle; MaximizeBox = false;
        heading.Text = firstLaunch ? "Créer votre compte" : "Bienvenue"; heading.Font = new Font("Segoe UI", 22, FontStyle.Bold); heading.ForeColor = Palette.Teal; heading.AutoSize = true; heading.Location = new Point(42, 34); Controls.Add(heading);
        AddLabel("Nom d'utilisateur", 42, 105); AddBox(username, 42, 130);
        AddLabel("Mot de passe", 42, 180); AddBox(password, 42, 205); password.UseSystemPasswordChar = true;
        AddLabel("Code secret des secrets (4 chiffres)", 42, 255); AddBox(code, 42, 280); code.UseSystemPasswordChar = true; code.MaxLength = 12;
        submit.Text = firstLaunch ? "Créer le compte" : "Se connecter"; submit.BackColor = Palette.Teal; submit.ForeColor = Color.White; submit.FlatStyle = FlatStyle.Flat; submit.Font = new Font("Segoe UI", 10, FontStyle.Bold); submit.Size = new Size(396, 44); submit.Location = new Point(42, 350); submit.Click += Submit_Click; Controls.Add(submit);
        AcceptButton = submit;
    }
    private void AddLabel(string text, int x, int y) { Controls.Add(new Label { Text = text, AutoSize = true, Location = new Point(x, y), ForeColor = Palette.Ink, Font = new Font("Segoe UI", 9, FontStyle.Bold) }); }
    private void AddBox(Control box, int x, int y) { box.Location = new Point(x, y); box.Size = new Size(396, 30); box.Font = new Font("Segoe UI", 11); Controls.Add(box); }
    private async void Submit_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(username.Text) || password.Text.Length < 6 || code.Text.Length < 4) { MessageBox.Show("Indiquez un nom, un mot de passe d'au moins 6 caractères et un code secret.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
        try
        {
            submit.Enabled = false;
            if (firstLaunch)
            {
                var id = await data.CreateUserAsync(username.Text.Trim(), PasswordHasher.Hash(password.Text), PasswordHasher.Hash(code.Text)); Session = new UserSession(id, username.Text.Trim());
            }
            else
            {
                var user = await data.FindUserAsync(username.Text.Trim());
                if (user is null || !PasswordHasher.Verify(password.Text, user.PasswordHash)) { MessageBox.Show("Identifiants invalides.", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                Session = new UserSession(user.Id, user.Username);
            }
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        finally { submit.Enabled = true; }
    }
}

// Les classes ModuleType, CodePromptForm, ModuleForm, RecordEditForm,
// SecretEditForm, ActivityEditForm et ContactEditForm sont déplacées dans
// des fichiers séparés afin d'être éditables dans le Designer WinForms.
