namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Forms;

public partial class RecordEditForm
{
    protected TableLayoutPanel Layout;
    protected Button Save;
    private Label sampleLabel;
    private TextBox sampleTextBox;
    private Label sampleNotesLabel;
    private TextBox sampleNotesTextBox;
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordEditForm));
        Layout = new TableLayoutPanel();
        sampleLabel = new Label();
        sampleTextBox = new TextBox();
        sampleNotesLabel = new Label();
        sampleNotesTextBox = new TextBox();
        Save = new Button();
        Layout.SuspendLayout();
        SuspendLayout();
        // 
        // Layout
        // 
        Layout.BackColor = Color.FromArgb(247, 243, 241);
        Layout.ColumnCount = 2;
        Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 71F));
        Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        Layout.Controls.Add(sampleLabel, 0, 0);
        Layout.Controls.Add(sampleTextBox, 1, 0);
        Layout.Controls.Add(sampleNotesLabel, 0, 1);
        Layout.Controls.Add(sampleNotesTextBox, 1, 1);
        Layout.Controls.Add(Save, 1, 2);
        Layout.Dock = DockStyle.Fill;
        Layout.Location = new Point(0, 0);
        Layout.Margin = new Padding(2, 3, 2, 3);
        Layout.Name = "Layout";
        Layout.Padding = new Padding(11, 20, 11, 20);
        Layout.RowCount = 3;
        Layout.RowStyles.Add(new RowStyle());
        Layout.RowStyles.Add(new RowStyle());
        Layout.RowStyles.Add(new RowStyle());
        Layout.Size = new Size(475, 217);
        Layout.TabIndex = 0;
        // 
        // sampleLabel
        // 
        sampleLabel.AutoSize = true;
        sampleLabel.Font = new Font("Agency FB", 11F);
        sampleLabel.Location = new Point(13, 20);
        sampleLabel.Margin = new Padding(2, 0, 2, 0);
        sampleLabel.Name = "sampleLabel";
        sampleLabel.Padding = new Padding(0, 8, 5, 8);
        sampleLabel.Size = new Size(34, 34);
        sampleLabel.TabIndex = 0;
        sampleLabel.Text = "Titre";
        // 
        // sampleTextBox
        // 
        sampleTextBox.Dock = DockStyle.Fill;
        sampleTextBox.Font = new Font("Agency FB", 10F);
        sampleTextBox.Location = new Point(84, 23);
        sampleTextBox.Margin = new Padding(2, 3, 2, 3);
        sampleTextBox.Name = "sampleTextBox";
        sampleTextBox.Size = new Size(378, 23);
        sampleTextBox.TabIndex = 1;
        // 
        // sampleNotesLabel
        // 
        sampleNotesLabel.AutoSize = true;
        sampleNotesLabel.Font = new Font("Agency FB", 11F);
        sampleNotesLabel.Location = new Point(13, 54);
        sampleNotesLabel.Margin = new Padding(2, 0, 2, 0);
        sampleNotesLabel.Name = "sampleNotesLabel";
        sampleNotesLabel.Padding = new Padding(0, 8, 5, 8);
        sampleNotesLabel.Size = new Size(37, 34);
        sampleNotesLabel.TabIndex = 2;
        sampleNotesLabel.Text = "Notes";
        // 
        // sampleNotesTextBox
        // 
        sampleNotesTextBox.Dock = DockStyle.Fill;
        sampleNotesTextBox.Font = new Font("Agency FB", 10F);
        sampleNotesTextBox.Location = new Point(84, 57);
        sampleNotesTextBox.Margin = new Padding(2, 3, 2, 3);
        sampleNotesTextBox.Multiline = true;
        sampleNotesTextBox.Name = "sampleNotesTextBox";
        sampleNotesTextBox.Size = new Size(378, 80);
        sampleNotesTextBox.TabIndex = 3;
        // 
        // Save
        // 
        Save.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        Save.BackColor = Color.FromArgb(0, 170, 153);
        Save.DialogResult = DialogResult.OK;
        Save.FlatStyle = FlatStyle.Flat;
        Save.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Save.ForeColor = Color.White;
        Save.Location = new Point(187, 143);
        Save.Margin = new Padding(2, 3, 2, 3);
        Save.Name = "Save";
        Save.Size = new Size(171, 54);
        Save.TabIndex = 4;
        Save.Text = "Enregistrer";
        Save.UseVisualStyleBackColor = false;
        // 
        // RecordEditForm
        // 
        AutoScaleDimensions = new SizeF(4F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(247, 243, 241);
        ClientSize = new Size(475, 217);
        Controls.Add(Layout);
        Font = new Font("Agency FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(2, 3, 2, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "RecordEditForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Formulaire d'édition";
        Layout.ResumeLayout(false);
        Layout.PerformLayout();
        ResumeLayout(false);
    }
}