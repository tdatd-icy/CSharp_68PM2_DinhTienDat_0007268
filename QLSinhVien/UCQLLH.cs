using System;
using System.Linq;
using System.Windows.Forms;

namespace QLSV
{
    public partial class UCQLLH : UserControl
    {
        private int totalPage;
        private int currentPage = 1;
        private int pageSize = 10;
        private string searchKeyword = "";

        public UCQLLH()
        {
            InitializeComponent();
        }

        private void UCQLLH_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DatabaseDataContext db = new DatabaseDataContext();

            var query = from lop in db.tbl_lophocs
                        select new
                        {
                            lop.id,
                            lop.malop,
                            lop.tenlophoc,
                            lop.ghichu
                        };

            if (!string.IsNullOrEmpty(searchKeyword))
            {
                query = query.Where(x =>
                    x.malop.ToLower().Contains(searchKeyword) ||
                    x.tenlophoc.ToLower().Contains(searchKeyword) ||
                    (x.ghichu != null && x.ghichu.ToLower().Contains(searchKeyword)));
            }

            int totalRecord = query.Count();
            totalPage = (int)Math.Ceiling((double)totalRecord / pageSize);

            if (totalPage == 0)
                totalPage = 1;

            if (currentPage > totalPage)
                currentPage = totalPage;

            dgvLopHoc.DataSource = query
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            label7.Text = $"Trang {currentPage}/{totalPage}";
        }

        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvLopHoc.Rows[e.RowIndex];

            txtID.Text = row.Cells["id"].Value?.ToString() ?? "";
            txtMaLop.Text = row.Cells["malop"].Value?.ToString() ?? "";
            txtTenLop.Text = row.Cells["tenlophoc"].Value?.ToString() ?? "";
            txtGhiChu.Text = row.Cells["ghichu"].Value?.ToString() ?? "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseDataContext db = new DatabaseDataContext();

                tbl_lophoc lop = new tbl_lophoc();
                lop.malop = txtMaLop.Text.Trim();
                lop.tenlophoc = txtTenLop.Text.Trim();
                lop.ghichu = txtGhiChu.Text.Trim();

                db.tbl_lophocs.InsertOnSubmit(lop);
                db.SubmitChanges();

                MessageBox.Show("Thêm lớp thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maLop = txtMaLop.Text.Trim();

                if (string.IsNullOrEmpty(maLop))
                {
                    MessageBox.Show("Vui lòng chọn lớp cần cập nhật!");
                    return;
                }

                DatabaseDataContext db = new DatabaseDataContext();

                tbl_lophoc lop = db.tbl_lophocs.SingleOrDefault(x => x.malop == maLop);

                if (lop == null)
                {
                    MessageBox.Show("Không tìm thấy lớp!");
                    return;
                }

                lop.tenlophoc = txtTenLop.Text.Trim();
                lop.ghichu = txtGhiChu.Text.Trim();

                db.SubmitChanges();

                MessageBox.Show("Cập nhật lớp thành công!");
                LoadData();
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
                string maLop = txtMaLop.Text.Trim();

                if (string.IsNullOrEmpty(maLop))
                {
                    MessageBox.Show("Vui lòng chọn lớp cần xóa!");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn xóa lớp này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;

                DatabaseDataContext db = new DatabaseDataContext();

                tbl_lophoc lop = db.tbl_lophocs.SingleOrDefault(x => x.malop == maLop);

                if (lop == null)
                {
                    MessageBox.Show("Không tìm thấy lớp!");
                    return;
                }

                db.tbl_lophocs.DeleteOnSubmit(lop);
                db.SubmitChanges();

                MessageBox.Show("Xóa lớp thành công!");
                LoadData();

                txtID.Clear();
                txtMaLop.Clear();
                txtTenLop.Clear();
                txtGhiChu.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtGhiChu.Clear();
            txtTimKiem.Clear();

            searchKeyword = "";
            currentPage = 1;

            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            searchKeyword = txtTimKiem.Text.Trim().ToLower();
            currentPage = 1;
            LoadData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPage)
            {
                currentPage++;
                LoadData();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentPage = totalPage;
            LoadData();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvLopHoc_CellClick(sender, e);
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvLopHoc_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}