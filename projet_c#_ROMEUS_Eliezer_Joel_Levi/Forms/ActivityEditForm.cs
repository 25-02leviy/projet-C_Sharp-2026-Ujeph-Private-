using projet_c__ROMEUS_Eliezer_Joel_Levi.Models;

namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Forms;

public partial class ActivityEditForm : Form
{
    private int Id;
    public ActivityModel? Value { get; private set; }

    public ActivityEditForm() : this(null)
    {
    }

    public ActivityEditForm(ActivityModel? old)
    {
        InitializeComponent(); Id = old?.Id ?? 0; datePicker.Value = old?.Date ?? DateTime.Today; titleTextBox.Text = old?.Title ?? ""; descriptionTextBox.Text = old?.Description ?? ""; statusComboBox.SelectedItem = old?.Status ?? "À faire";
    }

    private void Save_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(titleTextBox.Text))
        {
            MessageBox.Show("Le titre de l'activité est obligatoire.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DialogResult = DialogResult.None;
            return;
        }
        Value = new ActivityModel { Id = Id, Date = datePicker.Value.Date, Title = titleTextBox.Text.Trim(), Description = descriptionTextBox.Text.Trim(), Status = statusComboBox.Text };
        DialogResult = DialogResult.OK;
    }
}
