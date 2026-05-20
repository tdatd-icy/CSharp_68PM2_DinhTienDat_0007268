using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GDQLSV uCQLSV = new GDQLSV();
            panel_main.Controls.Clear();
            panel_main.Controls.Add(uCQLSV);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GDQLLH uCQLLH = new GDQLLH();
            panel_main.Controls.Clear();
            panel_main.Controls.Add(uCQLLH);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();

            login.Show();

            this.Hide();
        }
    }
}
