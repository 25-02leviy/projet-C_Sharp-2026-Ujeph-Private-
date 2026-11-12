namespace projet_c__ROMEUS_Eliezer_Joel_Levi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Panel cardPanel;
        private Label titleLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private Label secretCodeLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private TextBox secretCodeTextBox;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cardPanel = new Panel();
            button1 = new Button();
            label1 = new Label();
            titleLabel = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            secretCodeLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            secretCodeTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            cardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cardPanel
            // 
            cardPanel.BackColor = Color.FromArgb(247, 243, 241);
            cardPanel.Controls.Add(button1);
            cardPanel.Controls.Add(label1);
            cardPanel.Controls.Add(titleLabel);
            cardPanel.Controls.Add(usernameLabel);
            cardPanel.Controls.Add(passwordLabel);
            cardPanel.Controls.Add(secretCodeLabel);
            cardPanel.Controls.Add(usernameTextBox);
            cardPanel.Controls.Add(passwordTextBox);
            cardPanel.Controls.Add(secretCodeTextBox);
            cardPanel.Controls.Add(pictureBox1);
            cardPanel.Location = new Point(-2, -5);
            cardPanel.Margin = new Padding(4, 3, 4, 3);
            cardPanel.Name = "cardPanel";
            cardPanel.Size = new Size(516, 508);
            cardPanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 170, 153);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Bisque;
            button1.Location = new Point(51, 359);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(401, 57);
            button1.TabIndex = 10;
            button1.Text = "Se Connecter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_ClickAsync;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.Font = new Font("Agency FB", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 170, 153);
            label1.Location = new Point(51, 77);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 9;
            label1.Text = "Créer votre Compte :";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Bisque;
            titleLabel.Font = new Font("Agency FB", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.FromArgb(0, 170, 153);
            titleLabel.Location = new Point(47, 35);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(251, 42);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Créer votre Compte";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.NavajoWhite;
            usernameLabel.BorderStyle = BorderStyle.Fixed3D;
            usernameLabel.Font = new Font("Agency FB", 11F, FontStyle.Bold);
            usernameLabel.ForeColor = Color.FromArgb(0, 114, 102);
            usernameLabel.Location = new Point(65, 116);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(95, 20);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Nom d'utilisateur";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.NavajoWhite;
            passwordLabel.BorderStyle = BorderStyle.Fixed3D;
            passwordLabel.Font = new Font("Agency FB", 11F, FontStyle.Bold);
            passwordLabel.ForeColor = Color.FromArgb(0, 114, 102);
            passwordLabel.Location = new Point(65, 191);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(75, 20);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Mot de passe";
            // 
            // secretCodeLabel
            // 
            secretCodeLabel.AutoSize = true;
            secretCodeLabel.BackColor = Color.NavajoWhite;
            secretCodeLabel.BorderStyle = BorderStyle.Fixed3D;
            secretCodeLabel.Font = new Font("Agency FB", 11F, FontStyle.Bold);
            secretCodeLabel.ForeColor = Color.FromArgb(0, 114, 102);
            secretCodeLabel.Location = new Point(65, 266);
            secretCodeLabel.Margin = new Padding(4, 0, 4, 0);
            secretCodeLabel.Name = "secretCodeLabel";
            secretCodeLabel.Size = new Size(132, 20);
            secretCodeLabel.TabIndex = 3;
            secretCodeLabel.Text = "Code secret des secrets";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.NavajoWhite;
            usernameTextBox.Cursor = Cursors.IBeam;
            usernameTextBox.Font = new Font("Agency FB", 11.25F);
            usernameTextBox.Location = new Point(51, 142);
            usernameTextBox.Margin = new Padding(4, 3, 4, 3);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(400, 25);
            usernameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.NavajoWhite;
            passwordTextBox.Cursor = Cursors.IBeam;
            passwordTextBox.Font = new Font("Agency FB", 11.25F);
            passwordTextBox.Location = new Point(51, 217);
            passwordTextBox.Margin = new Padding(4, 3, 4, 3);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(400, 25);
            passwordTextBox.TabIndex = 5;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // secretCodeTextBox
            // 
            secretCodeTextBox.BackColor = Color.NavajoWhite;
            secretCodeTextBox.Cursor = Cursors.IBeam;
            secretCodeTextBox.Font = new Font("Agency FB", 11.25F);
            secretCodeTextBox.Location = new Point(51, 292);
            secretCodeTextBox.Margin = new Padding(4, 3, 4, 3);
            secretCodeTextBox.Name = "secretCodeTextBox";
            secretCodeTextBox.PasswordChar = '*';
            secretCodeTextBox.Size = new Size(400, 25);
            secretCodeTextBox.TabIndex = 6;
            secretCodeTextBox.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(509, 518);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 197, 181);
            ClientSize = new Size(502, 503);
            Controls.Add(cardPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Secret";
            cardPanel.ResumeLayout(false);
            cardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
    }
}
