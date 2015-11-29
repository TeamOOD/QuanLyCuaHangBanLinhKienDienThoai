namespace QuanLyCuaHangLinhKienDienThoai.GUI
{
    partial class TRACUUMATHANG
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbnTenSanPham = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cbbNhaSanXuat = new MetroFramework.Controls.MetroComboBox();
            this.cbbLoaiSanPham = new MetroFramework.Controls.MetroComboBox();
            this.dtTraCuuMatHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtTraCuuMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tên Sản Phẩm";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(385, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Nhà sản xuất";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(742, 75);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Loại sản phẩm";
            // 
            // tbnTenSanPham
            // 
            this.tbnTenSanPham.Lines = new string[0];
            this.tbnTenSanPham.Location = new System.Drawing.Point(120, 71);
            this.tbnTenSanPham.MaxLength = 32767;
            this.tbnTenSanPham.Name = "tbnTenSanPham";
            this.tbnTenSanPham.PasswordChar = '\0';
            this.tbnTenSanPham.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnTenSanPham.SelectedText = "";
            this.tbnTenSanPham.Size = new System.Drawing.Size(232, 23);
            this.tbnTenSanPham.TabIndex = 3;
            this.tbnTenSanPham.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1059, 71);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(85, 29);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Tìm kiếm";
            this.metroButton1.UseSelectable = true;
            // 
            // cbbNhaSanXuat
            // 
            this.cbbNhaSanXuat.FormattingEnabled = true;
            this.cbbNhaSanXuat.ItemHeight = 23;
            this.cbbNhaSanXuat.Location = new System.Drawing.Point(475, 71);
            this.cbbNhaSanXuat.Name = "cbbNhaSanXuat";
            this.cbbNhaSanXuat.Size = new System.Drawing.Size(234, 29);
            this.cbbNhaSanXuat.TabIndex = 7;
            this.cbbNhaSanXuat.UseSelectable = true;
            // 
            // cbbLoaiSanPham
            // 
            this.cbbLoaiSanPham.FormattingEnabled = true;
            this.cbbLoaiSanPham.ItemHeight = 23;
            this.cbbLoaiSanPham.Location = new System.Drawing.Point(853, 71);
            this.cbbLoaiSanPham.Name = "cbbLoaiSanPham";
            this.cbbLoaiSanPham.Size = new System.Drawing.Size(193, 29);
            this.cbbLoaiSanPham.TabIndex = 8;
            this.cbbLoaiSanPham.UseSelectable = true;
            // 
            // dtTraCuuMatHang
            // 
            this.dtTraCuuMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTraCuuMatHang.Location = new System.Drawing.Point(23, 120);
            this.dtTraCuuMatHang.Name = "dtTraCuuMatHang";
            this.dtTraCuuMatHang.Size = new System.Drawing.Size(1121, 258);
            this.dtTraCuuMatHang.TabIndex = 9;
            // 
            // TRACUUMATHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 426);
            this.Controls.Add(this.dtTraCuuMatHang);
            this.Controls.Add(this.cbbLoaiSanPham);
            this.Controls.Add(this.cbbNhaSanXuat);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.tbnTenSanPham);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "TRACUUMATHANG";
            this.Text = "TRA CỨU MẶT HÀNG";
            this.Load += new System.EventHandler(this.TRACUUMATHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTraCuuMatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbnTenSanPham;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox cbbNhaSanXuat;
        private MetroFramework.Controls.MetroComboBox cbbLoaiSanPham;
        private System.Windows.Forms.DataGridView dtTraCuuMatHang;
    }
}