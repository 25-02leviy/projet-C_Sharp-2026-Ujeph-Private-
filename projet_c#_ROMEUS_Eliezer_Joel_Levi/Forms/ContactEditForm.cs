using projet_c__ROMEUS_Eliezer_Joel_Levi.Models;

namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Forms;

public partial class ContactEditForm : Form
{
    private int Id;
    public ContactModel? Value { get; private set; }

    public ContactEditForm() : this(null)
    {
    }

    public ContactEditForm(ContactModel? old)
    {
        InitializeComponent(); Id = old?.Id ?? 0; firstNameTextBox.Text = old?.FirstName ?? ""; lastNameTextBox.Text = old?.LastName ?? ""; phoneTextBox.Text = old?.Phone ?? ""; emailTextBox.Text = old?.Email ?? ""; notesTextBox.Text = old?.Notes ?? "";
    }

    private void Save_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) || string.IsNullOrWhiteSpace(lastNameTextBox.Text))
        {
            MessageBox.Show("Le prénom et le nom sont obligatoires.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DialogResult = DialogResult.None;
            return;
        }
        Value = new ContactModel { Id = Id, FirstName = firstNameTextBox.Text.Trim(), LastName = lastNameTextBox.Text.Trim(), Phone = phoneTextBox.Text.Trim(), Email = emailTextBox.Text.Trim(), Notes = notesTextBox.Text.Trim() };
        DialogResult = DialogResult.OK;
    }

    private void ContactEditForm_Load(object sender, EventArgs e)
    {

    }

    private void lastNameTextBox_TextChanged(object sender, EventArgs e)
    {

    }
}
