using System;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();

            UCQLSV uc = new UCQLSV();
            uc.Dock = DockStyle.Fill;
            panel_main.Controls.Add(uc);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();

            UCQLSV uc = new UCQLSV();
            uc.Dock = DockStyle.Fill;

            panel_main.Controls.Add(uc);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();

            UCQLLH uc = new UCQLLH();
            uc.Dock = DockStyle.Fill;

            panel_main.Controls.Add(uc);
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}