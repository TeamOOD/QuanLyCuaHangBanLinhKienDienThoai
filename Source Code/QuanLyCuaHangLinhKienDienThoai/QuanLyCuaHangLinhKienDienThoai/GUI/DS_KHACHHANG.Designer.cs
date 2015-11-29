namespace QuanLyCuaHangLinhKienDienThoai.GUI
{
    partial class DS_KHACHHANG
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tbnMaKhachHang = new MetroFramework.Controls.MetroTextBox();
            this.tbnEmail = new MetroFramework.Controls.MetroTextBox();
            this.tbnSoDienThoai = new MetroFramework.Controls.MetroTextBox();
            this.tbnTenKhachHang = new MetroFramework.Controls.MetroTextBox();
            this.tbnDiaChi = new MetroFramework.Controls.MetroTextBox();
            this.tbnGhiChu = new MetroFramework.Controls.MetroTextBox();
            this.dtDanhSachKhachHang = new System.Windows.Forms.DataGridView();
            this.makhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new MetroFramework.Controls.MetroButton();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.btnCapNhat = new MetroFramework.Controls.MetroButton();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDanhSachKhachHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbnGhiChu);
            this.groupBox1.Controls.Add(this.tbnDiaChi);
            this.groupBox1.Controls.Add(this.tbnTenKhachHang);
            this.groupBox1.Controls.Add(this.tbnSoDienThoai);
            this.groupBox1.Controls.Add(this.tbnEmail);
            this.groupBox1.Controls.Add(this.tbnMaKhachHang);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Mã Khách Hàng";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Email";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 94);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Số điện thoại";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(288, 20);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(101, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Tên Khách Hàng";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(289, 60);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Địa chỉ";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(288, 98);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(52, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Ghi chú";
            // 
            // tbnMaKhachHang
            // 
            this.tbnMaKhachHang.Lines = new string[0];
            this.tbnMaKhachHang.Location = new System.Drawing.Point(120, 20);
            this.tbnMaKhachHang.MaxLength = 32767;
            this.tbnMaKhachHang.Name = "tbnMaKhachHang";
            this.tbnMaKhachHang.PasswordChar = '\0';
            this.tbnMaKhachHang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnMaKhachHang.SelectedText = "";
            this.tbnMaKhachHang.Size = new System.Drawing.Size(130, 23);
            this.tbnMaKhachHang.TabIndex = 6;
            this.tbnMaKhachHang.UseSelectable = true;
            // 
            // tbnEmail
            // 
            this.tbnEmail.Lines = new string[0];
            this.tbnEmail.Location = new System.Drawing.Point(120, 60);
            this.tbnEmail.MaxLength = 32767;
            this.tbnEmail.Name = "tbnEmail";
            this.tbnEmail.PasswordChar = '\0';
            this.tbnEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnEmail.SelectedText = "";
            this.tbnEmail.Size = new System.Drawing.Size(130, 23);
            this.tbnEmail.TabIndex = 7;
            this.tbnEmail.UseSelectable = true;
            // 
            // tbnSoDienThoai
            // 
            this.tbnSoDienThoai.Lines = new string[0];
            this.tbnSoDienThoai.Location = new System.Drawing.Point(120, 94);
            this.tbnSoDienThoai.MaxLength = 32767;
            this.tbnSoDienThoai.Name = "tbnSoDienThoai";
            this.tbnSoDienThoai.PasswordChar = '\0';
            this.tbnSoDienThoai.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnSoDienThoai.SelectedText = "";
            this.tbnSoDienThoai.Size = new System.Drawing.Size(130, 23);
            this.tbnSoDienThoai.TabIndex = 8;
            this.tbnSoDienThoai.UseSelectable = true;
            // 
            // tbnTenKhachHang
            // 
            this.tbnTenKhachHang.Lines = new string[0];
            this.tbnTenKhachHang.Location = new System.Drawing.Point(390, 20);
            this.tbnTenKhachHang.MaxLength = 32767;
            this.tbnTenKhachHang.Name = "tbnTenKhachHang";
            this.tbnTenKhachHang.PasswordChar = '\0';
            this.tbnTenKhachHang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnTenKhachHang.SelectedText = "";
            this.tbnTenKhachHang.Size = new System.Drawing.Size(130, 23);
            this.tbnTenKhachHang.TabIndex = 9;
            this.tbnTenKhachHang.UseSelectable = true;
            // 
            // tbnDiaChi
            // 
            this.tbnDiaChi.Lines = new string[0];
            this.tbnDiaChi.Location = new System.Drawing.Point(390, 56);
            this.tbnDiaChi.MaxLength = 32767;
            this.tbnDiaChi.Name = "tbnDiaChi";
            this.tbnDiaChi.PasswordChar = '\0';
            this.tbnDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnDiaChi.SelectedText = "";
            this.tbnDiaChi.Size = new System.Drawing.Size(249, 23);
            this.tbnDiaChi.TabIndex = 10;
            this.tbnDiaChi.UseSelectable = true;
            // 
            // tbnGhiChu
            // 
            this.tbnGhiChu.Lines = new string[0];
            this.tbnGhiChu.Location = new System.Drawing.Point(390, 98);
            this.tbnGhiChu.MaxLength = 32767;
            this.tbnGhiChu.Name = "tbnGhiChu";
            this.tbnGhiChu.PasswordChar = '\0';
            this.tbnGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnGhiChu.SelectedText = "";
            this.tbnGhiChu.Size = new System.Drawing.Size(249, 23);
            this.tbnGhiChu.TabIndex = 11;
            this.tbnGhiChu.UseSelectable = true;
            // 
            // dtDanhSachKhachHang
            // 
            this.dtDanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDanhSachKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhachhang,
            this.tenkhachhang,
            this.email,
            this.diachi,
            this.sodienthoai,
            this.ghichu});
            this.dtDanhSachKhachHang.Location = new System.Drawing.Point(44, 241);
            this.dtDanhSachKhachHang.Name = "dtDanhSachKhachHang";
            this.dtDanhSachKhachHang.Size = new System.Drawing.Size(638, 150);
            this.dtDanhSachKhachHang.TabIndex = 1;
            // 
            // makhachhang
            // 
            this.makhachhang.HeaderText = "Mã khách hàng";
            this.makhachhang.Name = "makhachhang";
            // 
            // tenkhachhang
            // 
            this.tenkhachhang.HeaderText = "Tên khách hàng";
            this.tenkhachhang.Name = "tenkhachhang";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            // 
            // sodienthoai
            // 
            this.sodienthoai.HeaderText = "Số điện thoại";
            this.sodienthoai.Name = "sodienthoai";
            // 
            // ghichu
            // 
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.Name = "ghichu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(46, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 77);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(47, 37);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseSelectable = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(201, 37);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseSelectable = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(354, 37);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseSelectable = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(523, 37);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseSelectable = true;
            // 
            // DS_KHACHHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtDanhSachKhachHang);
            this.Controls.Add(this.groupBox1);
            this.Name = "DS_KHACHHANG";
            this.Text = "DANH SÁCH KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.DS_KHACHHANG_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDanhSachKhachHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox tbnGhiChu;
        private MetroFramework.Controls.MetroTextBox tbnDiaChi;
        private MetroFramework.Controls.MetroTextBox tbnTenKhachHang;
        private MetroFramework.Controls.MetroTextBox tbnSoDienThoai;
        private MetroFramework.Controls.MetroTextBox tbnEmail;
        private MetroFramework.Controls.MetroTextBox tbnMaKhachHang;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dtDanhSachKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnXoa;
        private MetroFramework.Controls.MetroButton btnCapNhat;
        private MetroFramework.Controls.MetroButton btnThem;
        private MetroFramework.Controls.MetroButton btnTimKiem;
    }
}