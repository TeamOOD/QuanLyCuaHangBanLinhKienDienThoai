using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier;
using DataTransferObject;

namespace QuanLyCuaHangLinhKienDienThoai.GUI
{
    public partial class THEMKHACHHANG : MetroFramework.Forms.MetroForm
    {
        private KhachHangBUS khBUS;
        private String maKH = "";

        public THEMKHACHHANG()
        {
            InitializeComponent();
            this.khBUS = new KhachHangBUS();
        }

        private void THEMKHACHHANG_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();

            if (this.tbnTenKhachHang.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống tên khách hàng");
                return;
            }

            //kh.MaKhachHang = this.teTenKhachHang.Text;
            kh.TenKhachHang = this.tbnTenKhachHang.Text;
            kh.DiaChi = this.tbnDiaChi.Text;
            kh.SoDienThoai = this.tbnSoDienThoai.Text;
            kh.Email = this.tbnEmail.Text;
            kh.GhiChu = this.tbnGhiChu.Text;

            if (StaticVariables.gKhachHang != null)
            {
                kh.MaKhachHang = this.maKH;
                if (this.khBUS.CapNhatKhachHang(kh))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Cập nhật khách hàng thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else

                if (this.khBUS.ThemKhachHang(kh))
            {
                MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.resetValue();
        }

        private void groupThongTinKH_Enter(object sender, EventArgs e)
        {
            if (StaticVariables.gKhachHang != null)
            {
                this.maKH = StaticVariables.gKhachHang.MaKhachHang;
                this.tbnTenKhachHang.Text = StaticVariables.gKhachHang.TenKhachHang;
                this.tbnSoDienThoai.Text = StaticVariables.gKhachHang.SoDienThoai;
                this.tbnEmail.Text = StaticVariables.gKhachHang.Email;
                this.tbnDiaChi.Text = StaticVariables.gKhachHang.DiaChi;
                this.tbnGhiChu.Text = StaticVariables.gKhachHang.GhiChu;

            }
            else
            {
                this.resetValue();
            }
        }

        private void resetValue()
        {
            this.tbnTenKhachHang.Text = " ";
            this.tbnSoDienThoai.Text = " ";
            this.tbnEmail.Text = " ";
            this.tbnDiaChi.Text = " ";
            this.tbnGhiChu.Text = " ";
        }


    }
}
