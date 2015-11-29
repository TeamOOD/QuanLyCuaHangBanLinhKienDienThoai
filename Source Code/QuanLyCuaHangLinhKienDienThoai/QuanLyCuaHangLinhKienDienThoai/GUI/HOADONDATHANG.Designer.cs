namespace QuanLyCuaHangLinhKienDienThoai.GUI
{
    partial class HOADONDATHANG
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new MetroFramework.Controls.MetroButton();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtDanhSachMatHangTrongHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtDanhSachMatHang = new System.Windows.Forms.DataGridView();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbbNgayDatHang = new MetroFramework.Controls.MetroComboBox();
            this.cbbNgayGiaoHang = new MetroFramework.Controls.MetroComboBox();
            this.cbbNhaCungCap = new MetroFramework.Controls.MetroComboBox();
            this.btnThemHoaDon = new MetroFramework.Controls.MetroButton();
            this.btnCapNhatHoaDon = new MetroFramework.Controls.MetroButton();
            this.btnInHoaDon = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbnSoLuong = new MetroFramework.Controls.MetroTextBox();
            this.btnSum = new MetroFramework.Controls.MetroButton();
            this.btnsub = new MetroFramework.Controls.MetroButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cbbNCC1 = new MetroFramework.Controls.MetroComboBox();
            this.cbbNgayDatHangFrom = new MetroFramework.Controls.MetroComboBox();
            this.cbbNgayDatHangTo = new MetroFramework.Controls.MetroComboBox();
            this.dtDSPhieuDathang = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDanhSachMatHangTrongHoaDon)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDanhSachMatHang)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSPhieuDathang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemHoaDon);
            this.groupBox1.Controls.Add(this.btnCapNhatHoaDon);
            this.groupBox1.Controls.Add(this.btnInHoaDon);
            this.groupBox1.Controls.Add(this.cbbNhaCungCap);
            this.groupBox1.Controls.Add(this.cbbNgayGiaoHang);
            this.groupBox1.Controls.Add(this.cbbNgayDatHang);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(16, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 581);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn mặt hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsub);
            this.groupBox2.Controls.Add(this.btnSum);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.tbnSoLuong);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(7, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(719, 440);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(306, 294);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(114, 23);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseSelectable = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(306, 228);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa >>";
            this.btnXoa.UseSelectable = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(306, 199);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm >>";
            this.btnThem.UseSelectable = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtDanhSachMatHangTrongHoaDon);
            this.groupBox4.Location = new System.Drawing.Point(460, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 383);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách mặt hàng trong hóa đơn";
            // 
            // dtDanhSachMatHangTrongHoaDon
            // 
            this.dtDanhSachMatHangTrongHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDanhSachMatHangTrongHoaDon.Location = new System.Drawing.Point(5, 34);
            this.dtDanhSachMatHangTrongHoaDon.Name = "dtDanhSachMatHangTrongHoaDon";
            this.dtDanhSachMatHangTrongHoaDon.Size = new System.Drawing.Size(240, 347);
            this.dtDanhSachMatHangTrongHoaDon.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtDanhSachMatHang);
            this.groupBox3.Location = new System.Drawing.Point(7, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 383);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách mặt hàng";
            // 
            // dtDanhSachMatHang
            // 
            this.dtDanhSachMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDanhSachMatHang.Location = new System.Drawing.Point(5, 34);
            this.dtDanhSachMatHang.Name = "dtDanhSachMatHang";
            this.dtDanhSachMatHang.Size = new System.Drawing.Size(240, 347);
            this.dtDanhSachMatHang.TabIndex = 9;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 27);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Ngày đặt hàng";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(19, 60);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(103, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Ngày giao hàng";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(19, 92);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(90, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Nhà cung cấp";
            // 
            // cbbNgayDatHang
            // 
            this.cbbNgayDatHang.FormattingEnabled = true;
            this.cbbNgayDatHang.ItemHeight = 23;
            this.cbbNgayDatHang.Location = new System.Drawing.Point(141, 24);
            this.cbbNgayDatHang.Name = "cbbNgayDatHang";
            this.cbbNgayDatHang.Size = new System.Drawing.Size(187, 29);
            this.cbbNgayDatHang.TabIndex = 10;
            this.cbbNgayDatHang.UseSelectable = true;
            // 
            // cbbNgayGiaoHang
            // 
            this.cbbNgayGiaoHang.FormattingEnabled = true;
            this.cbbNgayGiaoHang.ItemHeight = 23;
            this.cbbNgayGiaoHang.Location = new System.Drawing.Point(141, 57);
            this.cbbNgayGiaoHang.Name = "cbbNgayGiaoHang";
            this.cbbNgayGiaoHang.Size = new System.Drawing.Size(187, 29);
            this.cbbNgayGiaoHang.TabIndex = 11;
            this.cbbNgayGiaoHang.UseSelectable = true;
            // 
            // cbbNhaCungCap
            // 
            this.cbbNhaCungCap.FormattingEnabled = true;
            this.cbbNhaCungCap.ItemHeight = 23;
            this.cbbNhaCungCap.Location = new System.Drawing.Point(141, 92);
            this.cbbNhaCungCap.Name = "cbbNhaCungCap";
            this.cbbNhaCungCap.Size = new System.Drawing.Size(187, 29);
            this.cbbNhaCungCap.TabIndex = 12;
            this.cbbNhaCungCap.UseSelectable = true;
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.Location = new System.Drawing.Point(598, 19);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(114, 34);
            this.btnThemHoaDon.TabIndex = 14;
            this.btnThemHoaDon.Text = "Thêm hóa đơn";
            this.btnThemHoaDon.UseSelectable = true;
            // 
            // btnCapNhatHoaDon
            // 
            this.btnCapNhatHoaDon.Location = new System.Drawing.Point(598, 60);
            this.btnCapNhatHoaDon.Name = "btnCapNhatHoaDon";
            this.btnCapNhatHoaDon.Size = new System.Drawing.Size(114, 32);
            this.btnCapNhatHoaDon.TabIndex = 15;
            this.btnCapNhatHoaDon.Text = "Cập nhật hóa đơn";
            this.btnCapNhatHoaDon.UseSelectable = true;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(598, 98);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(114, 29);
            this.btnInHoaDon.TabIndex = 16;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(267, 148);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Số lượng";
            // 
            // tbnSoLuong
            // 
            this.tbnSoLuong.Lines = new string[0];
            this.tbnSoLuong.Location = new System.Drawing.Point(335, 148);
            this.tbnSoLuong.MaxLength = 32767;
            this.tbnSoLuong.Name = "tbnSoLuong";
            this.tbnSoLuong.PasswordChar = '\0';
            this.tbnSoLuong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnSoLuong.SelectedText = "";
            this.tbnSoLuong.Size = new System.Drawing.Size(75, 23);
            this.tbnSoLuong.TabIndex = 14;
            this.tbnSoLuong.UseSelectable = true;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(416, 135);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(23, 20);
            this.btnSum.TabIndex = 17;
            this.btnSum.Text = "+";
            this.btnSum.UseSelectable = true;
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(416, 161);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(23, 20);
            this.btnsub.TabIndex = 18;
            this.btnsub.Text = "-";
            this.btnsub.UseSelectable = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtDSPhieuDathang);
            this.groupBox5.Controls.Add(this.cbbNgayDatHangTo);
            this.groupBox5.Controls.Add(this.cbbNgayDatHangFrom);
            this.groupBox5.Controls.Add(this.cbbNCC1);
            this.groupBox5.Controls.Add(this.metroLabel2);
            this.groupBox5.Controls.Add(this.metroLabel6);
            this.groupBox5.Controls.Add(this.metroLabel7);
            this.groupBox5.Location = new System.Drawing.Point(754, 63);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(564, 581);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách phiếu đặt hàng";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 34);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 19);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "Nhà cung cấp";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(218, 34);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(96, 19);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "Ngày đặt hàng";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(378, 61);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(31, 19);
            this.metroLabel7.TabIndex = 21;
            this.metroLabel7.Text = "đến";
            // 
            // cbbNCC1
            // 
            this.cbbNCC1.FormattingEnabled = true;
            this.cbbNCC1.ItemHeight = 23;
            this.cbbNCC1.Location = new System.Drawing.Point(6, 56);
            this.cbbNCC1.Name = "cbbNCC1";
            this.cbbNCC1.Size = new System.Drawing.Size(187, 29);
            this.cbbNCC1.TabIndex = 17;
            this.cbbNCC1.UseSelectable = true;
            // 
            // cbbNgayDatHangFrom
            // 
            this.cbbNgayDatHangFrom.FormattingEnabled = true;
            this.cbbNgayDatHangFrom.ItemHeight = 23;
            this.cbbNgayDatHangFrom.Location = new System.Drawing.Point(218, 57);
            this.cbbNgayDatHangFrom.Name = "cbbNgayDatHangFrom";
            this.cbbNgayDatHangFrom.Size = new System.Drawing.Size(154, 29);
            this.cbbNgayDatHangFrom.TabIndex = 22;
            this.cbbNgayDatHangFrom.UseSelectable = true;
            // 
            // cbbNgayDatHangTo
            // 
            this.cbbNgayDatHangTo.FormattingEnabled = true;
            this.cbbNgayDatHangTo.ItemHeight = 23;
            this.cbbNgayDatHangTo.Location = new System.Drawing.Point(415, 56);
            this.cbbNgayDatHangTo.Name = "cbbNgayDatHangTo";
            this.cbbNgayDatHangTo.Size = new System.Drawing.Size(143, 29);
            this.cbbNgayDatHangTo.TabIndex = 23;
            this.cbbNgayDatHangTo.UseSelectable = true;
            // 
            // dtDSPhieuDathang
            // 
            this.dtDSPhieuDathang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDSPhieuDathang.Location = new System.Drawing.Point(6, 98);
            this.dtDSPhieuDathang.Name = "dtDSPhieuDathang";
            this.dtDSPhieuDathang.Size = new System.Drawing.Size(552, 444);
            this.dtDSPhieuDathang.TabIndex = 24;
            // 
            // HOADONDATHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 656);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "HOADONDATHANG";
            this.Text = "LẬP HÓA ĐƠN ĐẶT HÀNG";
            this.Load += new System.EventHandler(this.HOADONDATHANG_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDanhSachMatHangTrongHoaDon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDanhSachMatHang)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSPhieuDathang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnLamMoi;
        private MetroFramework.Controls.MetroButton btnXoa;
        private MetroFramework.Controls.MetroButton btnThem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtDanhSachMatHangTrongHoaDon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtDanhSachMatHang;
        private MetroFramework.Controls.MetroButton btnThemHoaDon;
        private MetroFramework.Controls.MetroButton btnCapNhatHoaDon;
        private MetroFramework.Controls.MetroButton btnInHoaDon;
        private MetroFramework.Controls.MetroComboBox cbbNhaCungCap;
        private MetroFramework.Controls.MetroComboBox cbbNgayGiaoHang;
        private MetroFramework.Controls.MetroComboBox cbbNgayDatHang;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnsub;
        private MetroFramework.Controls.MetroButton btnSum;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbnSoLuong;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtDSPhieuDathang;
        private MetroFramework.Controls.MetroComboBox cbbNgayDatHangTo;
        private MetroFramework.Controls.MetroComboBox cbbNgayDatHangFrom;
        private MetroFramework.Controls.MetroComboBox cbbNCC1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}