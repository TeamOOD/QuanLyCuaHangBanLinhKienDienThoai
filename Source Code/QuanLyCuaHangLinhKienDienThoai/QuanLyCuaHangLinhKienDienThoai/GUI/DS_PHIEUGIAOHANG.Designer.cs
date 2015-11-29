namespace QuanLyCuaHangLinhKienDienThoai.GUI
{
    partial class DS_PHIEUGIAOHANG
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
            this.tbnTimKiem = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnTimKiem = new MetroFramework.Controls.MetroButton();
            this.cbbTheo = new MetroFramework.Controls.MetroComboBox();
            this.dtPhieuGiaoHang = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPhieuGiaoHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTheo);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.tbnTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(35, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm phiếu giao hàng";
            // 
            // tbnTimKiem
            // 
            this.tbnTimKiem.Lines = new string[0];
            this.tbnTimKiem.Location = new System.Drawing.Point(94, 32);
            this.tbnTimKiem.MaxLength = 32767;
            this.tbnTimKiem.Name = "tbnTimKiem";
            this.tbnTimKiem.PasswordChar = '\0';
            this.tbnTimKiem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnTimKiem.SelectedText = "";
            this.tbnTimKiem.Size = new System.Drawing.Size(319, 23);
            this.tbnTimKiem.TabIndex = 0;
            this.tbnTimKiem.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Tìm kiếm";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(470, 36);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Theo";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(787, 32);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(99, 29);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseSelectable = true;
            // 
            // cbbTheo
            // 
            this.cbbTheo.FormattingEnabled = true;
            this.cbbTheo.ItemHeight = 23;
            this.cbbTheo.Location = new System.Drawing.Point(531, 32);
            this.cbbTheo.Name = "cbbTheo";
            this.cbbTheo.Size = new System.Drawing.Size(220, 29);
            this.cbbTheo.TabIndex = 5;
            this.cbbTheo.UseSelectable = true;
            // 
            // dtPhieuGiaoHang
            // 
            this.dtPhieuGiaoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPhieuGiaoHang.Location = new System.Drawing.Point(35, 215);
            this.dtPhieuGiaoHang.Name = "dtPhieuGiaoHang";
            this.dtPhieuGiaoHang.Size = new System.Drawing.Size(915, 150);
            this.dtPhieuGiaoHang.TabIndex = 1;
            // 
            // DS_PHIEUGIAOHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 401);
            this.Controls.Add(this.dtPhieuGiaoHang);
            this.Controls.Add(this.groupBox1);
            this.Name = "DS_PHIEUGIAOHANG";
            this.Text = "DANH SÁCH PHIẾU GIAO HÀNG";
            this.Load += new System.EventHandler(this.DS_PHIEUGIAOHANG_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPhieuGiaoHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox cbbTheo;
        private MetroFramework.Controls.MetroButton btnTimKiem;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbnTimKiem;
        private System.Windows.Forms.DataGridView dtPhieuGiaoHang;
    }
}