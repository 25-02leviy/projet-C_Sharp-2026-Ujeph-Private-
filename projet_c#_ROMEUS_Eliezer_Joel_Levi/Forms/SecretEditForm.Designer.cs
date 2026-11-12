namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Forms;

partial class SecretEditForm
{
    private System.ComponentModel.IContainer components = null;
    private Label titleLabel; private Label usernameLabel; private Label passwordLabel; private Label notesLabel;
    private TextBox titleTextBox; private TextBox usernameTextBox; private TextBox passwordTextBox; private TextBox notesTextBox; private Button saveButton;

    protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecretEditForm));
        titleLabel = new Label();
        usernameLabel = new Label();
        passwordLabel = new Label();
        notesLabel = new Label();
        titleTextBox = new TextBox();
        usernameTextBox = new TextBox();
        passwordTextBox = new TextBox();
        notesTextBox = new TextBox();
        saveButton = new Button();
        SuspendLayout();
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Agency FB", 11F);
        titleLabel.Location = new Point(17, 30);
        titleLabel.Margin = new Padding(2, 0, 2, 0);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(29, 18);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Titre";
        // 
        // usernameLabel
        // 
        usernameLabel.AutoSize = true;
        usernameLabel.Font = new Font("Agency FB", 11F);
        usernameLabel.Location = new Point(17, 75);
        usernameLabel.Margin = new Padding(2, 0, 2, 0);
        usernameLabel.Name = "usernameLabel";
        usernameLabel.Size = new Size(47, 18);
        usernameLabel.TabIndex = 1;
        usernameLabel.Text = "Identifiant";
        // 
        // passwordLabel
        // 
        passwordLabel.AutoSize = true;
        passwordLabel.Font = new Font("Agency FB", 11F);
        passwordLabel.Location = new Point(17, 120);
        passwordLabel.Margin = new Padding(2, 0, 2, 0);
        passwordLabel.Name = "passwordLabel";
        passwordLabel.Size = new Size(63, 18);
        passwordLabel.TabIndex = 2;
        passwordLabel.Text = "Mot de passe";
        // 
        // notesLabel
        // 
        notesLabel.AutoSize = true;
        notesLabel.Font = new Font("Agency FB", 11F);
        notesLabel.Location = new Point(17, 165);
        notesLabel.Margin = new Padding(2, 0, 2, 0);
        notesLabel.Name = "notesLabel";
        notesLabel.Size = new Size(32, 18);
        notesLabel.TabIndex = 3;
        notesLabel.Text = "Notes";
        // 
        // titleTextBox
        // 
        titleTextBox.Font = new Font("Agency FB", 10F);
        titleTextBox.Location = new Point(89, 27);
        titleTextBox.Margin = new Padding(2, 3, 2, 3);
        titleTextBox.Name = "titleTextBox";
        titleTextBox.Size = new Size(366, 23);
        titleTextBox.TabIndex = 4;
        // 
        // usernameTextBox
        // 
        usernameTextBox.Font = new Font("Agency FB", 10F);
        usernameTextBox.Location = new Point(89, 72);
        usernameTextBox.Margin = new Padding(2, 3, 2, 3);
        usernameTextBox.Name = "usernameTextBox";
        usernameTextBox.Size = new Size(366, 23);
        usernameTextBox.TabIndex = 5;
        // 
        // passwordTextBox
        // 
        passwordTextBox.Font = new Font("Agency FB", 10F);
        passwordTextBox.Location = new Point(89, 117);
        passwordTextBox.Margin = new Padding(2, 3, 2, 3);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.Size = new Size(366, 23);
        passwordTextBox.TabIndex = 6;
        passwordTextBox.UseSystemPasswordChar = true;
        // 
        // notesTextBox
        // 
        notesTextBox.Font = new Font("Agency FB", 10F);
        notesTextBox.Location = new Point(89, 162);
        notesTextBox.Margin = new Padding(2, 3, 2, 3);
        notesTextBox.Multiline = true;
        notesTextBox.Name = "notesTextBox";
        notesTextBox.Size = new Size(366, 80);
        notesTextBox.TabIndex = 7;
        notesTextBox.TextChanged += notesTextBox_TextChanged;
        // 
        // saveButton
        // 
        saveButton.BackColor = Color.FromArgb(0, 170, 153);
        saveButton.FlatStyle = FlatStyle.Flat;
        saveButton.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        saveButton.ForeColor = Color.White;
        saveButton.Location = new Point(167, 270);
        saveButton.Margin = new Padding(2, 3, 2, 3);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(189, 42);
        saveButton.TabIndex = 8;
        saveButton.Text = "Enregistrer";
        saveButton.UseVisualStyleBackColor = false;
        saveButton.Click += Save_Click;
        // 
        // SecretEditForm
        // 
        AutoScaleDimensions = new SizeF(4F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(247, 243, 241);
        ClientSize = new Size(477, 350);
        Controls.Add(titleLabel);
        Controls.Add(usernameLabel);
        Controls.Add(passwordLabel);
        Controls.Add(notesLabel);
        Controls.Add(titleTextBox);
        Controls.Add(usernameTextBox);
        Controls.Add(passwordTextBox);
        Controls.Add(notesTextBox);
        Controls.Add(saveButton);
        Font = new Font("Agency FB", 9F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(2, 3, 2, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "SecretEditForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Secret";
        ResumeLayout(false);
        PerformLayout();
    }
}