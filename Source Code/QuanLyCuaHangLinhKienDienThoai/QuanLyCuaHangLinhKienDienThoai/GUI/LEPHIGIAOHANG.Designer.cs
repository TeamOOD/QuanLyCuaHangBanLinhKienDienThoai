namespace QuanLyCuaHangLinhKienDienThoai.GUI
{
    partial class LEPHIGIAOHANG
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
            this.dtLePhiGiaoHang = new System.Windows.Forms.DataGridView();
            this.tbnDonGia = new MetroFramework.Controls.MetroTextBox();
            this.tbnTenKhuVuc = new MetroFramework.Controls.MetroTextBox();
            this.btnCapnhat = new MetroFramework.Controls.MetroButton();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.btnTimKiem = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtLePhiGiaoHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtLePhiGiaoHang
            // 
            this.dtLePhiGiaoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLePhiGiaoHang.Location = new System.Drawing.Point(23, 245);
            this.dtLePhiGiaoHang.Name = "dtLePhiGiaoHang";
            this.dtLePhiGiaoHang.Size = new System.Drawing.Size(778, 169);
            this.dtLePhiGiaoHang.TabIndex = 7;
            // 
            // tbnDonGia
            // 
            this.tbnDonGia.Lines = new string[0];
            this.tbnDonGia.Location = new System.Drawing.Point(121, 85);
            this.tbnDonGia.MaxLength = 32767;
            this.tbnDonGia.Name = "tbnDonGia";
            this.tbnDonGia.PasswordChar = '\0';
            this.tbnDonGia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnDonGia.SelectedText = "";
            this.tbnDonGia.Size = new System.Drawing.Size(288, 23);
            this.tbnDonGia.TabIndex = 9;
            this.tbnDonGia.UseSelectable = true;
            // 
            // tbnTenKhuVuc
            // 
            this.tbnTenKhuVuc.Lines = new string[0];
            this.tbnTenKhuVuc.Location = new System.Drawing.Point(119, 48);
            this.tbnTenKhuVuc.MaxLength = 32767;
            this.tbnTenKhuVuc.Name = "tbnTenKhuVuc";
            this.tbnTenKhuVuc.PasswordChar = '\0';
            this.tbnTenKhuVuc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnTenKhuVuc.SelectedText = "";
            this.tbnTenKhuVuc.Size = new System.Drawing.Size(288, 23);
            this.tbnTenKhuVuc.TabIndex = 7;
            this.tbnTenKhuVuc.UseSelectable = true;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(28, 88);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(75, 40);
            this.btnCapnhat.TabIndex = 2;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseSelectable = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(159, 31);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 40);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseSelectable = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(24, 30);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 40);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 85);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Đơn giá";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 48);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tên khu vực";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(163, 88);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 40);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnCapnhat);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(539, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 152);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbnDonGia);
            this.groupBox1.Controls.Add(this.tbnTenKhuVuc);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 152);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lệ phí";
            // 
            // LEPHIGIAOHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 439);
            this.Controls.Add(this.dtLePhiGiaoHang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LEPHIGIAOHANG";
            this.Text = "LỆ PHÍ GIAO HÀNG";
            this.Load += new System.EventHandler(this.LEPHIGIAOHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtLePhiGiaoHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtLePhiGiaoHang;
        private MetroFramework.Controls.MetroTextBox tbnDonGia;
        private MetroFramework.Controls.MetroTextBox tbnTenKhuVuc;
        private MetroFramework.Controls.MetroButton btnCapnhat;
        private MetroFramework.Controls.MetroButton btnThem;
        private MetroFramework.Controls.MetroButton btnTimKiem;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}