using System;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Khai báo thông tin chuẩn (Phải khớp với tên biến bên dưới)
            string emailChuan = "dinhtiendat2105@gmail.com";
            string mssvChuan = "0007268";

            // 2. Lấy dữ liệu người dùng nhập từ TextBox (Lưu ý đúng tên TextBox của bạn)
            // Giả sử tên TextBox của bạn là txtEmail và txtPassword
            string inputEmail = txtEmail.Text;
            string inputPassword = txtPassword.Text;

            // 3. So sánh (Phải dùng đúng tên biến đã khai báo ở trên)
            if (inputEmail == emailChuan && inputPassword == mssvChuan)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                Form2 f2 = new Form2();
                this.Hide();
                f2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}