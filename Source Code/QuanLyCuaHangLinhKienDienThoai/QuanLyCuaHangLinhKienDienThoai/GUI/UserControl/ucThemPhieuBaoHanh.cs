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
using System.Xml.Linq;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;



namespace QuanLyCuaHangLinhKienDienThoai.UserControl
{
    public partial class ucThemPhieuBaoHanh : DevExpress.XtraEditors.XtraUserControl
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
        public ucThemPhieuBaoHanh()
        {
            InitializeComponent();

            this.hoaDonBaoHanhBUS = new HoaDonBaoHanhBUS();
            this.leTrangThai.Properties.DataSource = (new HoaDonBaoHanhBUS().LayDanhSachTrangThai());
            this.leTrangThai.Properties.Columns.Add(new LookUpColumnInfo(this.leTrangThai.Properties.DisplayMember));

            this.LoadData();
        }

        private void sbLuu_Click(object sender, EventArgs e)
        {
            HoaDonBaoHanh hd = new HoaDonBaoHanh();
            hd.HoaDon.MaHoaDon = this.maHD;
            hd.HoaDonBan.HoaDon.MaHoaDon = this.teMaHoaDon.Text;

            hd.KhachHang.MaKhachHang = this.teMaKhachHang.EditValue == null ? "" : this.teMaKhachHang.EditValue.ToString();
            hd.HoaDon.TrangThai.MaTrangThai = this.leTrangThai.EditValue == null ? "" : this.leTrangThai.EditValue.ToString();



            hd.KhachHang.TenKhachHang = this.teTenKhachHang.Text;
            hd.HoaDon.NhanVien.TenNhanVien = this.teTenNhanVien.Text;
            hd.HoaDon.NhanVien.MaNhanVien = this.teMaNhanVien.Text;
            hd.HoaDon.NgayLap = this.deThoiGianLap.DateTime.ToString("dd/MM/yyyy");
            hd.HoaDon.GhiChu = this.meGhiChu.Text;

            if (hd.KhachHang.TenKhachHang.Equals(""))
            {
                XtraMessageBox.Show("Tên Khách hàng không được bỏ trống. ", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (this.gridSpBH.RowCount == 0)
            {
                XtraMessageBox.Show("Danh sách sản phẩm bảo hành không được để trống. ", "Thông báo", MessageBoxButtons.OK);
                return;
            }



            if (hd.KhachHang.TenKhachHang.Equals(""))
            {
                XtraMessageBox.Show("Yêu cầu nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            XElement xlmData;
            this.ConvertDataToXML(out xlmData);
            if (StaticVariables.gHoaDonBaoHanh == null)
            {
                if (xlmData != null)
                {
                    if (new HoaDonBaoHanhBUS().ThemHoaDonBaoHanh(hd, xlmData))
                    {
                        XtraMessageBox.Show("Thêm phiếu bảo hành thành công", "Thông báo", MessageBoxButtons.OK);
                        this.LoadData();
                    }
                    else
                    {
                        XtraMessageBox.Show("Thêm phiếu bảo hành thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                if (xlmData != null)
                {
                    if (new HoaDonBaoHanhBUS().CapNhatHoaDonBaoHanh(hd, xlmData))
                    {
                        XtraMessageBox.Show("Cập nhật phiếu hoá đơn thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        XtraMessageBox.Show("Cập nhật phiếu bảo hành thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Mã sản phẩm"));
            dt.Columns.Add(new DataColumn("Tên sản phẩm"));
            dt.Columns.Add(new DataColumn("Số lượng"));
            this.gridSanPhamBH.DataSource = (dt);


            this.deThoiGianLap.DateTime = DateTime.Now;
            this.teMaNhanVien.Text = StaticVariables.nhanVien.MaNhanVien;
            this.teTenNhanVien.Text = StaticVariables.nhanVien.TenNhanVien;

            if (StaticVariables.gHoaDonBaoHanh != null)
            {
                this.maHD = StaticVariables.gHoaDonBaoHanh.HoaDon.MaHoaDon;
                this.teMaHoaDon.Text = StaticVariables.gHoaDonBaoHanh.HoaDonBan.HoaDon.MaHoaDon;
                this.deThoiGianLap.Text = StaticVariables.gHoaDonBaoHanh.HoaDon.NgayLap;
                this.teMaKhachHang.Text = StaticVariables.gHoaDonBaoHanh.KhachHang.MaKhachHang;
                this.leTrangThai.EditValue = StaticVariables.gHoaDonBaoHanh.HoaDon.TrangThai.MaTrangThai;
                this.teTenKhachHang.Text = StaticVariables.gHoaDonBaoHanh.KhachHang.TenKhachHang;
                this.teMaNhanVien.Text = StaticVariables.gHoaDonBaoHanh.HoaDon.NhanVien.MaNhanVien;
                this.teTenNhanVien.Text = StaticVariables.gHoaDonBaoHanh.HoaDon.NhanVien.TenNhanVien;
                this.meGhiChu.Text = StaticVariables.gHoaDonBaoHanh.HoaDon.GhiChu;


                this.gridSanPham.DataSource = (new HoaDonBanBUS().TimKiemCThoaDon(StaticVariables.gHoaDonBaoHanh.HoaDonBan));

                this.gridSanPhamBH.DataSource = (new HoaDonBaoHanhBUS().TimKiemCTHoaDonBaoHanh(StaticVariables.gHoaDonBaoHanh));

            }
            else
            {
                this.sbLamMoi_Click(null, null);
            }
        }

        private void ConvertDataToXML(out XElement XML)
        {
            List<HoaDonBaoHanh> lstHoaDonBaoHanh = new List<HoaDonBaoHanh>();

            XML = new XElement(new XElement("Root"));
            for (int i = 0; i < gridSpBH.RowCount; i++)
            {
                HoaDonBaoHanh temp = new HoaDonBaoHanh();
                temp.CtHoaDonBH.MatHang.MaMatHang = gridSpBH.GetRowCellValue(i, "Mã sản phẩm").ToString();
                temp.CtHoaDonBH.MatHang.TenMatHang = gridSpBH.GetRowCellValue(i, "Tên sản phẩm").ToString();
                temp.CtHoaDonBH.SoLuong = Convert.ToInt32(gridSpBH.GetRowCellValue(i, "Số lượng"));

                lstHoaDonBaoHanh.Add(temp);
            }

            foreach (HoaDonBaoHanh item in lstHoaDonBaoHanh)
            {
                XElement xml = new XElement("XmlData",
                    new XElement("MaCTHoaDonBaoHanh", item.CtHoaDonBH.MaCTHoaDonBaoHanh == null ? "" : item.CtHoaDonBH.MaCTHoaDonBaoHanh),
                    new XElement("MaMatHang", item.CtHoaDonBH.MatHang.MaMatHang == null ? "" : item.CtHoaDonBH.MatHang.MaMatHang),
                    new XElement("TenMatHang", item.CtHoaDonBH.MatHang.TenMatHang == null ? "" : item.CtHoaDonBH.MatHang.TenMatHang),
                    new XElement("SoLuong", item.CtHoaDonBH.SoLuong == null ? Decimal.Zero : item.CtHoaDonBH.SoLuong)
                    );
                XML.Add(xml);
            }
        }

        private void sbLm_Click(object sender, EventArgs e)
        {
            teMaHoaDon.Text = "";
            deThoiGianLap.EditValue = DateTime.Now;
            teMaKhachHang.Text = "";
            teTenKhachHang.Text = "";
            leTrangThai.Text = "";
            meGhiChu.Text = "";
            teSoLuong.Text = "";
        }

        private void gridViewSp_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.maSP = gridViewSp.GetRowCellValue(gridViewSp.FocusedRowHandle, "Mã sản phẩm").ToString();
                this.tenSP = gridViewSp.GetRowCellValue(gridViewSp.FocusedRowHandle, "Tên sản phẩm").ToString();
                this.soLuong = Convert.ToInt32(gridViewSp.GetRowCellValue(gridViewSp.FocusedRowHandle, "Số lượng"));
            }
            catch { }
        }


        private void sbLamMoi_Click(object sender, EventArgs e)
        {
            this.deThoiGianLap.DateTime = DateTime.Now;
            this.teTenNhanVien.Text = StaticVariables.nhanVien.TenNhanVien;
            this.teMaNhanVien.Text = StaticVariables.nhanVien.MaNhanVien;
        }

        private void sbXoa_Click(object sender, EventArgs e)
        {
            gridSpBH.DeleteRow(gridSpBH.FocusedRowHandle);
        }



        private void sbThem_Click(object sender, EventArgs e)
        {
            DataTable dtasd = gridSanPham.DataSource as DataTable;
            if (dtasd != null && dtasd.Rows.Count > 0)
            {
                if (!teSoLuong.Text.Equals(""))
                {
                    this.soLuong = Convert.ToInt32(teSoLuong.Text);
                }
                else
                    this.soLuong = 0;

                Decimal sluong = Convert.ToDecimal(this.gridViewSp.GetRowCellValue(this.gridViewSp.FocusedRowHandle, "Số lượng").ToString());

                if (sluong < this.soLuong)
                {
                    XtraMessageBox.Show("Số lượng sản phẩm được bảo hành phải nhỏ hơn số sản phẩm đã mua!", "Thông báo lỗi", MessageBoxButtons.OK);
                    return;
                }

                int numRows = gridSpBH.RowCount;
                bool isAddExistRow = false;
                int index = 0;
                int slTemp = 0;
                for (int j = 0; j < numRows; j++)
                {
                    String mspTemp = gridSpBH.GetRowCellValue(j, "Mã sản phẩm").ToString();
                    slTemp = Convert.ToInt32(gridSpBH.GetRowCellValue(j, "Số lượng"));
                    if (!maSP.Equals(mspTemp))
                    {

                        isAddExistRow = false;
                    }
                    else
                    {
                        isAddExistRow = true;
                        index = j;
                        break;
                    }

                }

                if (isAddExistRow)
                {
                    gridSpBH.SetRowCellValue(index, "Số lượng", this.soLuong);
                }
                else
                {
                    this.addRow();
                }

                if (gridSpBH.RowCount == 0)
                {
                    this.addRow();
                }
            }
            else
            {
                XtraMessageBox.Show("Danh Sách sản phẩm trống nên không thêm được");
            }
        }

        private void addRow()
        {
            DataTable dt = gridSanPhamBH.DataSource as DataTable;
            DataRow newRow = dt.NewRow();
            newRow.BeginEdit();
            newRow["Mã sản phẩm"] = this.maSP;
            newRow["Tên sản phẩm"] = this.tenSP;
            newRow["Số lượng"] = this.soLuong;
            newRow.EndEdit();
            dt.Rows.Add(newRow);
            gridSanPhamBH.DataSource = dt;
        }

        private void teSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (teSoLuong.Text == "")
                teSoLuong.Text = "0";
            if (Convert.ToDecimal(teSoLuong.Text) < 0)
                teSoLuong.Text = "0";
        }

        private void teMaHoaDon_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (teMaHoaDon.Text.Length == 15)
                {
                    HoaDonBan hd = new HoaDonBan();
                    hd.HoaDon.MaHoaDon = teMaHoaDon.Text;
                    this.gridSanPham.DataSource = (new HoaDonBanBUS().TimKiemCThoaDon(hd));
                }
                else
                    this.gridSanPham.DataSource = null;
            }
            catch
            {
                this.gridSanPham.DataSource = null;
            }
        }

        private void teMaKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (teMaKhachHang.Text.Length == 15)
                {
                    DataTable dt = (new KhachHangBUS().GetTenKHByMaKH(teMaKhachHang.Text));
                    teTenKhachHang.Text = dt.Rows[0][0].ToString();
                }
                else
                    teTenKhachHang.Text = "";
            }
            catch
            {
                teTenKhachHang.Text = "";
            }
        }
    }
}
