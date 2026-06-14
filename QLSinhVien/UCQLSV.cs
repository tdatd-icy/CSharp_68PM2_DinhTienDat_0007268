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
            dgvSinhVien.DataSource = db.tbl_sinhviens.ToList();
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

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

            tb_mssv.Text = row.Cells["mssv"].Value?.ToString() ?? "";
            tb_hoten.Text = row.Cells["hoten"].Value?.ToString() ?? "";
            cb_gioitinh.Text = row.Cells["gioitinh"].Value?.ToString() ?? "";
            cb_lop.Text = row.Cells["malop"].Value?.ToString() ?? "";

            if (DateTime.TryParse(row.Cells["ngaysinh"].Value?.ToString(), out DateTime ns))
                date.Value = ns;
            else
                date.Value = DateTime.Now;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void dvgSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}