using projet_c__ROMEUS_Eliezer_Joel_Levi.Data;
using projet_c__ROMEUS_Eliezer_Joel_Levi.Controllers;
using projet_c__ROMEUS_Eliezer_Joel_Levi.Models;
using projet_c__ROMEUS_Eliezer_Joel_Levi.Security;

namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Forms;

public partial class ModuleForm : Form
{
    private AppData? data;
    private UserSession? session;
    private ModuleType type;

    public ModuleForm()
    {
        InitializeComponent();
    }

    public ModuleForm(AppData data, UserSession session, ModuleType type) : this()
    {
        this.data = data;
        this.session = session;
        this.type = type;
        Text = type switch { ModuleType.Secrets => "Mes secrets", ModuleType.Activities => "Mes activités", _ => "Mes contacts" };
    }

    private async void addButton_Click(object? sender, EventArgs e) => await Edit(null);
    private async void deleteButton_Click(object? sender, EventArgs e) => await DeleteSelected();
    private async void recordsGrid_DoubleClick(object? sender, EventArgs e)
    {
        if (recordsGrid.CurrentRow?.DataBoundItem is object item) await Edit(item);
    }

    private async Task RefreshGrid()
    {
        if (data is null || session is null) return;
        recordsGrid.DataSource = type switch
        {
            ModuleType.Secrets => (object)await new SecretController(data).AllAsync(session.UserId),
            ModuleType.Activities => await new ActivityController(data).AllAsync(session.UserId),
            _ => await new ContactController(data).AllAsync(session.UserId)
        };
        if (recordsGrid.Columns["Id"] is not null) recordsGrid.Columns["Id"].Visible = false;
    }

    private async Task DeleteSelected()
    {
        if (data is null || session is null || recordsGrid.CurrentRow?.DataBoundItem is null) return;
        if (MessageBox.Show("Supprimer cet élément ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        var id = type switch
        {
            ModuleType.Secrets => ((SecretModel)recordsGrid.CurrentRow.DataBoundItem).Id,
            ModuleType.Activities => ((ActivityModel)recordsGrid.CurrentRow.DataBoundItem).Id,
            _ => ((ContactModel)recordsGrid.CurrentRow.DataBoundItem).Id
        };
        if (type == ModuleType.Secrets) await new SecretController(data).DeleteAsync(session.UserId, id);
        else if (type == ModuleType.Activities) await new ActivityController(data).DeleteAsync(session.UserId, id);
        else await new ContactController(data).DeleteAsync(session.UserId, id);
        await RefreshGrid();
    }

    private async Task Edit(object? item)
    {
        if (data is null || session is null) return;
        if (type == ModuleType.Secrets)
        {
            using var form = new SecretEditForm(item as SecretModel);
            if (form.ShowDialog(this) == DialogResult.OK && form.Value is not null) await new SecretController(data).SaveAsync(session.UserId, form.Value);
        }
        else if (type == ModuleType.Activities)
        {
            using var form = new ActivityEditForm(item as ActivityModel);
            if (form.ShowDialog(this) == DialogResult.OK && form.Value is not null) await new ActivityController(data).SaveAsync(session.UserId, form.Value);
        }
        else
        {
            using var form = new ContactEditForm(item as ContactModel);
            if (form.ShowDialog(this) == DialogResult.OK && form.Value is not null) await new ContactController(data).SaveAsync(session.UserId, form.Value);
        }
        await RefreshGrid();
    }

    private async void ModuleForm_Shown(object? sender, EventArgs e) => await RefreshGrid();
}
