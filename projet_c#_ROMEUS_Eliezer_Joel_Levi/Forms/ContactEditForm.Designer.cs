namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Forms;

partial class ContactEditForm
{
    private System.ComponentModel.IContainer components = null;
    private Label firstNameLabel; private Label lastNameLabel; private Label phoneLabel; private Label emailLabel; private Label notesLabel;
    private TextBox firstNameTextBox; private TextBox lastNameTextBox; private TextBox phoneTextBox; private TextBox emailTextBox; private TextBox notesTextBox; private Button saveButton;

    protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactEditForm));
        firstNameLabel = new Label();
        lastNameLabel = new Label();
        phoneLabel = new Label();
        emailLabel = new Label();
        notesLabel = new Label();
        firstNameTextBox = new TextBox();
        lastNameTextBox = new TextBox();
        phoneTextBox = new TextBox();
        emailTextBox = new TextBox();
        notesTextBox = new TextBox();
        saveButton = new Button();
        SuspendLayout();
        // 
        // firstNameLabel
        // 
        firstNameLabel.AutoSize = true;
        firstNameLabel.Location = new Point(17, 34);
        firstNameLabel.Margin = new Padding(2, 0, 2, 0);
        firstNameLabel.Name = "firstNameLabel";
        firstNameLabel.Size = new Size(41, 18);
        firstNameLabel.TabIndex = 0;
        firstNameLabel.Text = "Prénom";
        // 
        // lastNameLabel
        // 
        lastNameLabel.AutoSize = true;
        lastNameLabel.Location = new Point(17, 85);
        lastNameLabel.Margin = new Padding(2, 0, 2, 0);
        lastNameLabel.Name = "lastNameLabel";
        lastNameLabel.Size = new Size(26, 18);
        lastNameLabel.TabIndex = 1;
        lastNameLabel.Text = "Nom";
        // 
        // phoneLabel
        // 
        phoneLabel.AutoSize = true;
        phoneLabel.Location = new Point(17, 136);
        phoneLabel.Margin = new Padding(2, 0, 2, 0);
        phoneLabel.Name = "phoneLabel";
        phoneLabel.Size = new Size(51, 18);
        phoneLabel.TabIndex = 2;
        phoneLabel.Text = "Téléphone";
        // 
        // emailLabel
        // 
        emailLabel.AutoSize = true;
        emailLabel.Location = new Point(17, 187);
        emailLabel.Margin = new Padding(2, 0, 2, 0);
        emailLabel.Name = "emailLabel";
        emailLabel.Size = new Size(29, 18);
        emailLabel.TabIndex = 3;
        emailLabel.Text = "Email";
        // 
        // notesLabel
        // 
        notesLabel.AutoSize = true;
        notesLabel.Location = new Point(17, 238);
        notesLabel.Margin = new Padding(2, 0, 2, 0);
        notesLabel.Name = "notesLabel";
        notesLabel.Size = new Size(31, 18);
        notesLabel.TabIndex = 4;
        notesLabel.Text = "Notes";
        // 
        // firstNameTextBox
        // 
        firstNameTextBox.Location = new Point(89, 31);
        firstNameTextBox.Margin = new Padding(2, 3, 2, 3);
        firstNameTextBox.Name = "firstNameTextBox";
        firstNameTextBox.Size = new Size(358, 23);
        firstNameTextBox.TabIndex = 5;
        // 
        // lastNameTextBox
        // 
        lastNameTextBox.Location = new Point(89, 82);
        lastNameTextBox.Margin = new Padding(2, 3, 2, 3);
        lastNameTextBox.Name = "lastNameTextBox";
        lastNameTextBox.Size = new Size(358, 23);
        lastNameTextBox.TabIndex = 6;
        lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;
        // 
        // phoneTextBox
        // 
        phoneTextBox.Location = new Point(89, 133);
        phoneTextBox.Margin = new Padding(2, 3, 2, 3);
        phoneTextBox.Name = "phoneTextBox";
        phoneTextBox.Size = new Size(358, 23);
        phoneTextBox.TabIndex = 7;
        // 
        // emailTextBox
        // 
        emailTextBox.Location = new Point(89, 184);
        emailTextBox.Margin = new Padding(2, 3, 2, 3);
        emailTextBox.Name = "emailTextBox";
        emailTextBox.Size = new Size(358, 23);
        emailTextBox.TabIndex = 8;
        // 
        // notesTextBox
        // 
        notesTextBox.Location = new Point(89, 235);
        notesTextBox.Margin = new Padding(2, 3, 2, 3);
        notesTextBox.Multiline = true;
        notesTextBox.Name = "notesTextBox";
        notesTextBox.Size = new Size(358, 84);
        notesTextBox.TabIndex = 9;
        // 
        // saveButton
        // 
        saveButton.BackColor = Color.FromArgb(0, 170, 153);
        saveButton.FlatStyle = FlatStyle.Flat;
        saveButton.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        saveButton.ForeColor = Color.White;
        saveButton.Location = new Point(168, 351);
        saveButton.Margin = new Padding(2, 3, 2, 3);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(189, 48);
        saveButton.TabIndex = 10;
        saveButton.Text = "Enregistrer";
        saveButton.UseVisualStyleBackColor = false;
        saveButton.Click += Save_Click;
        // 
        // ContactEditForm
        // 
        AutoScaleDimensions = new SizeF(4F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(247, 243, 241);
        ClientSize = new Size(477, 442);
        Controls.Add(firstNameLabel);
        Controls.Add(lastNameLabel);
        Controls.Add(phoneLabel);
        Controls.Add(emailLabel);
        Controls.Add(notesLabel);
        Controls.Add(firstNameTextBox);
        Controls.Add(lastNameTextBox);
        Controls.Add(phoneTextBox);
        Controls.Add(emailTextBox);
        Controls.Add(notesTextBox);
        Controls.Add(saveButton);
        Font = new Font("Agency FB", 10F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(2, 3, 2, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ContactEditForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Contact";
        Load += ContactEditForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }
}