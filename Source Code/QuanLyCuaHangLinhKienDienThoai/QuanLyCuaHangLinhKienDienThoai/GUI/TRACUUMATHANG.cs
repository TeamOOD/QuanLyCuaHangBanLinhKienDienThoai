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
    public partial class TRACUUMATHANG : MetroFramework.Forms.MetroForm
    {
        private MatHangBUS _MatHangBUS;
        private HinhAnhBUS _HinhAnhBUS;
        private CauHinhDienThoaiBUS _CauHinhDienThoaiBUS;

        public TRACUUMATHANG()
        {
            InitializeComponent();

            _MatHangBUS = new MatHangBUS();
            _HinhAnhBUS = new HinhAnhBUS();
            _CauHinhDienThoaiBUS = new CauHinhDienThoaiBUS();

            //ComboBox NhaSanXuat
            DataTable table = (new NhaSanXuatBUS().LoadComBoBox());
            this.cbbNhaSanXuat.DataSource = table;
            this.cbbNhaSanXuat.DisplayMember = "TenNSX";
            this.cbbNhaSanXuat.ValueMember = "MaNSX";
         

            //ConboBox LoaiMatHang
            table = (new LoaiMatHangBUS().LoadComBoBox());
            this.cbbLoaiSanPham.DataSource = table;
            this.cbbLoaiSanPham.DisplayMember = "TenLoaiMatHang";
            this.cbbLoaiSanPham.ValueMember = "MaLoaiMatHang";
        }

        private void TRACUUMATHANG_Load(object sender, EventArgs e)
        {

        }

        private void timKiem()
        {
            MatHang matHang = new MatHang();
            matHang.TenMatHang = this.tbnTenSanPham.Text;

            matHang.MaLoaiMatHang = this.cbbLoaiSanPham.SelectedValue == null ? "" : this.cbbLoaiSanPham.SelectedValue.ToString();
            matHang.MaNhaSanXuat = this.cbbNhaSanXuat.SelectedValue == null ? "" : this.cbbNhaSanXuat.SelectedValue.ToString();

            DataTable data = _MatHangBUS.TimKiemMatHangDonGian(matHang);

            dtTraCuuMatHang.DataSource = data;
            //for (int i = 0; i < data.Rows.Count; i++)
            //{
            //    DataTable dt = _HinhAnhBUS.LayHinhMatHang(data.Rows[i].ItemArray[0].ToString());
            //    if (dt != null && dt.Rows.Count > 0)
            //    {
            //        tileItem1.BackgroundImage = Base64ToImage(dt.Rows[0].ItemArray[0].ToString());
            //        tileItem1.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            //    }
            //    else
            //    {
            //        tileItem1.BackgroundImage = Image.FromFile("Resources\\defaultimg.png");
            //        tileItem1.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            //    }
            //    tileItem1.Image = global::QL_Ban_DienThoai.Properties.Resources.blackboard;
            //    tileItem1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            //    tileItem1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;

            //    CauHinhDienThoai ch = _CauHinhDienThoaiBLT.LayCauHinhByMaMatHang(data.Rows[i].ItemArray[0].ToString());

            //    tileItemElement1.Text = data.Rows[i].ItemArray[1].ToString() + "\n";
            //    if (ch != null)
            //    {
            //        if (data.Rows[i].ItemArray[3].ToString().CompareTo("Điện thoại") == 0)
            //        {
            //            tileItemElement1.Text += "Kích thước màn hình: " + ch.KichThuocManHinh + " inch\n";
            //            tileItemElement1.Text += "Số Sim: " + ch.SoSim + "\n";
            //            tileItemElement1.Text += "Bộ nhớ ram: " + ch.Ram + " MB\n";
            //            tileItemElement1.Text += "Hệ điều hành: " + ch.HeDieuHanh + "\n";
            //            tileItemElement1.Text += "Bộ nhớ trong: " + ch.BoNho + "MB\n";
            //            tileItemElement1.Text += "Dung lượng pin: " + ch.DungLuongPin + " mAh\n";
            //        }

            //        MatHang mh = new MatHang();
            //        mh.MaMatHang = data.Rows[i].ItemArray[0].ToString();
            //        DataTable dt3 = _MatHangBLT.LayThongTinDonGiaVaNhaSanXuat(mh);
            //        decimal giatien = 0;
            //        if (dt3 != null && dt3.Rows.Count > 0)
            //        {
            //            giatien = Convert.ToDecimal(dt3.Rows[0].ItemArray[5].ToString());
            //        }
            //        tileItemElement1.Text += "Giá: " + giatien.ToString("0.00").Replace(".00", "") + " VNĐ\n";
            //    }

            //    tileItem1.Name = tileItemElement1.Text;
            //    tileItem1.Elements.Add(tileItemElement1);
            //    this.tileGroup1.Items.Add(tileItem1);
            //}
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            timKiem();
        }

        private void tbnTenSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                timKiem();
        }

        private void cbbNhaSanXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                timKiem();
        }

        private void cbbLoaiSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                timKiem();
        }
    }
}
