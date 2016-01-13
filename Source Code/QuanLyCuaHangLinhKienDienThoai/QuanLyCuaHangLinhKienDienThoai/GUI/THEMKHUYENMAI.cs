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
    public partial class THEMKHUYENMAI : MetroFramework.Forms.MetroForm
    {
        private String maKM = "";

        //thông tin sản phẩm.
        private String maSP = "";
        private String tenSP = "";
        private int soLuong = 0;
        private Decimal tienSP = 0;

        public THEMKHUYENMAI()
        {
            InitializeComponent();

            this.LoadData();
        }

        private void LoadData()
        {
            //sau khi dang nhap
            //StaticVariables.nhanVien = new DataTransferObject.NhanVien();
            //StaticVariables.nhanVien.TenNhanVien = "Nam";
            //StaticVariables.nhanVien.MaNhanVien = "NV00000001";
            this.tbnTenNhanVien.Text = StaticVariables.nhanVien.TenNhanVien;
            this.tbnMaNhanVien.Text = StaticVariables.nhanVien.MaNhanVien;

            //load danh sách san phẩm
            this.dtDanhSachSanPham.DataSource = (new MatHangBUS().LayDanhSachMatHangBan());

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Mã sản phẩm"));
            dt.Columns.Add(new DataColumn("Tên sản phẩm"));
            dt.Columns.Add(new DataColumn("Số lượng"));
            dt.Columns.Add(new DataColumn("Giá bán"));
            this.dtSanPhamKhuyenMai.DataSource = (dt);

            this.dtTimeBatDau.Value = DateTime.Now;
        }

        private void THEMKHUYENMAI_Load(object sender, EventArgs e)
        {

        }

        private void groupThongTinKH_Enter(object sender, EventArgs e)
        {
            this.tbnTenNhanVien.Text = StaticVariables.nhanVien.TenNhanVien;
            this.tbnMaNhanVien.Text = StaticVariables.nhanVien.MaNhanVien;
            if (StaticVariables.gKhuyenMai != null)
            {

                this.maKM = StaticVariables.gKhuyenMai.MaKhuyenMai;
                this.tbnTenCTKM.Text = StaticVariables.gKhuyenMai.TenChuongTrinh;
                this.dtTimeBatDau.Text = StaticVariables.gKhuyenMai.ThoiGianDB;
                this.dtTimeKT.Text = StaticVariables.gKhuyenMai.ThoiGianKT;
                this.tbnSoLuong.Text = "";

                CTKHuyenMai ctKM = new CTKHuyenMai();
                ctKM.KhuyenMai.MaKhuyenMai = StaticVariables.gKhuyenMai.MaKhuyenMai;
                this.dtSanPhamKhuyenMai.DataSource = (new KhuyenMaiBUS().TimKiemChiTietCTKhuyenMai(ctKM));

                // nếu khuyến mãi này đã kết thúc thì không cho update
                if (DateTime.Compare(this.dtTimeKT.Value, DateTime.Now) < 0)
                {
                    this.btnLuu.Enabled = false;
                }
                else
                    this.btnLuu.Enabled = true;
            }
            else
            {
                this.btnLamMoi_Click(null, null);
            }
        }

        private void tbnGiaKM_TextChanged(object sender, EventArgs e)
        {
            if (tbnGiaKM.Text == "")
                tbnGiaKM.Text = "0";

            if (Convert.ToDecimal(tbnGiaKM.Text) < 0)
                tbnGiaKM.Text = "0";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.tbnTenCTKM.Text = "";
            this.dtTimeBatDau.Text = "";
            this.dtTimeKT.Text = "";
            this.tbnSoLuong.Text = "";
            DataTable dt = this.dtSanPhamKhuyenMai.DataSource as DataTable;
            dt.Clear();

            this.dtSanPhamKhuyenMai.DataSource = dt;
        }

        private void btnLamMoiKM_Click(object sender, EventArgs e)
        {
            btnLamMoi_Click(null, null);
        }

        private void dtDanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.maSP = this.dtDanhSachSanPham.Rows[e.RowIndex].Cells["Mã sản phẩm"].Value.ToString();
            this.tenSP = this.dtDanhSachSanPham.Rows[e.RowIndex].Cells["Tên sản phẩm"].Value.ToString();
            this.tienSP = Convert.ToDecimal(this.dtDanhSachSanPham.Rows[e.RowIndex].Cells["Giá bán"].Value.ToString());
        }


    }
}
