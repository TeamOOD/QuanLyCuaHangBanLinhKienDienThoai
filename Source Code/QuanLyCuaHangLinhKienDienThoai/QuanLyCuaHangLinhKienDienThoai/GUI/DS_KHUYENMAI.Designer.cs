namespace QuanLyCuaHangLinhKienDienThoai.GUI
{
    partial class DS_KHUYENMAI
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
            this.dtNgayKetThucKM = new MetroFramework.Controls.MetroDateTime();
            this.dtNgayBatDauKM = new MetroFramework.Controls.MetroDateTime();
            this.tbnMaCTKM = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbbTenCTKM = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new MetroFramework.Controls.MetroButton();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.btnCapNhat = new MetroFramework.Controls.MetroButton();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.DtDanhSachKM = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtDanhSachKM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTenCTKM);
            this.groupBox1.Controls.Add(this.dtNgayKetThucKM);
            this.groupBox1.Controls.Add(this.dtNgayBatDauKM);
            this.groupBox1.Controls.Add(this.tbnMaCTKM);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm chương trình khuyến mãi";
            // 
            // dtNgayKetThucKM
            // 
            this.dtNgayKetThucKM.Location = new System.Drawing.Point(235, 151);
            this.dtNgayKetThucKM.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtNgayKetThucKM.Name = "dtNgayKetThucKM";
            this.dtNgayKetThucKM.Size = new System.Drawing.Size(200, 29);
            this.dtNgayKetThucKM.TabIndex = 7;
            // 
            // dtNgayBatDauKM
            // 
            this.dtNgayBatDauKM.Location = new System.Drawing.Point(235, 110);
            this.dtNgayBatDauKM.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtNgayBatDauKM.Name = "dtNgayBatDauKM";
            this.dtNgayBatDauKM.Size = new System.Drawing.Size(200, 29);
            this.dtNgayBatDauKM.TabIndex = 6;
            // 
            // tbnMaCTKM
            // 
            this.tbnMaCTKM.Lines = new string[0];
            this.tbnMaCTKM.Location = new System.Drawing.Point(235, 37);
            this.tbnMaCTKM.MaxLength = 32767;
            this.tbnMaCTKM.Name = "tbnMaCTKM";
            this.tbnMaCTKM.PasswordChar = '\0';
            this.tbnMaCTKM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnMaCTKM.SelectedText = "";
            this.tbnMaCTKM.Size = new System.Drawing.Size(200, 23);
            this.tbnMaCTKM.TabIndex = 4;
            this.tbnMaCTKM.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(37, 152);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(159, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Ngày kết thúc khuyến mãi";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(37, 117);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(159, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Ngày bắt đầu khuyến mãi";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(37, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(176, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Tên chương trình khuyến mãi";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 42);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(176, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Mã chương trình khuyến mãi";
            // 
            // cbbTenCTKM
            // 
            this.cbbTenCTKM.FormattingEnabled = true;
            this.cbbTenCTKM.Location = new System.Drawing.Point(235, 76);
            this.cbbTenCTKM.Name = "cbbTenCTKM";
            this.cbbTenCTKM.Size = new System.Drawing.Size(200, 21);
            this.cbbTenCTKM.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(514, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(26, 37);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(109, 58);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseSelectable = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(188, 37);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 58);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseSelectable = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(26, 117);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(109, 63);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseSelectable = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(188, 117);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 63);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseSelectable = true;
            // 
            // DtDanhSachKM
            // 
            this.DtDanhSachKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtDanhSachKM.Location = new System.Drawing.Point(23, 313);
            this.DtDanhSachKM.Name = "DtDanhSachKM";
            this.DtDanhSachKM.Size = new System.Drawing.Size(804, 150);
            this.DtDanhSachKM.TabIndex = 2;
            // 
            // DS_KHUYENMAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 477);
            this.Controls.Add(this.DtDanhSachKM);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DS_KHUYENMAI";
            this.Text = "DANH SÁCH KHUYẾN MÃI";
            this.Load += new System.EventHandler(this.DS_KHUYENMAI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtDanhSachKM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroDateTime dtNgayKetThucKM;
        private MetroFramework.Controls.MetroDateTime dtNgayBatDauKM;
        private MetroFramework.Controls.MetroTextBox tbnMaCTKM;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox cbbTenCTKM;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnXoa;
        private MetroFramework.Controls.MetroButton btnCapNhat;
        private MetroFramework.Controls.MetroButton btnThem;
        private MetroFramework.Controls.MetroButton btnTimKiem;
        private System.Windows.Forms.DataGridView DtDanhSachKM;
    }
}