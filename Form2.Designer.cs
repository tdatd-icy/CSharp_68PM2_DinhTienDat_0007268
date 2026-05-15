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
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(127, 140, 141);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(167, 435);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(145, 45);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(231, 76, 60);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(12, 435);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(145, 45);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(46, 204, 113);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(167, 380);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(145, 45);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(52, 152, 219);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(12, 380);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(145, 45);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
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
            // cboLop
            // 
            cboLop.Location = new Point(15, 315);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(270, 33);
            cboLop.TabIndex = 0;
            // 
            // label5
            // 
            label5.Location = new Point(15, 290);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 1;
            label5.Text = "Lớp:";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.Location = new Point(15, 250);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(270, 33);
            cboGioiTinh.TabIndex = 2;
            // 
            // label4
            // 
            label4.Location = new Point(15, 225);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 3;
            label4.Text = "Giới tính:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(15, 185);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(270, 31);
            dtpNgaySinh.TabIndex = 4;
            // 
            // label3
            // 
            label3.Location = new Point(15, 160);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 5;
            label3.Text = "Ngày sinh:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(15, 120);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(270, 31);
            txtHoTen.TabIndex = 6;
            // 
            // label2
            // 
            label2.Location = new Point(15, 95);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 7;
            label2.Text = "Họ và tên:";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(15, 55);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(270, 31);
            txtMaSV.TabIndex = 8;
            // 
            // label1
            // 
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 9;
            label1.Text = "Mã sinh viên:";
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
            // dgvSinhVien
            // 
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.BackgroundColor = Color.White;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(20, 90);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 62;
            dgvSinhVien.Size = new Size(710, 500);
            dgvSinhVien.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(52, 73, 94);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(430, 40);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 35);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(20, 45);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(400, 31);
            txtTimKiem.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 20);
            label6.Name = "label6";
            label6.Size = new Size(244, 25);
            label6.TabIndex = 3;
            label6.Text = "Tìm kiếm (Tên / Mã SV / Lớp):";
            // 
            // Form2
            // 
            ClientSize = new Size(1084, 661);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sinh Viên";
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