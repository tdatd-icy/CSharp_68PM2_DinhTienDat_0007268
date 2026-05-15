namespace QLSinhVien
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelLeft = new Panel();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            cboLop = new ComboBox();
            label5 = new Label();
            cboGioiTinh = new ComboBox();
            label4 = new Label();
            dtpNgaySinh = new DateTimePicker();
            label3 = new Label();
            txtHoTen = new TextBox();
            label2 = new Label();
            txtMaSV = new TextBox();
            label1 = new Label();
            panelRight = new Panel();
            dgvSinhVien = new DataGridView();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label6 = new Label();
            panelLeft.SuspendLayout();
            groupBox1.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(242, 242, 242);
            panelLeft.Controls.Add(btnLamMoi);
            panelLeft.Controls.Add(btnXoa);
            panelLeft.Controls.Add(btnSua);
            panelLeft.Controls.Add(btnThem);
            panelLeft.Controls.Add(groupBox1);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(330, 661);
            panelLeft.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboLop);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboGioiTinh);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 350);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // label1 - label5 (Các nhãn và ô nhập liệu tương ứng)
            label1.Text = "Mã sinh viên:"; label1.Location = new Point(15, 30);
            txtMaSV.Location = new Point(15, 55); txtMaSV.Size = new Size(270, 27);

            label2.Text = "Họ và tên:"; label2.Location = new Point(15, 95);
            txtHoTen.Location = new Point(15, 120); txtHoTen.Size = new Size(270, 27);

            label3.Text = "Ngày sinh:"; label3.Location = new Point(15, 160);
            dtpNgaySinh.Location = new Point(15, 185); dtpNgaySinh.Size = new Size(270, 27);

            label4.Text = "Giới tính:"; label4.Location = new Point(15, 225);
            cboGioiTinh.Location = new Point(15, 250); cboGioiTinh.Size = new Size(270, 27);

            label5.Text = "Lớp:"; label5.Location = new Point(15, 290);
            cboLop.Location = new Point(15, 315); cboLop.Size = new Size(270, 27);
            // 
            // Nút bấm (Sắp xếp 2x2 như trong ảnh)
            btnThem.BackColor = Color.FromArgb(52, 152, 219);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(12, 380); btnThem.Size = new Size(145, 45);
            btnThem.Text = "Thêm"; btnThem.FlatStyle = FlatStyle.Flat;

            btnSua.BackColor = Color.FromArgb(46, 204, 113);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(167, 380); btnSua.Size = new Size(145, 45);
            btnSua.Text = "Sửa"; btnSua.FlatStyle = FlatStyle.Flat;

            btnXoa.BackColor = Color.FromArgb(231, 76, 60);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(12, 435); btnXoa.Size = new Size(145, 45);
            btnXoa.Text = "Xóa"; btnXoa.FlatStyle = FlatStyle.Flat;

            btnLamMoi.BackColor = Color.FromArgb(127, 140, 141);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(167, 435); btnLamMoi.Size = new Size(145, 45);
            btnLamMoi.Text = "Làm mới"; btnLamMoi.FlatStyle = FlatStyle.Flat;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(dgvSinhVien);
            panelRight.Controls.Add(btnTimKiem);
            panelRight.Controls.Add(txtTimKiem);
            panelRight.Controls.Add(label6);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(330, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(754, 661);
            panelRight.TabIndex = 1;
            // 
            // label6 - Tìm kiếm
            label6.Text = "Tìm kiếm (Tên / Mã SV / Lớp):";
            label6.Location = new Point(20, 20); label6.AutoSize = true;
            txtTimKiem.Location = new Point(20, 45); txtTimKiem.Size = new Size(400, 27);
            btnTimKiem.Text = "Tìm"; btnTimKiem.Location = new Point(430, 40);
            btnTimKiem.Size = new Size(100, 35); btnTimKiem.BackColor = Color.FromArgb(52, 73, 94);
            btnTimKiem.ForeColor = Color.White; btnTimKiem.FlatStyle = FlatStyle.Flat;
            // 
            // dgvSinhVien
            dgvSinhVien.BackgroundColor = Color.White;
            dgvSinhVien.Location = new Point(20, 90);
            dgvSinhVien.Size = new Size(710, 500);
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // 
            // Form2
            // 
            ClientSize = new Size(1084, 661);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Name = "Form2";
            Text = "Quản Lý Sinh Viên";
            StartPosition = FormStartPosition.CenterScreen;
            panelLeft.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
        }

        private Panel panelLeft;
        private Panel panelRight;
        private GroupBox groupBox1;
        private Label label1, label2, label3, label4, label5, label6;
        private TextBox txtMaSV, txtHoTen, txtTimKiem;
        private ComboBox cboGioiTinh, cboLop;
        private DateTimePicker dtpNgaySinh;
        private Button btnThem, btnSua, btnXoa, btnLamMoi, btnTimKiem;
        private DataGridView dgvSinhVien;
    }
}