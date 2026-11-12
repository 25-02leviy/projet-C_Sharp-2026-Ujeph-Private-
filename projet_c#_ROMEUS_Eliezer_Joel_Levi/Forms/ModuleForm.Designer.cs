namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Forms;

partial class ModuleForm
{
    private System.ComponentModel.IContainer components = null;
    private Button addButton;
    private Button deleteButton;
    private Label helpLabel;
    private DataGridView recordsGrid;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleForm));
        addButton = new Button();
        deleteButton = new Button();
        helpLabel = new Label();
        recordsGrid = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)recordsGrid).BeginInit();
        SuspendLayout();
        // 
        // addButton
        // 
        addButton.BackColor = Color.FromArgb(226, 151, 119);
        addButton.FlatStyle = FlatStyle.Flat;
        addButton.Font = new Font("Agency FB", 9.75F, FontStyle.Bold);
        addButton.ForeColor = Color.White;
        addButton.Location = new Point(14, 20);
        addButton.Margin = new Padding(2, 3, 2, 3);
        addButton.Name = "addButton";
        addButton.Size = new Size(159, 38);
        addButton.TabIndex = 0;
        addButton.Text = "+ Ajouter";
        addButton.UseVisualStyleBackColor = false;
        addButton.Click += addButton_Click;
        // 
        // deleteButton
        // 
        deleteButton.BackColor = Color.FromArgb(0, 170, 153);
        deleteButton.FlatStyle = FlatStyle.Flat;
        deleteButton.Font = new Font("Agency FB", 9.75F, FontStyle.Bold);
        deleteButton.ForeColor = Color.White;
        deleteButton.Location = new Point(190, 20);
        deleteButton.Margin = new Padding(2, 3, 2, 3);
        deleteButton.Name = "deleteButton";
        deleteButton.Size = new Size(159, 38);
        deleteButton.TabIndex = 1;
        deleteButton.Text = "Supprimer";
        deleteButton.UseVisualStyleBackColor = false;
        deleteButton.Click += deleteButton_Click;
        // 
        // helpLabel
        // 
        helpLabel.AutoSize = true;
        helpLabel.ForeColor = Color.FromArgb(35, 63, 65);
        helpLabel.Location = new Point(814, 565);
        helpLabel.Margin = new Padding(2, 0, 2, 0);
        helpLabel.Name = "helpLabel";
        helpLabel.Size = new Size(163, 15);
        helpLabel.TabIndex = 2;
        helpLabel.Text = "Double-cliquez sur une ligne pour la modifier.";
        // 
        // recordsGrid
        // 
        recordsGrid.AllowUserToAddRows = false;
        recordsGrid.AllowUserToDeleteRows = false;
        recordsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        recordsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        recordsGrid.BackgroundColor = Color.White;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridViewCellStyle1.Font = new Font("Agency FB", 10F);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(226, 151, 119);
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        recordsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        recordsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Agency FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(226, 151, 119);
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        recordsGrid.DefaultCellStyle = dataGridViewCellStyle2;
        recordsGrid.Location = new Point(14, 75);
        recordsGrid.Margin = new Padding(2, 3, 2, 3);
        recordsGrid.MultiSelect = false;
        recordsGrid.Name = "recordsGrid";
        recordsGrid.ReadOnly = true;
        recordsGrid.RowHeadersVisible = false;
        recordsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        recordsGrid.Size = new Size(972, 487);
        recordsGrid.TabIndex = 3;
        recordsGrid.DoubleClick += recordsGrid_DoubleClick;
        // 
        // ModuleForm
        // 
        AutoScaleDimensions = new SizeF(4F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(247, 243, 241);
        ClientSize = new Size(1012, 607);
        Controls.Add(addButton);
        Controls.Add(deleteButton);
        Controls.Add(helpLabel);
        Controls.Add(recordsGrid);
        Font = new Font("Agency FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(2, 3, 2, 3);
        Name = "ModuleForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Module";
        Shown += ModuleForm_Shown;
        ((System.ComponentModel.ISupportInitialize)recordsGrid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
