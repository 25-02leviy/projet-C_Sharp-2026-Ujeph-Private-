using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projet_c__ROMEUS_Eliezer_Joel_Levi
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
            progressBar1.BackColor = Color.Bisque;
            progressBar1.ForeColor = Color.FromArgb(226, 151, 119);
            pictureBox1.SendToBack();
            progressBar1.BringToFront();
            label1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loading_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = Math.Min(progressBar1.Maximum, progressBar1.Value + 8);

            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
