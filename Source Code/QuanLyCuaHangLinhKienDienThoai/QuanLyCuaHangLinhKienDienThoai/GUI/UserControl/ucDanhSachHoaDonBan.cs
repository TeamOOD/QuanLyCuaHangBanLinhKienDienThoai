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
using BusinessLogicTier;
using DataTransferObject;
using DevExpress.XtraEditors.Controls;

namespace QuanLyCuaHangLinhKienDienThoai.UserControl
{
    public partial class ucDanhSachHoaDonBan : DevExpress.XtraEditors.XtraUserControl
    {
        private HoaDonBanBUS hoaDonBUS;
        public ucDanhSachHoaDonBan()
        {
            InitializeComponent();
            hoaDonBUS = new HoaDonBanBUS();
            this.LoadData();
        }

        private void gcKetQua_Click(object sender, EventArgs e)
        {

        }

        private void sbLapHangHoa_Click(object sender, EventArgs e)
        {
            String Name = "Lập hóa đơn bán hàng";
            StaticVariables.gHoaDonBan = null;
            if (!StaticVariables.isTabExist(Name))
            {              
                StaticVariables.addNewTab(new ucThemPhieuBanHang(), Name);
            } 
        }

        private void sbTimKiemHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonBan hd = new HoaDonBan();

            hd.KhachHang.TenKhachHang = this.teTenKhachHang.Text;
            hd.HoaDon.MaHoaDon = this.teMaHoaDon.Text;

            hd.LePhiGiaoHang.MaKhuVuc = this.lueKhuVu.EditValue == null ? "" : this.lueKhuVu.EditValue.ToString();
            hd.HoaDon.TrangThai.MaTrangThai = this.lueTrangThai.EditValue == null ? "" : this.lueTrangThai.EditValue.ToString();

            hd.NgayTT = this.deThoiGianLap.DateTime.ToString("dd/MM/yyyy");
            if (hd.NgayTT.Equals("01/01/0001"))
            {
                hd.NgayTT = "";
            }
            hd.HoaDon.NhanVien.TenNhanVien = this.teTenNhanVien.Text;

           this.gcKetQua.DataSource = this.hoaDonBUS.TimKiemhoaDon(hd);
        }

        private void sbXoa_Click(object sender, EventArgs e)
        {

            String message = "";
            DialogResult result = MessageBox.Show("Bạn có muốn xóa dòng này hay không ?",
            "Thông báo",
             MessageBoxButtons.YesNoCancel,
             MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (this.hoaDonBUS.XoahoaDon(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã hóa đơn bán").ToString()))
                    message += "Xóa thành công";
                else
                    message += "Xóa lỗi! \nVui lòng kiểm tra lại thông tin trước khi xóa.";

                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
                gridView1.FocusedRowHandle = 0;
                this.LoadData();
            }
        }

        private void sbCapNhat_Click(object sender, EventArgs e)
        {
            String Name = "Lập hóa đơn bán hàng";
            if (!StaticVariables.isTabExist(Name))
            {
                StaticVariables.addNewTab(new ucThemPhieuBanHang(), Name);
            } 
        }

        private void LoadData()
        {
            //Lấy ds trạng thái.
            this.lueTrangThai.Properties.DataSource = (new HoaDonBanBUS().LayDanhSachTrangThai());
            this.lueTrangThai.Properties.Columns.Add(new LookUpColumnInfo(this.lueTrangThai.Properties.DisplayMember));

            //Lấy ds khu vuc
            this.lueKhuVu.Properties.DataSource = (new LePhiGiaoHangBUS().LayDanhSachLePhiGiaoHang());
            this.lueKhuVu.Properties.Columns.Add(new LookUpColumnInfo(this.lueKhuVu.Properties.DisplayMember));

            this.gcKetQua.DataSource = hoaDonBUS.LayDanhSachhoaDon();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            StaticVariables.gHoaDonBan = new HoaDonBan();
            if (this.gridView1.RowCount != 0)
            {
                StaticVariables.gHoaDonBan.HoaDon.MaHoaDon = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã hóa đơn bán").ToString();
                StaticVariables.gHoaDonBan.HoaDon.NhanVien.TenNhanVien = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên nhân viên").ToString();
                StaticVariables.gHoaDonBan.KhachHang.TenKhachHang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên khách hàng").ToString();
                StaticVariables.gHoaDonBan.HoaDon.TongTien = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tổng tiền").ToString() == "" ? 0 : Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tổng tiền").ToString());
                StaticVariables.gHoaDonBan.DiaChiGH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Địa chỉ giao hàng").ToString();
                StaticVariables.gHoaDonBan.HoaDon.NgayLap = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ngày Lập").ToString();

                DataTable dt = this.gcKetQua.DataSource as DataTable;

                int indexRowForcus = gridView1.FocusedRowHandle;
                StaticVariables.gHoaDonBan.KhachHang.MaKhachHang = dt.Rows[indexRowForcus].Field<String>("MaKhachHang");
                StaticVariables.gHoaDonBan.HoaDon.NhanVien.MaNhanVien = dt.Rows[indexRowForcus].Field<String>("MaNhanVien");
                try
                {
                    object a = dt.Rows[indexRowForcus].Field<DateTime>("NgayGiaoHang");
                    if(a != null)
                        StaticVariables.gHoaDonBan.NgayGiaoHang = a == null ? "" :a.ToString();         
                }
                catch (Exception ex)
                {
                    object a = dt.Rows[indexRowForcus].Field<String>("NgayGiaoHang");
                    if (a != null)
                      StaticVariables.gHoaDonBan.NgayGiaoHang = a == null ? "" : a.ToString();         
                }
             
                StaticVariables.gHoaDonBan.HoaDon.TrangThai.MaTrangThai = dt.Rows[indexRowForcus].Field<String>("MaTrangThai");
                StaticVariables.gHoaDonBan.HoaDon.TrangThai.TenTrangThai = dt.Rows[indexRowForcus].Field<String>("TenTrangThai");
               
                object x = dt.Rows[indexRowForcus].Field<Decimal?>("TienDaTT");
                if (x == null)
                    StaticVariables.gHoaDonBan.HoaDon.TienDaTT = 0;
                else
                    StaticVariables.gHoaDonBan.HoaDon.TienDaTT = Convert.ToDecimal(dt.Rows[indexRowForcus].Field<Decimal?>("TienDaTT").ToString());
                StaticVariables.gHoaDonBan.LePhiGiaoHang.MaKhuVuc = dt.Rows[indexRowForcus].Field<String>("MaKhuVuc");
                StaticVariables.gHoaDonBan.LePhiGiaoHang.TenKhuVuc = dt.Rows[indexRowForcus].Field<String>("TenKhuVuc");
                StaticVariables.gHoaDonBan.LePhiGiaoHang.Dongia = dt.Rows[indexRowForcus].Field<Decimal?>("DonGia") == null ? 0 : Convert.ToDecimal(dt.Rows[indexRowForcus].Field<Decimal?>("DonGia").ToString());               
            }
          
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.teMaHoaDon.Text = "";
            this.teTenNhanVien.Text = "";
            this.teTenKhachHang.Text = "";
            this.lueKhuVu.EditValue = "";
            this.lueTrangThai.EditValue = "";
            this.deThoiGianLap.Text = "";
            this.gcKetQua.DataSource = hoaDonBUS.LayDanhSachhoaDon();
        }
    }
}
