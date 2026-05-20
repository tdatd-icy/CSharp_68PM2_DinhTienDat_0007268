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
            string emailChuan = "dinhtiendat2105@gmail.com";
            string mssvChuan = "0007268";

            string inputEmail = txtEmail.Text;
            string inputPassword = txtPassword.Text;

            if (inputEmail == emailChuan &&
                inputPassword == mssvChuan)
            {
                MessageBox.Show(
                    "Đăng nhập thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Form_main main = new Form_main();

                this.Hide();

                main.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Đăng nhập thất bại!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}