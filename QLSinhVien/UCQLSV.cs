using System;
using System.Linq;
using System.Windows.Forms;

namespace QLSV
{
    public partial class UCQLSV : UserControl
    {
        public UCQLSV()
        {
            InitializeComponent();
        }

        private void UCQLSV_Load(object sender, EventArgs e)
        {
            LoadLop();
            LoadData();
        }

        private void LoadLop()
        {
            DatabaseDataContext db = new DatabaseDataContext();

            cb_lop.DataSource = db.tbl_lophocs.ToList();

            cb_lop.DisplayMember = "tenlophoc";

            cb_lop.ValueMember = "malop";
        }

        private void LoadData()
        {
            DatabaseDataContext db = new DatabaseDataContext();

            dataGridView2.DataSource = db.tbl_sinhviens.ToList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseDataContext db = new DatabaseDataContext();

                tbl_sinhvien sv = new tbl_sinhvien();

                sv.mssv = tb_mssv.Text;

                sv.hoten = tb_hoten.Text;

                sv.ngaysinh = date.Value;

                sv.gioitinh = cb_gioitinh.Text;

                sv.malop = cb_lop.SelectedValue.ToString();

                db.tbl_sinhviens.InsertOnSubmit(sv);

                db.SubmitChanges();

                LoadData();

                MessageBox.Show("Thêm sinh viên thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}