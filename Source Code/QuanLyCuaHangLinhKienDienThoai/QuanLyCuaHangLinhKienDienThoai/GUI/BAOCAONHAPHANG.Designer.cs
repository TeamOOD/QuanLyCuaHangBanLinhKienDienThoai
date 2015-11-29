namespace QuanLyCuaHangLinhKienDienThoai.GUI
{
    partial class BAOCAONHAPHANG
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
            this.dtBaoCaoNhapHang = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIn = new MetroFramework.Controls.MetroButton();
            this.cbbDenNgay = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaoCaoNhapHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbDenNgay);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 81);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết Báo Cáo nhập hàng";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Thời gian";
            // 
            // dtBaoCaoNhapHang
            // 
            this.dtBaoCaoNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBaoCaoNhapHang.Location = new System.Drawing.Point(23, 162);
            this.dtBaoCaoNhapHang.Name = "dtBaoCaoNhapHang";
            this.dtBaoCaoNhapHang.Size = new System.Drawing.Size(903, 202);
            this.dtBaoCaoNhapHang.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIn);
            this.groupBox2.Location = new System.Drawing.Point(766, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 81);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(31, 19);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(104, 48);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "In";
            this.btnIn.UseSelectable = true;
            // 
            // cbbDenNgay
            // 
            this.cbbDenNgay.FormattingEnabled = true;
            this.cbbDenNgay.ItemHeight = 23;
            this.cbbDenNgay.Location = new System.Drawing.Point(119, 28);
            this.cbbDenNgay.Name = "cbbDenNgay";
            this.cbbDenNgay.Size = new System.Drawing.Size(283, 29);
            this.cbbDenNgay.TabIndex = 12;
            this.cbbDenNgay.UseSelectable = true;
            // 
            // BAOCAONHAPHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 400);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtBaoCaoNhapHang);
            this.Controls.Add(this.groupBox2);
            this.Name = "BAOCAONHAPHANG";
            this.Text = "BÁO CÁO NHẬP HÀNG";
            this.Load += new System.EventHandler(this.BAOCAONHAPHANG_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaoCaoNhapHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox cbbDenNgay;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dtBaoCaoNhapHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnIn;
    }
}