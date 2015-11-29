namespace QuanLyCuaHangLinhKienDienThoai.GUI
{
    partial class MAUSAC
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
            this.dtMauSac = new System.Windows.Forms.DataGridView();
            this.tbnTenMau = new MetroFramework.Controls.MetroTextBox();
            this.tbnMaMau = new MetroFramework.Controls.MetroTextBox();
            this.btnCapnhat = new MetroFramework.Controls.MetroButton();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.btnTimKiem = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtMauSac)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtMauSac
            // 
            this.dtMauSac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMauSac.Location = new System.Drawing.Point(64, 211);
            this.dtMauSac.Name = "dtMauSac";
            this.dtMauSac.Size = new System.Drawing.Size(778, 169);
            this.dtMauSac.TabIndex = 10;
            // 
            // tbnTenMau
            // 
            this.tbnTenMau.Lines = new string[0];
            this.tbnTenMau.Location = new System.Drawing.Point(121, 85);
            this.tbnTenMau.MaxLength = 32767;
            this.tbnTenMau.Name = "tbnTenMau";
            this.tbnTenMau.PasswordChar = '\0';
            this.tbnTenMau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnTenMau.SelectedText = "";
            this.tbnTenMau.Size = new System.Drawing.Size(288, 23);
            this.tbnTenMau.TabIndex = 9;
            this.tbnTenMau.UseSelectable = true;
            // 
            // tbnMaMau
            // 
            this.tbnMaMau.Lines = new string[0];
            this.tbnMaMau.Location = new System.Drawing.Point(119, 48);
            this.tbnMaMau.MaxLength = 32767;
            this.tbnMaMau.Name = "tbnMaMau";
            this.tbnMaMau.PasswordChar = '\0';
            this.tbnMaMau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnMaMau.SelectedText = "";
            this.tbnMaMau.Size = new System.Drawing.Size(288, 23);
            this.tbnMaMau.TabIndex = 7;
            this.tbnMaMau.UseSelectable = true;
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
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Tên màu";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 48);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Mã màu";
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
            this.groupBox2.Location = new System.Drawing.Point(580, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 152);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbnTenMau);
            this.groupBox1.Controls.Add(this.tbnMaMau);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(64, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 152);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin màu mặt hàng";
            // 
            // MAUSAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 421);
            this.Controls.Add(this.dtMauSac);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MAUSAC";
            this.Text = "MAUSAC";
            this.Load += new System.EventHandler(this.MAUSAC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtMauSac)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtMauSac;
        private MetroFramework.Controls.MetroTextBox tbnTenMau;
        private MetroFramework.Controls.MetroTextBox tbnMaMau;
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