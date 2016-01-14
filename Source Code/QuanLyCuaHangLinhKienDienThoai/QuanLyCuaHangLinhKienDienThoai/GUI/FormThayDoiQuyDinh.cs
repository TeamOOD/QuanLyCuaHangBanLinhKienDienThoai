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
using BusinessLogicTier;
using DataTransferObject;

namespace QuanLyCuaHangLinhKienDienThoai
{
    public partial class FormThayDoiQuyDinh : DevExpress.XtraEditors.XtraForm
    {
        private ThamSoBUS _ThamSoBUS;
        public FormThayDoiQuyDinh()
        {
            InitializeComponent();
            _ThamSoBUS = new ThamSoBUS();
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ThamSo thamso = new ThamSo();
            thamso.TenThamSo = "KichThuocManHinhToiThieu";
            thamso.GiaTriChuoi = teManHinh.Text;
            thamso.GiaTriSo = Convert.ToDecimal(thamso.GiaTriChuoi);
            _ThamSoBUS.SuaThamSo(thamso);

            thamso.TenThamSo = "ThoiGianBaoHanhToiThieu";
            thamso.GiaTriChuoi = teThoiGianBaoHanh.Text;
            thamso.GiaTriSo = Convert.ToDecimal(thamso.GiaTriChuoi);
            _ThamSoBUS.SuaThamSo(thamso);

            thamso.TenThamSo = "SoSanPhamKhuyenMaiToiDa";
            thamso.GiaTriChuoi = teSLSanPhamKhuyenMai.Text;
            thamso.GiaTriSo = Convert.ToDecimal(thamso.GiaTriChuoi);
            _ThamSoBUS.SuaThamSo(thamso);

            thamso.TenThamSo = "PhanTramGiamGia";
            thamso.GiaTriChuoi = tePhanTramGiamGia.Text;
            thamso.GiaTriSo = Convert.ToDecimal(thamso.GiaTriChuoi);
            _ThamSoBUS.SuaThamSo(thamso);

            thamso.TenThamSo = "SoSanPhamTonToiDaDeDatHang";
            thamso.GiaTriChuoi = teSLSPDatHangToiThieu.Text;
            thamso.GiaTriSo = Convert.ToDecimal(thamso.GiaTriChuoi);
            _ThamSoBUS.SuaThamSo(thamso);
            MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            ThamSo thamso = new ThamSo();
            thamso.TenThamSo = "KichThuocManHinhToiThieu";
            teManHinh.Text = _ThamSoBUS.LayGiaTriThamSo(thamso);

            thamso.TenThamSo = "ThoiGianBaoHanhToiThieu";
            teThoiGianBaoHanh.Text = _ThamSoBUS.LayGiaTriThamSo(thamso);

            thamso.TenThamSo = "SoSanPhamKhuyenMaiToiDa";
            teSLSanPhamKhuyenMai.Text = _ThamSoBUS.LayGiaTriThamSo(thamso);

            thamso.TenThamSo = "PhanTramGiamGia";
            tePhanTramGiamGia.Text = _ThamSoBUS.LayGiaTriThamSo(thamso);

            thamso.TenThamSo = "SoSanPhamTonToiDaDeDatHang";
            teSLSPDatHangToiThieu.Text = _ThamSoBUS.LayGiaTriThamSo(thamso);
        }
    }
}