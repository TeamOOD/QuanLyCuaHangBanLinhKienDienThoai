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

namespace QuanLyCuaHangLinhKienDienThoai.GUI
{
    public partial class THEMPHIEUBAOHANH : MetroFramework.Forms.MetroForm
    {
        private HoaDonBaoHanhBUS hoaDonBaoHanhBUS;
        private String maHD = "";

        //Product Information
        private String maSP = "";
        private String tenSP = "";
        private int soLuong = 0;
        private Decimal tienSP = 0;
        private Decimal tienLephi = 0;
        private Decimal tienTongSp = 0;
        private String maKhuyenMai = "";

        public THEMPHIEUBAOHANH()
        {
            InitializeComponent();

            this.hoaDonBaoHanhBUS = new HoaDonBaoHanhBUS();

            this.cbbTrangThai.DataSource = (new HoaDonBaoHanhBUS().LayDanhSachTrangThai());
            this.cbbTrangThai.DisplayMember = "Tên trạng thái";
            this.cbbTrangThai.ValueMember = "Mã trạng thái";

            this.LoadData();
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Mã sản phẩm"));
            dt.Columns.Add(new DataColumn("Tên sản phẩm"));
            dt.Columns.Add(new DataColumn("Số lượng"));
            this.dtSanPhamBaoHanh.DataSource = (dt);


            this.dtnThoiGianLap.Value = DateTime.Now;
        }

        private void THEMPHIEUBAOHANH_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel15_Click(object sender, EventArgs e)
        {

        }
    }
}
