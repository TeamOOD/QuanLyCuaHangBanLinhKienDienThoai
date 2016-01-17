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
using DevExpress.XtraTab;
using DataTransferObject;
using DevExpress.XtraEditors.Controls;

namespace QuanLyCuaHangLinhKienDienThoai.UserControl
{
    public partial class ucDanhSachNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        private NhanVienBUS nhanVienBUS;

        public ucDanhSachNhanVien()
        {
            InitializeComponent();
            this.nhanVienBUS = new NhanVienBUS();
            this.LoadData();
        }

        private void sbThem_Click(object sender, EventArgs e)
        {
            String Name = "Thêm nhân viên";
            StaticVariables.gNhanVien = null;
            if (!StaticVariables.isTabExist(Name))
            {             
               StaticVariables.addNewTab(new ucThemNhanVien(), Name);
            }        
        }

        private void sbTimKiem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();          
            nv.MaNhanVien = this.teMaNhanVien.Text;
            nv.TenNhanVien = this.teTenNhanVien.Text;
            nv.NgaySinh = this.deNgaySinh.DateTime.ToString("dd/MM/yyyy");
            if (nv.NgaySinh.Equals("01/01/0001"))
                nv.NgaySinh = "";
            nv.SoDienThoai = this.teSoDienThoai.Text.Contains("0") ? null : this.teSoDienThoai.Text;
            nv.DiaChi = this.teDiaChi.Text;
            nv.CMND = this.teCMND.Text.Contains("0") ? null : this.teCMND.Text;
            nv.ChucVuNhanVien.MaChucVu = this.lueChucVu.EditValue == null ? "" : this.lueChucVu.EditValue.ToString();

            this.GridNhanVien.DataSource = this.nhanVienBUS.TimKiemNhanVien(nv);
        }

        private void sbCapNhat_Click(object sender, EventArgs e)
        {
            String Name = "Chỉnh sửa nhân viên";
            if (!StaticVariables.isTabExist(Name))
            {
                StaticVariables.addNewTab(new ucThemNhanVien(), Name);
            }  
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
                if (nhanVienBUS.XoaNhanVien(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã nhân viên").ToString()))
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
            //Lấy ds nhân viên nha. doi t xiu
            DataTable data = new DataTable();
            data = this.nhanVienBUS.LayDanhSachNhanVien();
            this.GridNhanVien.DataSource = data;

            this.lueChucVu.Properties.DataSource = (new ChucVuBUS().LoadComBoBox());
            this.lueChucVu.Properties.Columns.Add(new LookUpColumnInfo(this.lueChucVu.Properties.DisplayMember));
           // this.GridNhanVien.DataSource = (new ChucVuBUS().LoadComBoBox()); 
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            StaticVariables.gNhanVien = new NhanVien();
            if (gridView1.RowCount != 0)
            {
                StaticVariables.gNhanVien.MaNhanVien = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã nhân viên").ToString();
                StaticVariables.gNhanVien.TenNhanVien = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên nhân viên").ToString();
                StaticVariables.gNhanVien.CMND = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CMND").ToString();
                StaticVariables.gNhanVien.GioiTinh = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Giới Tính").ToString();
                StaticVariables.gNhanVien.NgaySinh = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ngày sinh").ToString();
                StaticVariables.gNhanVien.DiaChi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Địa chỉ").ToString();
                StaticVariables.gNhanVien.SoDienThoai = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Số điện thoại").ToString();
                StaticVariables.gNhanVien.Email = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Email").ToString();
                StaticVariables.gNhanVien.TaiKhoan = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên tài khoản").ToString();
                StaticVariables.gNhanVien.ChucVuNhanVien.TenChucVu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên chức vụ").ToString();
            }
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void lueChucVu_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
