using System;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Tạo cột
            dgvSinhVien.Columns.Add("MaSV", "Mã Sinh Viên");
            dgvSinhVien.Columns.Add("HoTen", "Họ và Tên");
            dgvSinhVien.Columns.Add("Lop", "Lớp");

            // Thêm dữ liệu mẫu
            dgvSinhVien.Rows.Add("001", "Đinh Tiến Đạt", "68PM2");
            dgvSinhVien.Rows.Add("002", "Nguyễn Văn A", "68PM1");
        }
    }
}