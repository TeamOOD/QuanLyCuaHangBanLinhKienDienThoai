﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessLogicTier;
using DataTransferObject;

namespace QuanLyCuaHangLinhKienDienThoai.UserControl
{
    public partial class ucPhieuBanHangTimKiem : DevExpress.XtraEditors.XtraUserControl
    {
        private ChiTietHoaDonBanBUS hoaDonBUS;
        public ucPhieuBanHangTimKiem()
        {
            InitializeComponent();
            hoaDonBUS = new ChiTietHoaDonBanBUS();
        }

        private void sbLuu_Click(object sender, EventArgs e)
        {

        }

        private void gcKetQua_Click(object sender, EventArgs e)
        {

        }

        private void sbLapHangHoa_Click(object sender, EventArgs e)
        {
            String Name = "Lập hóa đơn bán hàng";
            if (!StaticVariables.isTabExist(Name))
            {
                StaticVariables.addNewTab(new ucLapPhieuBanHang(), Name);
            } 
        }

        private void sbTimKiemHoaDon_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonBan hd = new ChiTietHoaDonBan();
            hd.MaHoaDon = this.teMaHoaDon.Text;
            hd.MaHoaDon = this.teMaHoaDon.Text;
            hd.KhachHang.TenKhachHang = this.teTenHangHoa.Text;
            hd.KhachHang.MaKhachHang = this.teMaKhachHang.Text;
            hd.NgayTT = this.deThoiGianLap.Text;
            hd.CtHoaDon.NhanVien.MaNhanVien = this.teMaNhanVien.Text;
            hd.CtHoaDon.NhanVien.TenNhanVien = this.teTenNhanVien.Text;
            hd.CtHoaDon.MatHang.MaMatHang = this.teTenHangHoa.Text;
            hd.CtHoaDon.MatHang.TenMatHang = this.teTenHangHoa.Text;

            this.hoaDonBUS.TimKiemhoaDon(hd);
        }

        private void sbXoa_Click(object sender, EventArgs e)
        {
            String message = "";
            if (this.hoaDonBUS.XoahoaDon(this.teMaHoaDon.Text))
                message += "Xóa thành công";
            else
                message += "Xóa lỗi! \nVui lòng kiểm tra lại thông tin trước khi xóa.";

            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
            
        }
    }
}
