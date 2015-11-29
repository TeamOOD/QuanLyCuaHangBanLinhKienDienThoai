namespace QuanLyCuaHangLinhKienDienThoai.GUI
{
    partial class PHIEUBANHANG
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.btnCapnhat = new MetroFramework.Controls.MetroButton();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.btnTimKiem = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbnTenNhanVien = new MetroFramework.Controls.MetroTextBox();
            this.tbnMaKhachHang = new MetroFramework.Controls.MetroTextBox();
            this.tbnTenKhachHang = new MetroFramework.Controls.MetroTextBox();
            this.tbnMaNhanVien = new MetroFramework.Controls.MetroTextBox();
            this.tbnMaHoaDon = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtPhieuBanHang = new System.Windows.Forms.DataGridView();
            this.cbbThoiGianLap = new MetroFramework.Controls.MetroComboBox();
            this.cbbLoaiHoaDon = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPhieuBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnCapnhat);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(539, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 181);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(160, 118);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 40);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseSelectable = true;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(25, 118);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(75, 40);
            this.btnCapnhat.TabIndex = 2;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseSelectable = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(160, 46);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 40);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseSelectable = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(25, 45);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 40);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbLoaiHoaDon);
            this.groupBox1.Controls.Add(this.cbbThoiGianLap);
            this.groupBox1.Controls.Add(this.tbnTenNhanVien);
            this.groupBox1.Controls.Add(this.tbnMaKhachHang);
            this.groupBox1.Controls.Add(this.tbnTenKhachHang);
            this.groupBox1.Controls.Add(this.tbnMaNhanVien);
            this.groupBox1.Controls.Add(this.tbnMaHoaDon);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 181);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu bán hàng";
            // 
            // tbnTenNhanVien
            // 
            this.tbnTenNhanVien.Lines = new string[0];
            this.tbnTenNhanVien.Location = new System.Drawing.Point(353, 99);
            this.tbnTenNhanVien.MaxLength = 32767;
            this.tbnTenNhanVien.Name = "tbnTenNhanVien";
            this.tbnTenNhanVien.PasswordChar = '\0';
            this.tbnTenNhanVien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnTenNhanVien.SelectedText = "";
            this.tbnTenNhanVien.Size = new System.Drawing.Size(128, 23);
            this.tbnTenNhanVien.TabIndex = 12;
            this.tbnTenNhanVien.UseSelectable = true;
            // 
            // tbnMaKhachHang
            // 
            this.tbnMaKhachHang.Lines = new string[0];
            this.tbnMaKhachHang.Location = new System.Drawing.Point(117, 104);
            this.tbnMaKhachHang.MaxLength = 32767;
            this.tbnMaKhachHang.Name = "tbnMaKhachHang";
            this.tbnMaKhachHang.PasswordChar = '\0';
            this.tbnMaKhachHang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnMaKhachHang.SelectedText = "";
            this.tbnMaKhachHang.Size = new System.Drawing.Size(119, 23);
            this.tbnMaKhachHang.TabIndex = 11;
            this.tbnMaKhachHang.UseSelectable = true;
            // 
            // tbnTenKhachHang
            // 
            this.tbnTenKhachHang.Lines = new string[0];
            this.tbnTenKhachHang.Location = new System.Drawing.Point(353, 62);
            this.tbnTenKhachHang.MaxLength = 32767;
            this.tbnTenKhachHang.Name = "tbnTenKhachHang";
            this.tbnTenKhachHang.PasswordChar = '\0';
            this.tbnTenKhachHang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnTenKhachHang.SelectedText = "";
            this.tbnTenKhachHang.Size = new System.Drawing.Size(128, 23);
            this.tbnTenKhachHang.TabIndex = 10;
            this.tbnTenKhachHang.UseSelectable = true;
            // 
            // tbnMaNhanVien
            // 
            this.tbnMaNhanVien.Lines = new string[0];
            this.tbnMaNhanVien.Location = new System.Drawing.Point(117, 67);
            this.tbnMaNhanVien.MaxLength = 32767;
            this.tbnMaNhanVien.Name = "tbnMaNhanVien";
            this.tbnMaNhanVien.PasswordChar = '\0';
            this.tbnMaNhanVien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnMaNhanVien.SelectedText = "";
            this.tbnMaNhanVien.Size = new System.Drawing.Size(119, 23);
            this.tbnMaNhanVien.TabIndex = 9;
            this.tbnMaNhanVien.UseSelectable = true;
            // 
            // tbnMaHoaDon
            // 
            this.tbnMaHoaDon.Lines = new string[0];
            this.tbnMaHoaDon.Location = new System.Drawing.Point(115, 30);
            this.tbnMaHoaDon.MaxLength = 32767;
            this.tbnMaHoaDon.Name = "tbnMaHoaDon";
            this.tbnMaHoaDon.PasswordChar = '\0';
            this.tbnMaHoaDon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnMaHoaDon.SelectedText = "";
            this.tbnMaHoaDon.Size = new System.Drawing.Size(119, 23);
            this.tbnMaHoaDon.TabIndex = 7;
            this.tbnMaHoaDon.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(19, 139);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(86, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Loại hóa đơn";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(250, 96);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(87, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Tên nhân viên";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(19, 101);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(98, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Mã khách hàng";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(250, 62);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(98, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Tên khách hàng";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 67);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(87, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Mã nhân viên";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(250, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "thời gian lập";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Mã hóa đơn";
            // 
            // dtPhieuBanHang
            // 
            this.dtPhieuBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPhieuBanHang.Location = new System.Drawing.Point(23, 275);
            this.dtPhieuBanHang.Name = "dtPhieuBanHang";
            this.dtPhieuBanHang.Size = new System.Drawing.Size(778, 150);
            this.dtPhieuBanHang.TabIndex = 4;
            // 
            // cbbThoiGianLap
            // 
            this.cbbThoiGianLap.FormattingEnabled = true;
            this.cbbThoiGianLap.ItemHeight = 23;
            this.cbbThoiGianLap.Location = new System.Drawing.Point(353, 24);
            this.cbbThoiGianLap.Name = "cbbThoiGianLap";
            this.cbbThoiGianLap.Size = new System.Drawing.Size(128, 29);
            this.cbbThoiGianLap.TabIndex = 13;
            this.cbbThoiGianLap.UseSelectable = true;
            // 
            // cbbLoaiHoaDon
            // 
            this.cbbLoaiHoaDon.FormattingEnabled = true;
            this.cbbLoaiHoaDon.ItemHeight = 23;
            this.cbbLoaiHoaDon.Location = new System.Drawing.Point(115, 139);
            this.cbbLoaiHoaDon.Name = "cbbLoaiHoaDon";
            this.cbbLoaiHoaDon.Size = new System.Drawing.Size(121, 29);
            this.cbbLoaiHoaDon.TabIndex = 14;
            this.cbbLoaiHoaDon.UseSelectable = true;
            // 
            // PHIEUBANHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 464);
            this.Controls.Add(this.dtPhieuBanHang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PHIEUBANHANG";
            this.Text = "PHIEUBANHANG";
            this.Load += new System.EventHandler(this.PHIEUBANHANG_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPhieuBanHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnXoa;
        private MetroFramework.Controls.MetroButton btnCapnhat;
        private MetroFramework.Controls.MetroButton btnThem;
        private MetroFramework.Controls.MetroButton btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox tbnTenNhanVien;
        private MetroFramework.Controls.MetroTextBox tbnMaKhachHang;
        private MetroFramework.Controls.MetroTextBox tbnTenKhachHang;
        private MetroFramework.Controls.MetroTextBox tbnMaNhanVien;
        private MetroFramework.Controls.MetroTextBox tbnMaHoaDon;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dtPhieuBanHang;
        private MetroFramework.Controls.MetroComboBox cbbLoaiHoaDon;
        private MetroFramework.Controls.MetroComboBox cbbThoiGianLap;
    }
}