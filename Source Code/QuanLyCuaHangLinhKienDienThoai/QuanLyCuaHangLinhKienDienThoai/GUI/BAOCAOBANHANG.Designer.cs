namespace QuanLyCuaHangLinhKienDienThoai.GUI
{
    partial class BAOCAOBANHANG
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
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbnTenNhanVien = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbnMaNhanVien = new MetroFramework.Controls.MetroTextBox();
            this.dtBaoCaoBanHang = new System.Windows.Forms.DataGridView();
            this.cbbDenNgay = new MetroFramework.Controls.MetroComboBox();
            this.cbbTuNgay = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLap = new MetroFramework.Controls.MetroButton();
            this.btnIn = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaoCaoBanHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTuNgay);
            this.groupBox1.Controls.Add(this.cbbDenNgay);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.tbnTenNhanVien);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.tbnMaNhanVien);
            this.groupBox1.Location = new System.Drawing.Point(10, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 135);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm nhân viên";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(404, 77);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Đến ngày";
            // 
            // tbnTenNhanVien
            // 
            this.tbnTenNhanVien.Lines = new string[0];
            this.tbnTenNhanVien.Location = new System.Drawing.Point(482, 28);
            this.tbnTenNhanVien.MaxLength = 32767;
            this.tbnTenNhanVien.Name = "tbnTenNhanVien";
            this.tbnTenNhanVien.PasswordChar = '\0';
            this.tbnTenNhanVien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnTenNhanVien.SelectedText = "";
            this.tbnTenNhanVien.Size = new System.Drawing.Size(225, 23);
            this.tbnTenNhanVien.TabIndex = 10;
            this.tbnTenNhanVien.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(15, 81);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Từ ngày";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(389, 28);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Tên nhân viên";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Mã nhân viên";
            // 
            // tbnMaNhanVien
            // 
            this.tbnMaNhanVien.Lines = new string[0];
            this.tbnMaNhanVien.Location = new System.Drawing.Point(108, 28);
            this.tbnMaNhanVien.MaxLength = 32767;
            this.tbnMaNhanVien.Name = "tbnMaNhanVien";
            this.tbnMaNhanVien.PasswordChar = '\0';
            this.tbnMaNhanVien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnMaNhanVien.SelectedText = "";
            this.tbnMaNhanVien.Size = new System.Drawing.Size(232, 23);
            this.tbnMaNhanVien.TabIndex = 0;
            this.tbnMaNhanVien.UseSelectable = true;
            // 
            // dtBaoCaoBanHang
            // 
            this.dtBaoCaoBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBaoCaoBanHang.Location = new System.Drawing.Point(10, 228);
            this.dtBaoCaoBanHang.Name = "dtBaoCaoBanHang";
            this.dtBaoCaoBanHang.Size = new System.Drawing.Size(915, 202);
            this.dtBaoCaoBanHang.TabIndex = 5;
            // 
            // cbbDenNgay
            // 
            this.cbbDenNgay.FormattingEnabled = true;
            this.cbbDenNgay.ItemHeight = 23;
            this.cbbDenNgay.Location = new System.Drawing.Point(482, 77);
            this.cbbDenNgay.Name = "cbbDenNgay";
            this.cbbDenNgay.Size = new System.Drawing.Size(225, 29);
            this.cbbDenNgay.TabIndex = 12;
            this.cbbDenNgay.UseSelectable = true;
            // 
            // cbbTuNgay
            // 
            this.cbbTuNgay.FormattingEnabled = true;
            this.cbbTuNgay.ItemHeight = 23;
            this.cbbTuNgay.Location = new System.Drawing.Point(108, 81);
            this.cbbTuNgay.Name = "cbbTuNgay";
            this.cbbTuNgay.Size = new System.Drawing.Size(232, 29);
            this.cbbTuNgay.TabIndex = 13;
            this.cbbTuNgay.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIn);
            this.groupBox2.Controls.Add(this.btnLap);
            this.groupBox2.Location = new System.Drawing.Point(753, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 135);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnLap
            // 
            this.btnLap.Location = new System.Drawing.Point(25, 28);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(104, 33);
            this.btnLap.TabIndex = 0;
            this.btnLap.Text = "Lập";
            this.btnLap.UseSelectable = true;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(25, 83);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(104, 33);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "In";
            this.btnIn.UseSelectable = true;
            // 
            // BAOCAOBANHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtBaoCaoBanHang);
            this.Name = "BAOCAOBANHANG";
            this.Text = "BAOCAOBANHANG";
            this.Load += new System.EventHandler(this.BAOCAOBANHANG_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaoCaoBanHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox cbbTuNgay;
        private MetroFramework.Controls.MetroComboBox cbbDenNgay;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbnTenNhanVien;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbnMaNhanVien;
        private System.Windows.Forms.DataGridView dtBaoCaoBanHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnIn;
        private MetroFramework.Controls.MetroButton btnLap;
    }
}