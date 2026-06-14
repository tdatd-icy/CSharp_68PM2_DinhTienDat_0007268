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

            var data = from sv in db.tbl_sinhviens
                       join lop in db.tbl_lophocs on sv.malop equals lop.malop
                       select new
                       {
                           sv.mssv,
                           sv.hoten,
                           sv.gioitinh,
                           sv.ngaysinh,
                           MaLop = sv.malop,
                           TenLop = lop.tenlophoc
                       };

            dgvSinhVien.DataSource = data.ToList();
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

            if (row.Cells["MaLop"].Value != null)
                cb_lop.SelectedValue = row.Cells["MaLop"].Value.ToString();
            else
                cb_lop.SelectedIndex = -1;

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
            btn_add_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string mssv = tb_mssv.Text.Trim();

                if (string.IsNullOrEmpty(mssv))
                {
                    MessageBox.Show("Vui lòng chọn sinh viên cần cập nhật!");
                    return;
                }

                DatabaseDataContext db = new DatabaseDataContext();
                tbl_sinhvien sv = db.tbl_sinhviens.SingleOrDefault(x => x.mssv == mssv);

                if (sv == null)
                {
                    MessageBox.Show("Không tìm thấy sinh viên có mã này!");
                    return;
                }

                sv.hoten = tb_hoten.Text.Trim();
                sv.ngaysinh = date.Value;
                sv.gioitinh = cb_gioitinh.Text.Trim();
                sv.malop = cb_lop.SelectedValue.ToString();

                db.SubmitChanges();
                LoadData();

                MessageBox.Show("Cập nhật sinh viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string mssv = tb_mssv.Text.Trim();

                if (string.IsNullOrEmpty(mssv))
                {
                    MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn xóa sinh viên có MSSV: " + mssv + " ?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;

                DatabaseDataContext db = new DatabaseDataContext();

                tbl_sinhvien sv = db.tbl_sinhviens
                                   .SingleOrDefault(x => x.mssv == mssv);

                if (sv == null)
                {
                    MessageBox.Show("Không tìm thấy sinh viên!");
                    return;
                }

                db.tbl_sinhviens.DeleteOnSubmit(sv);

                db.SubmitChanges();

                MessageBox.Show(
                    "Đã xóa thành công sinh viên: " + mssv,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadData();

                // Xóa dữ liệu trên form
                tb_mssv.Clear();
                tb_hoten.Clear();
                cb_gioitinh.SelectedIndex = -1;
                cb_lop.SelectedIndex = -1;
                date.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tb_mssv.Clear();
            tb_hoten.Clear();

            cb_gioitinh.SelectedIndex = -1;
            cb_lop.SelectedIndex = -1;

            date.Value = DateTime.Now;

            tb_mssv.Focus();
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}