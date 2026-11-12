namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Forms;

partial class CodePromptForm
{
    private System.ComponentModel.IContainer components = null;
    private Label titleLabel;
    private TextBox codeTextBox;
    private Button unlockButton;
    private Button cancelButton;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodePromptForm));
        titleLabel = new Label();
        codeTextBox = new TextBox();
        unlockButton = new Button();
        cancelButton = new Button();
        SuspendLayout();
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        titleLabel.ForeColor = Color.FromArgb(35, 63, 65);
        titleLabel.Location = new Point(25, 20);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(187, 19);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Saisissez votre code secret";
        // 
        // codeTextBox
        // 
        codeTextBox.Font = new Font("Segoe UI", 11F);
        codeTextBox.Location = new Point(25, 55);
        codeTextBox.MaxLength = 12;
        codeTextBox.Name = "codeTextBox";
        codeTextBox.Size = new Size(350, 27);
        codeTextBox.TabIndex = 1;
        codeTextBox.UseSystemPasswordChar = true;
        // 
        // unlockButton
        // 
        unlockButton.BackColor = Color.FromArgb(0, 170, 153);
        unlockButton.FlatStyle = FlatStyle.Flat;
        unlockButton.ForeColor = Color.White;
        unlockButton.Location = new Point(175, 105);
        unlockButton.Name = "unlockButton";
        unlockButton.Size = new Size(125, 35);
        unlockButton.TabIndex = 2;
        unlockButton.Text = "Déverrouiller";
        unlockButton.UseVisualStyleBackColor = false;
        unlockButton.Click += unlockButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.DialogResult = DialogResult.Cancel;
        cancelButton.Location = new Point(310, 105);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(65, 35);
        cancelButton.TabIndex = 3;
        cancelButton.Text = "Annuler";
        // 
        // CodePromptForm
        // 
        AcceptButton = unlockButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(247, 243, 241);
        CancelButton = cancelButton;
        ClientSize = new Size(410, 165);
        Controls.Add(titleLabel);
        Controls.Add(codeTextBox);
        Controls.Add(unlockButton);
        Controls.Add(cancelButton);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "CodePromptForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Code secret";
        ResumeLayout(false);
        PerformLayout();
    }
}
