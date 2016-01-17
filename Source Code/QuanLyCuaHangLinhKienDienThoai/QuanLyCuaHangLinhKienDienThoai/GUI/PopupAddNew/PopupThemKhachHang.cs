using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier;
using DataTransferObject;
using DevExpress.XtraEditors;

namespace QuanLyCuaHangLinhKienDienThoai.GUI.PopupAddNew
{
    public partial class PopupThemKhachHang : DevExpress.XtraEditors.XtraForm
    {
        private KhachHangBUS khBUS;

        public PopupThemKhachHang()
        {
            InitializeComponent();
            khBUS = new KhachHangBUS();
        }

        private void sbLuu_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();

            if (this.teTenKhachHang.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống tên khách hàng");
                return;
            }

            //kh.MaKhachHang = this.teTenKhachHang.Text;
            kh.TenKhachHang = this.teTenKhachHang.Text;
            kh.DiaChi = this.teDiaChi.Text;
            kh.SoDienThoai = this.teSoDienThoai.Text;
            kh.Email = this.teEmail.Text;
            kh.GhiChu = this.txtGhiChu.Text;


            if (this.khBUS.ThemKhachHang(kh))
            {
                MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại", "Thông báo", MessageBoxButtons.OK);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}