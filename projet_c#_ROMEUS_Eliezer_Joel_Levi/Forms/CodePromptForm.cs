namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Forms;

public partial class CodePromptForm : Form
{
    public string Code => codeTextBox.Text;

    public CodePromptForm()
    {
        InitializeComponent();
    }

    private void unlockButton_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(codeTextBox.Text))
        {
            MessageBox.Show("Veuillez saisir votre code secret.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        DialogResult = DialogResult.OK;
    }
}
