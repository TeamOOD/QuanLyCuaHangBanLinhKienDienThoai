namespace QuanLyCuaHangLinhKienDienThoai.GUI
{
    partial class BAOCAOTONKHO
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
            this.dtDanhSachHangTonKhoDaLap = new System.Windows.Forms.DataGridView();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbbFrom = new MetroFramework.Controls.MetroComboBox();
            this.cbbTo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtChiTietTonKho = new System.Windows.Forms.DataGridView();
            this.btnLapBaoCao = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDanhSachHangTonKhoDaLap)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtChiTietTonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.cbbTo);
            this.groupBox1.Controls.Add(this.cbbFrom);
            this.groupBox1.Controls.Add(this.dtDanhSachHangTonKhoDaLap);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Location = new System.Drawing.Point(23, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 440);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách báo cáo tồn kho đã lập";
            // 
            // dtDanhSachHangTonKhoDaLap
            // 
            this.dtDanhSachHangTonKhoDaLap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDanhSachHangTonKhoDaLap.Location = new System.Drawing.Point(0, 85);
            this.dtDanhSachHangTonKhoDaLap.Name = "dtDanhSachHangTonKhoDaLap";
            this.dtDanhSachHangTonKhoDaLap.Size = new System.Drawing.Size(319, 347);
            this.dtDanhSachHangTonKhoDaLap.TabIndex = 8;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 16);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(114, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Lọc theo thời gian";
            // 
            // cbbFrom
            // 
            this.cbbFrom.FormattingEnabled = true;
            this.cbbFrom.ItemHeight = 23;
            this.cbbFrom.Location = new System.Drawing.Point(6, 39);
            this.cbbFrom.Name = "cbbFrom";
            this.cbbFrom.Size = new System.Drawing.Size(121, 29);
            this.cbbFrom.TabIndex = 9;
            this.cbbFrom.UseSelectable = true;
            // 
            // cbbTo
            // 
            this.cbbTo.FormattingEnabled = true;
            this.cbbTo.ItemHeight = 23;
            this.cbbTo.Location = new System.Drawing.Point(198, 39);
            this.cbbTo.Name = "cbbTo";
            this.cbbTo.Size = new System.Drawing.Size(121, 29);
            this.cbbTo.TabIndex = 10;
            this.cbbTo.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(145, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(31, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "đến";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLapBaoCao);
            this.groupBox2.Controls.Add(this.dtChiTietTonKho);
            this.groupBox2.Location = new System.Drawing.Point(365, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 440);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết tồn kho";
            // 
            // dtChiTietTonKho
            // 
            this.dtChiTietTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtChiTietTonKho.Location = new System.Drawing.Point(0, 85);
            this.dtChiTietTonKho.Name = "dtChiTietTonKho";
            this.dtChiTietTonKho.Size = new System.Drawing.Size(784, 347);
            this.dtChiTietTonKho.TabIndex = 8;
            // 
            // btnLapBaoCao
            // 
            this.btnLapBaoCao.Location = new System.Drawing.Point(642, 21);
            this.btnLapBaoCao.Name = "btnLapBaoCao";
            this.btnLapBaoCao.Size = new System.Drawing.Size(112, 43);
            this.btnLapBaoCao.TabIndex = 9;
            this.btnLapBaoCao.Text = "Lập báo cáo";
            this.btnLapBaoCao.UseSelectable = true;
            // 
            // BAOCAOTONKHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BAOCAOTONKHO";
            this.Text = "BÁO CÁO TỒN KHO";
            this.Load += new System.EventHandler(this.BAOCAOTONKHO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDanhSachHangTonKhoDaLap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtChiTietTonKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtDanhSachHangTonKhoDaLap;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbbTo;
        private MetroFramework.Controls.MetroComboBox cbbFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnLapBaoCao;
        private System.Windows.Forms.DataGridView dtChiTietTonKho;
    }
}