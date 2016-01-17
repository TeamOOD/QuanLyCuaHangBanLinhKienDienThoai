using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataTransferObject;
using BusinessLogicTier;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace QuanLyCuaHangLinhKienDienThoai.UserControl
{
    public partial class ucPhieuBaoHanh : DevExpress.XtraEditors.XtraUserControl
    {
        private HoaDonBaoHanhBUS hdbhBUS;
        public ucPhieuBaoHanh()
        {
            InitializeComponent();
            hdbhBUS = new HoaDonBaoHanhBUS();
            this.LoadData();
        }

        private void sbThemPhieu_Click(object sender, EventArgs e)
        {
            string name = "Lập phiếu bảo hành";
            if (!StaticVariables.isTabExist(name))
            {
                StaticVariables.gHoaDonBaoHanh = null;
                StaticVariables.addNewTab(new ucThemPhieuBaoHanh(), name);
            }
        }

        private void sbXoaPhieu_Click(object sender, EventArgs e)
        {
            String message = "";
            DialogResult result = MessageBox.Show("Bạn có muốn xóa dòng này hay không ?",
            "Thông báo",
             MessageBoxButtons.YesNoCancel,
             MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (this.hdbhBUS.XoaHoaDonBaoHanh(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã hóa đơn bảo hành").ToString()))
                    message += "Xóa thành công";
                else
                    message += "Xóa lỗi! \nVui lòng kiểm tra lại thông tin trước khi xóa.";

                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
                gridView1.FocusedRowHandle = 0;
                this.LoadData();
            }
        }

        private void LoadData()
        {
            this.lueTrangThai.Properties.DataSource = (new HoaDonBaoHanhBUS().LayDanhSachTrangThai());
            this.lueTrangThai.Properties.Columns.Add(new LookUpColumnInfo(this.lueTrangThai.Properties.DisplayMember));

            DataTable data = new DataTable();
            data = this.hdbhBUS.LayDanhSachHoaDonBaoHanh();
            this.gcKetQua.DataSource = data;
        }

        private void sbTimKiemHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonBaoHanh hdbh = new HoaDonBaoHanh();
            hdbh.HoaDon.NgayLap = this.deThoiGianLap.DateTime.ToString("dd/MM/yyyy");
            if (hdbh.HoaDon.NgayLap.Equals("01/01/0001"))
            {
                hdbh.HoaDon.NgayLap = "";
            }
            hdbh.MaHoaDonBaoHanh = this.teMaHoaDon.Text;
            hdbh.KhachHang.TenKhachHang = this.teTenKhachHang.Text;
            hdbh.KhachHang.MaKhachHang = this.teMaKhachHang.Text;
            
            this.gcKetQua.DataSource = this.hdbhBUS.TimKiemHoaDonBaoHanh(hdbh);
        }

        private void sbCapNhat_Click(object sender, EventArgs e)
        {
            String name = "Sửa hóa đơn bảo hành";
            if (!StaticVariables.isTabExist(name))
            {
                StaticVariables.addNewTab(new ucThemPhieuBaoHanh(), name);
            } 
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            StaticVariables.gHoaDonBaoHanh = new HoaDonBaoHanh();
            if (this.gridView1.RowCount != 0)
            {
                StaticVariables.gHoaDonBaoHanh.HoaDon.MaHoaDon = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã hóa đơn bảo hành").ToString();
                StaticVariables.gHoaDonBaoHanh.HoaDonBan.HoaDon.MaHoaDon = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã hóa đơn bán").ToString();
                StaticVariables.gHoaDonBaoHanh.HoaDon.NhanVien.TenNhanVien = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên nhân viên").ToString();
               // StaticVariables.gHoaDonBaoHanh.HoaDon.NhanVien.MaNhanVien = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã nhân viên").ToString();
                StaticVariables.gHoaDonBaoHanh.KhachHang.TenKhachHang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên khách hàng").ToString();
                //StaticVariables.gHoaDonBaoHanh.KhachHang.MaKhachHang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã khách hàng").ToString();
                StaticVariables.gHoaDonBaoHanh.HoaDon.TrangThai.TenTrangThai = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Trạng thái").ToString();
                StaticVariables.gHoaDonBaoHanh.HoaDon.NgayLap = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ngày lập").ToString();
                StaticVariables.gHoaDonBaoHanh.HoaDon.GhiChu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ghi chú").ToString();

                DataTable dt = this.gcKetQua.DataSource as DataTable;
                int indexRowFocus = gridView1.FocusedRowHandle;
                //string x = dt.Rows[indexRowFocus].Field<String>("MaKhachHang").ToString();
                StaticVariables.gHoaDonBaoHanh.KhachHang.MaKhachHang = dt.Rows[indexRowFocus].Field<String>("MaKhachHang").ToString();
                StaticVariables.gHoaDonBaoHanh.HoaDon.NhanVien.MaNhanVien = dt.Rows[indexRowFocus].Field<String>("MaNhanVien").ToString();


            }
        }

        private void sbLamMoi_Click(object sender, EventArgs e)
        {
            teMaHoaDon.Text = "";
            teTenKhachHang.Text = "";
            teMaKhachHang.Text = "";
            meGhiChu.Text = "";
            lueTrangThai.Text = "";
        }


    }
}
