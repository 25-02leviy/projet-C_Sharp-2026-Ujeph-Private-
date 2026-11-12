namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Forms;

partial class ActivityEditForm
{
    private System.ComponentModel.IContainer components = null;
    private Label dateLabel; private Label titleLabel; private Label descriptionLabel; private Label statusLabel;
    private DateTimePicker datePicker; private TextBox titleTextBox; private TextBox descriptionTextBox; private ComboBox statusComboBox; private Button saveButton;

    protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityEditForm));
        dateLabel = new Label();
        titleLabel = new Label();
        descriptionLabel = new Label();
        statusLabel = new Label();
        datePicker = new DateTimePicker();
        titleTextBox = new TextBox();
        descriptionTextBox = new TextBox();
        statusComboBox = new ComboBox();
        saveButton = new Button();
        SuspendLayout();
        // 
        // dateLabel
        // 
        dateLabel.AutoSize = true;
        dateLabel.Font = new Font("Agency FB", 11F);
        dateLabel.Location = new Point(17, 34);
        dateLabel.Margin = new Padding(2, 0, 2, 0);
        dateLabel.Name = "dateLabel";
        dateLabel.Size = new Size(27, 18);
        dateLabel.TabIndex = 0;
        dateLabel.Text = "Date";
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Agency FB", 11F);
        titleLabel.Location = new Point(17, 85);
        titleLabel.Margin = new Padding(2, 0, 2, 0);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(29, 18);
        titleLabel.TabIndex = 1;
        titleLabel.Text = "Titre";
        // 
        // descriptionLabel
        // 
        descriptionLabel.AutoSize = true;
        descriptionLabel.Font = new Font("Agency FB", 11F);
        descriptionLabel.Location = new Point(17, 136);
        descriptionLabel.Margin = new Padding(2, 0, 2, 0);
        descriptionLabel.Name = "descriptionLabel";
        descriptionLabel.Size = new Size(56, 18);
        descriptionLabel.TabIndex = 2;
        descriptionLabel.Text = "Description";
        // 
        // statusLabel
        // 
        statusLabel.AutoSize = true;
        statusLabel.Font = new Font("Agency FB", 11F);
        statusLabel.Location = new Point(17, 244);
        statusLabel.Margin = new Padding(2, 0, 2, 0);
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new Size(33, 18);
        statusLabel.TabIndex = 3;
        statusLabel.Text = "Statut";
        // 
        // datePicker
        // 
        datePicker.Font = new Font("Agency FB", 10F);
        datePicker.Format = DateTimePickerFormat.Short;
        datePicker.Location = new Point(89, 31);
        datePicker.Margin = new Padding(2, 3, 2, 3);
        datePicker.Name = "datePicker";
        datePicker.Size = new Size(364, 23);
        datePicker.TabIndex = 4;
        // 
        // titleTextBox
        // 
        titleTextBox.Font = new Font("Agency FB", 10F);
        titleTextBox.Location = new Point(89, 82);
        titleTextBox.Margin = new Padding(2, 3, 2, 3);
        titleTextBox.Name = "titleTextBox";
        titleTextBox.Size = new Size(364, 23);
        titleTextBox.TabIndex = 5;
        // 
        // descriptionTextBox
        // 
        descriptionTextBox.Font = new Font("Agency FB", 10F);
        descriptionTextBox.Location = new Point(89, 133);
        descriptionTextBox.Margin = new Padding(2, 3, 2, 3);
        descriptionTextBox.Multiline = true;
        descriptionTextBox.Name = "descriptionTextBox";
        descriptionTextBox.Size = new Size(364, 84);
        descriptionTextBox.TabIndex = 6;
        // 
        // statusComboBox
        // 
        statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        statusComboBox.Font = new Font("Agency FB", 10F);
        statusComboBox.Items.AddRange(new object[] { "À faire", "En cours", "Terminée" });
        statusComboBox.Location = new Point(89, 240);
        statusComboBox.Margin = new Padding(2, 3, 2, 3);
        statusComboBox.Name = "statusComboBox";
        statusComboBox.Size = new Size(364, 25);
        statusComboBox.TabIndex = 7;
        // 
        // saveButton
        // 
        saveButton.BackColor = Color.FromArgb(0, 170, 153);
        saveButton.FlatStyle = FlatStyle.Flat;
        saveButton.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        saveButton.ForeColor = Color.White;
        saveButton.Location = new Point(135, 306);
        saveButton.Margin = new Padding(2, 3, 2, 3);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(269, 48);
        saveButton.TabIndex = 8;
        saveButton.Text = "Enregistrer";
        saveButton.UseVisualStyleBackColor = false;
        saveButton.Click += Save_Click;
        // 
        // ActivityEditForm
        // 
        AutoScaleDimensions = new SizeF(4F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(247, 243, 241);
        ClientSize = new Size(477, 392);
        Controls.Add(dateLabel);
        Controls.Add(titleLabel);
        Controls.Add(descriptionLabel);
        Controls.Add(statusLabel);
        Controls.Add(datePicker);
        Controls.Add(titleTextBox);
        Controls.Add(descriptionTextBox);
        Controls.Add(statusComboBox);
        Controls.Add(saveButton);
        Font = new Font("Agency FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(2, 3, 2, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ActivityEditForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Activité";
        ResumeLayout(false);
        PerformLayout();
    }
}