using projet_c__ROMEUS_Eliezer_Joel_Levi.Models;

namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Forms;

public partial class SecretEditForm : Form
{
    private int Id;
    public SecretModel? Value { get; private set; }

    public SecretEditForm() : this(null)
    {
    }

    public SecretEditForm(SecretModel? old)
    {
        InitializeComponent(); Id = old?.Id ?? 0; titleTextBox.Text = old?.Title ?? ""; usernameTextBox.Text = old?.Username ?? ""; passwordTextBox.Text = old?.Password ?? ""; notesTextBox.Text = old?.Notes ?? "";
    }

    private void Save_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(titleTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text))
        {
            MessageBox.Show("Le titre et le mot de passe sont obligatoires.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DialogResult = DialogResult.None;
            return;
        }
        Value = new SecretModel { Id = Id, Title = titleTextBox.Text.Trim(), Username = usernameTextBox.Text.Trim(), Password = passwordTextBox.Text, Notes = notesTextBox.Text.Trim() };
        DialogResult = DialogResult.OK;
    }

    private void notesTextBox_TextChanged(object sender, EventArgs e)
    {

    }
}
