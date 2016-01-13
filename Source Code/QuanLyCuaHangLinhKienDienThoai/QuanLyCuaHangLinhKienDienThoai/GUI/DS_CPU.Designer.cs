namespace QuanLyCuaHangLinhKienDienThoai.GUI
{
    partial class DS_CPU
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
            this.btnCapNhat = new MetroFramework.Controls.MetroButton();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.btnTimKiem = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbnSoNhan = new MetroFramework.Controls.MetroTextBox();
            this.tbnTenCPU = new MetroFramework.Controls.MetroTextBox();
            this.tbnMaCPU = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtDanhSachCPU = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDanhSachCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(391, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 200);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(188, 117);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 63);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseSelectable = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(26, 117);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(109, 63);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseSelectable = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(188, 37);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 58);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseSelectable = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(26, 37);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(109, 58);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseSelectable = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbnSoNhan);
            this.groupBox1.Controls.Add(this.tbnTenCPU);
            this.groupBox1.Controls.Add(this.tbnMaCPU);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 200);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin CPU";
            // 
            // tbnSoNhan
            // 
            this.tbnSoNhan.Lines = new string[0];
            this.tbnSoNhan.Location = new System.Drawing.Point(108, 147);
            this.tbnSoNhan.MaxLength = 32767;
            this.tbnSoNhan.Name = "tbnSoNhan";
            this.tbnSoNhan.PasswordChar = '\0';
            this.tbnSoNhan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnSoNhan.SelectedText = "";
            this.tbnSoNhan.Size = new System.Drawing.Size(195, 23);
            this.tbnSoNhan.TabIndex = 11;
            this.tbnSoNhan.UseSelectable = true;
            // 
            // tbnTenCPU
            // 
            this.tbnTenCPU.Lines = new string[0];
            this.tbnTenCPU.Location = new System.Drawing.Point(108, 86);
            this.tbnTenCPU.MaxLength = 32767;
            this.tbnTenCPU.Name = "tbnTenCPU";
            this.tbnTenCPU.PasswordChar = '\0';
            this.tbnTenCPU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnTenCPU.SelectedText = "";
            this.tbnTenCPU.Size = new System.Drawing.Size(195, 23);
            this.tbnTenCPU.TabIndex = 9;
            this.tbnTenCPU.UseSelectable = true;
            // 
            // tbnMaCPU
            // 
            this.tbnMaCPU.Lines = new string[0];
            this.tbnMaCPU.Location = new System.Drawing.Point(106, 30);
            this.tbnMaCPU.MaxLength = 32767;
            this.tbnMaCPU.Name = "tbnMaCPU";
            this.tbnMaCPU.PasswordChar = '\0';
            this.tbnMaCPU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbnMaCPU.SelectedText = "";
            this.tbnMaCPU.Size = new System.Drawing.Size(195, 23);
            this.tbnMaCPU.TabIndex = 7;
            this.tbnMaCPU.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(19, 144);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Số nhân";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 86);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Tên CPU";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Mã CPU";
            // 
            // dtDanhSachCPU
            // 
            this.dtDanhSachCPU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDanhSachCPU.Location = new System.Drawing.Point(23, 288);
            this.dtDanhSachCPU.Name = "dtDanhSachCPU";
            this.dtDanhSachCPU.Size = new System.Drawing.Size(681, 162);
            this.dtDanhSachCPU.TabIndex = 4;
            this.dtDanhSachCPU.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDanhSachCPU_CellContentClick);
            // 
            // DS_CPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 463);
            this.Controls.Add(this.dtDanhSachCPU);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "DS_CPU";
            this.Text = "DANH SÁCH CPU";
            this.Load += new System.EventHandler(this.DS_CPU_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDanhSachCPU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnXoa;
        private MetroFramework.Controls.MetroButton btnCapNhat;
        private MetroFramework.Controls.MetroButton btnThem;
        private MetroFramework.Controls.MetroButton btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox tbnSoNhan;
        private MetroFramework.Controls.MetroTextBox tbnTenCPU;
        private MetroFramework.Controls.MetroTextBox tbnMaCPU;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dtDanhSachCPU;
    }
}