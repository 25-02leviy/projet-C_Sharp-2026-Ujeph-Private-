namespace projet_c__ROMEUS_Eliezer_Joel_Levi;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private Panel dashboardPanel;
    private Label welcomeLabel;
    private Label subtitleLabel;
    private Button secretsButton;
    private Button activitiesButton;
    private Button contactsButton;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        dashboardPanel = new Panel();
        pictureBox3 = new PictureBox();
        pictureBox2 = new PictureBox();
        pictureBox5 = new PictureBox();
        welcomeLabel = new Label();
        subtitleLabel = new Label();
        secretsButton = new Button();
        activitiesButton = new Button();
        contactsButton = new Button();
        pictureBox1 = new PictureBox();
        modulesMenuItem = new ToolStripMenuItem();
        secretsMenuItem = new ToolStripMenuItem();
        activitiesMenuItem = new ToolStripMenuItem();
        contactsMenuItem = new ToolStripMenuItem();
        newAccountToolStripMenuItem = new ToolStripMenuItem();
        logoutMenuItem = new ToolStripMenuItem();
        menuStrip = new MenuStrip();
        dashboardPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        menuStrip.SuspendLayout();
        SuspendLayout();
        // 
        // dashboardPanel
        // 
        dashboardPanel.BackColor = Color.FromArgb(247, 243, 241);
        dashboardPanel.Controls.Add(pictureBox3);
        dashboardPanel.Controls.Add(pictureBox2);
        dashboardPanel.Controls.Add(pictureBox5);
        dashboardPanel.Controls.Add(welcomeLabel);
        dashboardPanel.Controls.Add(subtitleLabel);
        dashboardPanel.Controls.Add(secretsButton);
        dashboardPanel.Controls.Add(activitiesButton);
        dashboardPanel.Controls.Add(contactsButton);
        dashboardPanel.Controls.Add(pictureBox1);
        dashboardPanel.Dock = DockStyle.Fill;
        dashboardPanel.Location = new Point(0, 25);
        dashboardPanel.Name = "dashboardPanel";
        dashboardPanel.Padding = new Padding(80, 60, 40, 40);
        dashboardPanel.Size = new Size(1100, 728);
        dashboardPanel.TabIndex = 1;
        // 
        // pictureBox3
        // 
        pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
        pictureBox3.Location = new Point(983, 397);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(67, 62);
        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox3.TabIndex = 11;
        pictureBox3.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
        pictureBox2.Location = new Point(633, 388);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(69, 71);
        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox2.TabIndex = 10;
        pictureBox2.TabStop = false;
        // 
        // pictureBox5
        // 
        pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
        pictureBox5.Location = new Point(30, 410);
        pictureBox5.Name = "pictureBox5";
        pictureBox5.Size = new Size(319, 27);
        pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox5.TabIndex = 9;
        pictureBox5.TabStop = false;
        // 
        // welcomeLabel
        // 
        welcomeLabel.AutoSize = true;
        welcomeLabel.BackColor = Color.Linen;
        welcomeLabel.BorderStyle = BorderStyle.Fixed3D;
        welcomeLabel.Font = new Font("Agency FB", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
        welcomeLabel.ForeColor = Color.FromArgb(0, 170, 153);
        welcomeLabel.Location = new Point(80, 41);
        welcomeLabel.Name = "welcomeLabel";
        welcomeLabel.Size = new Size(170, 61);
        welcomeLabel.TabIndex = 0;
        welcomeLabel.Text = "Bonjour !";
        // 
        // subtitleLabel
        // 
        subtitleLabel.AutoSize = true;
        subtitleLabel.BackColor = Color.Bisque;
        subtitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        subtitleLabel.ForeColor = Color.FromArgb(35, 63, 65);
        subtitleLabel.Location = new Point(84, 110);
        subtitleLabel.Name = "subtitleLabel";
        subtitleLabel.Size = new Size(221, 30);
        subtitleLabel.TabIndex = 1;
        subtitleLabel.Text = "Bienvenue dans votre espace personnel.\nChoisissez une action pour commencer :";
        // 
        // secretsButton
        // 
        secretsButton.BackColor = Color.FromArgb(0, 114, 102);
        secretsButton.Cursor = Cursors.Hand;
        secretsButton.Font = new Font("Agency FB", 12F, FontStyle.Bold);
        secretsButton.ForeColor = Color.Bisque;
        secretsButton.Location = new Point(30, 287);
        secretsButton.Name = "secretsButton";
        secretsButton.Size = new Size(319, 178);
        secretsButton.TabIndex = 2;
        secretsButton.Text = "Secrets";
        secretsButton.UseVisualStyleBackColor = false;
        secretsButton.Click += secretsButton_Click;
        // 
        // activitiesButton
        // 
        activitiesButton.BackColor = Color.FromArgb(0, 195, 173);
        activitiesButton.Cursor = Cursors.Hand;
        activitiesButton.Font = new Font("Agency FB", 12F, FontStyle.Bold);
        activitiesButton.ForeColor = Color.Bisque;
        activitiesButton.Location = new Point(391, 287);
        activitiesButton.Name = "activitiesButton";
        activitiesButton.Size = new Size(319, 178);
        activitiesButton.TabIndex = 3;
        activitiesButton.Text = "Activités journalières";
        activitiesButton.UseVisualStyleBackColor = false;
        activitiesButton.Click += activitiesButton_Click;
        // 
        // contactsButton
        // 
        contactsButton.BackColor = Color.FromArgb(222, 147, 119);
        contactsButton.Cursor = Cursors.Hand;
        contactsButton.Font = new Font("Agency FB", 12F, FontStyle.Bold);
        contactsButton.ForeColor = Color.Bisque;
        contactsButton.Location = new Point(738, 287);
        contactsButton.Name = "contactsButton";
        contactsButton.Size = new Size(319, 178);
        contactsButton.TabIndex = 4;
        contactsButton.Text = "Contacts";
        contactsButton.UseVisualStyleBackColor = false;
        contactsButton.Click += contactsButton_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(0, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(1100, 726);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 5;
        pictureBox1.TabStop = false;
        // 
        // modulesMenuItem
        // 
        modulesMenuItem.DropDownItems.AddRange(new ToolStripItem[] { secretsMenuItem, activitiesMenuItem, contactsMenuItem, newAccountToolStripMenuItem });
        modulesMenuItem.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        modulesMenuItem.Name = "modulesMenuItem";
        modulesMenuItem.Size = new Size(61, 21);
        modulesMenuItem.Text = "Modules";
        // 
        // secretsMenuItem
        // 
        secretsMenuItem.Name = "secretsMenuItem";
        secretsMenuItem.Size = new Size(211, 22);
        secretsMenuItem.Text = "Secrets";
        secretsMenuItem.Click += secretsMenuItem_Click;
        // 
        // activitiesMenuItem
        // 
        activitiesMenuItem.Name = "activitiesMenuItem";
        activitiesMenuItem.Size = new Size(211, 22);
        activitiesMenuItem.Text = "Activités Journalières";
        activitiesMenuItem.Click += activitiesMenuItem_Click;
        // 
        // contactsMenuItem
        // 
        contactsMenuItem.Name = "contactsMenuItem";
        contactsMenuItem.Size = new Size(211, 22);
        contactsMenuItem.Text = "Contacts";
        contactsMenuItem.Click += contactsMenuItem_Click;
        // 
        // newAccountToolStripMenuItem
        // 
        newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
        newAccountToolStripMenuItem.Size = new Size(211, 22);
        newAccountToolStripMenuItem.Text = "Nouveau Compte Utilisateur";
        newAccountToolStripMenuItem.Click += newAccountToolStripMenuItem_Click;
        // 
        // logoutMenuItem
        // 
        logoutMenuItem.Alignment = ToolStripItemAlignment.Right;
        logoutMenuItem.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        logoutMenuItem.Name = "logoutMenuItem";
        logoutMenuItem.Size = new Size(83, 21);
        logoutMenuItem.Text = "Déconnexion";
        logoutMenuItem.Click += logoutMenuItem_Click;
        // 
        // menuStrip
        // 
        menuStrip.BackColor = Color.FromArgb(0, 170, 153);
        menuStrip.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        menuStrip.ForeColor = Color.White;
        menuStrip.Items.AddRange(new ToolStripItem[] { modulesMenuItem, logoutMenuItem });
        menuStrip.Location = new Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new Size(1100, 25);
        menuStrip.TabIndex = 0;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(247, 243, 241);
        ClientSize = new Size(1100, 753);
        Controls.Add(dashboardPanel);
        Controls.Add(menuStrip);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MainMenuStrip = menuStrip;
        MinimumSize = new Size(900, 600);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        dashboardPanel.ResumeLayout(false);
        dashboardPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private static void ConfigureModuleButton(Button button, string text, Color color, Point location, EventHandler clickHandler)
    {
        button.BackColor = color; button.Cursor = Cursors.Hand; button.FlatAppearance.BorderSize = 0; button.FlatStyle = FlatStyle.Flat; button.Font = new Font("Segoe UI", 12F, FontStyle.Bold); button.ForeColor = Color.White; button.Location = location; button.Name = text.Replace(" ", ""); button.Size = new Size(200, 80); button.Text = text; button.UseVisualStyleBackColor = false; button.Click += clickHandler;
    }

    private PictureBox pictureBox1;
    private PictureBox pictureBox5;
    private PictureBox pictureBox2;
    private PictureBox pictureBox3;
    private ToolStripMenuItem modulesMenuItem;
    private ToolStripMenuItem secretsMenuItem;
    private ToolStripMenuItem activitiesMenuItem;
    private ToolStripMenuItem contactsMenuItem;
    private ToolStripMenuItem logoutMenuItem;
    private MenuStrip menuStrip;
    private ToolStripMenuItem newAccountToolStripMenuItem;
}
