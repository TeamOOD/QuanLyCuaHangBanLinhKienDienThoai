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
    public partial class THEMNHANVIEN : MetroFramework.Forms.MetroForm
    {
        private NhanVienBUS nhanvienBUS;
        private String maNV = "";

        public THEMNHANVIEN()
        {
            InitializeComponent();

            this.nhanvienBUS = new NhanVienBUS();

            this.cbbChucVu.DataSource = (new ChucVuBUS().LoadComBoBox());
            this.cbbChucVu.DisplayMember = "Tên chức vụ";
            this.cbbChucVu.ValueMember = "Mã chức vụ";

            this.dtnNgayTao.Value = DateTime.Now;
        }

        private void resetValue()
        {
            this.tbnTenNhanVien.Text = "";
            this.dtnNgaySinh.Text = "";
            this.tbnSoDienThoai.Text = "";
            this.tbnTaiKhoan.Text = "";
            this.tbnMatKhau.Text = "";
            this.tbnGhiChu.Text = "";
            this.tbnDiaChi.Text = "";
            this.cbbGioiTinh.SelectedIndex = 0;
            this.tbnCMND.Text = "";
            this.tbnEmail.Text = "";
            this.cbbChucVu.Text = "";
        }

        private void THEMNHANVIEN_Load(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            resetValue();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();

            if (this.tbnTenNhanVien.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống Tên nhân viên");
                return;
            }

            nv.TenNhanVien = this.tbnTenNhanVien.Text;
            nv.NgaySinh = this.dtnNgaySinh.Value.ToString("dd/MM/yyyy");
            nv.SoDienThoai = this.tbnSoDienThoai.Text;
            nv.TaiKhoan = this.tbnTaiKhoan.Text;
            nv.MatKhau = (new Encrypt().MD52(this.tbnMatKhau.Text, 2));
            nv.GhiChu = this.tbnGhiChu.Text;
            nv.DiaChi = this.tbnDiaChi.Text;

            nv.GioiTinh = cbbGioiTinh.SelectedText;

            nv.CMND = this.tbnCMND.Text;
            nv.Email = this.tbnEmail.Text;
            nv.ChucVuNhanVien.MaChucVu = this.cbbChucVu.SelectedValue == null ? "" : this.cbbChucVu.SelectedValue.ToString();

            if (StaticVariables.gNhanVien != null)
            {
                nv.MaNhanVien = this.maNV;
                if (this.nhanvienBUS.CapNhatNhanVien(nv))
                {
                    MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại", "Thông báo", MessageBoxButtons.OK);
                }

            }
            else
                if (this.nhanvienBUS.ThemNhanVien(nv))
            {
                MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void groupControl_Enter(object sender, EventArgs e)
        {
            if (StaticVariables.gNhanVien != null) //# null thi cap nhat nguoc lai thi them
            {
                this.maNV = StaticVariables.gNhanVien.MaNhanVien;
                this.tbnTenNhanVien.Text = StaticVariables.gNhanVien.TenNhanVien;
                this.dtnNgaySinh.Text = StaticVariables.gNhanVien.NgaySinh;
                this.tbnSoDienThoai.Text = StaticVariables.gNhanVien.SoDienThoai;
                this.tbnTaiKhoan.Text = StaticVariables.gNhanVien.TaiKhoan;
                this.tbnMatKhau.Text = StaticVariables.gNhanVien.MatKhau;
                this.tbnGhiChu.Text = StaticVariables.gNhanVien.GhiChu;
                this.tbnDiaChi.Text = StaticVariables.gNhanVien.DiaChi;

                if (StaticVariables.gNhanVien.GioiTinh.Contains("Nam"))
                    this.cbbGioiTinh.SelectedIndex = 0;
                else
                    this.cbbGioiTinh.SelectedIndex = 1;

                this.tbnCMND.Text = StaticVariables.gNhanVien.CMND.ToString();
                this.tbnEmail.Text = StaticVariables.gNhanVien.Email;
                this.cbbChucVu.Text = StaticVariables.gNhanVien.ChucVuNhanVien.TenChucVu;
            }
            else
            {
                this.resetValue();
            }
        }
    }
}
