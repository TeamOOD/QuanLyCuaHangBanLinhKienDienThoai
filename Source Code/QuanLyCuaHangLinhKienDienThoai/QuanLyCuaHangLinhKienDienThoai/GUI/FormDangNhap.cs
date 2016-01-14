using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataTransferObject;
using BusinessLogicTier;

namespace QuanLyCuaHangLinhKienDienThoai
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Login();

         //  FormMain formchinh = new FormMain("", "", "CV0000000000001");
          // formchinh.Show();
          //  this.Hide();
            //lay thong tin nhan vien va truyen vao mainform                            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                Login();
        }

        private void Login()
        {
            if (this.teMK.Text != "" && this.teTenDN.Text != "")
            {
                NhanVien nv = (new NhanVienBUS().DangNhap(this.teTenDN.Text, new Encrypt().MD52(this.teMK.Text, 2)));
                if (nv != null)
                {
                    StaticVariables.nhanVien = new NhanVien();
                    StaticVariables.nhanVien.TenNhanVien = nv.TenNhanVien;
                    StaticVariables.nhanVien.MaNhanVien = nv.MaNhanVien;
                    StaticVariables.nhanVien.ChucVuNhanVien.MaChucVu = nv.ChucVuNhanVien.MaChucVu;
                    StaticVariables.nhanVien.ChucVuNhanVien.TenChucVu = nv.ChucVuNhanVien.TenChucVu;

                    FormMain formchinh = new FormMain(StaticVariables.nhanVien.TenNhanVien, StaticVariables.nhanVien.ChucVuNhanVien.TenChucVu, StaticVariables.nhanVien.ChucVuNhanVien.MaChucVu);
                    formchinh.Show();
                    this.Hide();
                }
                else
                    lcKetQuaDangNhap.Text = "Bạn nhập sai mật khẩu hoặc tài khoản";
            }
            else
            {
                lcKetQuaDangNhap.Text = "Bạn chưa nhập tài khoàn và mật khẩu";
            }
        }

        private void teTenDN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                teMK.Focus();
        }

        private void teMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                Login();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            StaticVariables.nhanVien = new NhanVien();
            StaticVariables.nhanVien.TenNhanVien = "Khách";
            StaticVariables.nhanVien.MaNhanVien = "KH0000000000000";
            StaticVariables.nhanVien.ChucVuNhanVien.MaChucVu = "CV0000000000006";
            StaticVariables.nhanVien.ChucVuNhanVien.TenChucVu = "Khách Hàng";

            FormMain formchinh = new FormMain(StaticVariables.nhanVien.TenNhanVien, StaticVariables.nhanVien.ChucVuNhanVien.TenChucVu, StaticVariables.nhanVien.ChucVuNhanVien.MaChucVu);
            formchinh.Show();
            this.Hide();
        }
    }
}