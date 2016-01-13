using System;
using System.Data;
using BusinessLogicTier;
using DataTransferObject;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangLinhKienDienThoai.GUI
{
    public partial class THEMSANPHAM : MetroFramework.Forms.MetroForm
    {
        private MatHangBUS matHangBUS;
        private MatHang matHang;

        public THEMSANPHAM()
        {
            InitializeComponent();

            this.groupCauHinhDT.Enabled = true;
            this.matHangBUS = new MatHangBUS();
            LoadData();

            //max lengh text box
            this.tbnTenSanPham.MaxLength = 100;
            this.tbnThoiGianBaoHanh.MaxLength = 5;
            this.tbnGhiChu.MaxLength = 200;
            this.tbnGhiChuNCC.MaxLength = 200;
            this.tbnMoTa.MaxLength = 1000;

            this.tbnKichThuocManHinh.MaxLength = 4;
            this.tbnHeDieuHanh.MaxLength = 50;
            this.tbnRam.MaxLength = 5;
            this.tbnDungLuongPin.MaxLength = 5;

            this.tbnBoNho.MaxLength = 5;
            this.tbnSoSim.MaxLength = 5;

            //chỉ được nhập số
        }

        private void LoadData()
        {
            //load nhà sx
            DataTable table = (new NhaSanXuatBUS().LoadComBoBox());
            this.cbbNhaSanXuat.DisplayMember = "TenNSX";
            this.cbbNhaSanXuat.ValueMember = "MaNSX";
            this.cbbNhaSanXuat.DataSource = table;

            //ConboBox LoaiMatHang
            table = (new LoaiMatHangBUS().LoadComBoBox());
            this.cbbLoaiSanPham.DataSource = table;
            this.cbbLoaiSanPham.DisplayMember = "TenLoaiMatHang";
            this.cbbLoaiSanPham.ValueMember = "MaLoaiMatHang";

            //nhà cung cấp
            table = (new NhaCungCapBUS().LoadComBoBox());
            this.cbbNhaCC.DataSource = table;
            this.cbbNhaCC.DisplayMember = "TenNhaCungCap";
            this.cbbNhaCC.ValueMember = "MaNhaCungCap";

            //CPU
            table = (new CPUBUS().LoadComBoBox());
            this.cbbCPU.DataSource = table;
            this.cbbCPU.DisplayMember = "TenCPU";
            this.cbbCPU.ValueMember = "MaCPU";

            //màu sắc
            table = (new MauSacBUS().LoadComBoBox());
            this.cbbMau.DataSource = table;
            this.cbbMau.DisplayMember = "TenMau";
            this.cbbMau.ValueMember = "MaMau";

            if (StaticVariables.gMatHang != null)
            {
                matHang = StaticVariables.gMatHang;

                this.tbnTenSanPham.Text = matHang.TenMatHang;
                this.cbbLoaiSanPham.SelectedValue = new LoaiMatHangBUS().LayMaLoaiMatHang(matHang.MaLoaiMatHang);
                this.cbbNhaSanXuat.SelectedValue = new NhaSanXuatBUS().LayMaNhaSanXuat(matHang.MaNhaSanXuat);

                this.tbnThoiGianBaoHanh.Text = matHang.ThoiGianBaoHanh.ToString();
                this.tbnMoTa.Text = matHang.MoTa;
                this.tbnGhiChu.Text = matHang.GhiChu;

                CauHinhDienThoai cauHinhDT = new CauHinhDienThoai();
                cauHinhDT = new CauHinhDienThoaiBUS().LayCauHinhByMaMatHang(matHang.MaMatHang);

                this.tbnKichThuocManHinh.Text = cauHinhDT.KichThuocManHinh.ToString();
                this.tbnHeDieuHanh.Text = cauHinhDT.HeDieuHanh;
                this.tbnRam.Text = cauHinhDT.Ram.ToString();
                this.cbbMau.SelectedValue = cauHinhDT.MaMauSac;
                this.tbnDungLuongPin.Text = cauHinhDT.DungLuongPin.ToString();
                this.cbbCPU.SelectedValue = cauHinhDT.MaCPU;
                this.tbnBoNho.Text = cauHinhDT.BoNho.ToString();
                this.tbnSoSim.Text = cauHinhDT.SoSim.ToString();

                this.cbbNhaCC.SelectedValue = new NhaCungCapBUS().LayMaCCBangMaSanPham(matHang.MaMatHang);
                this.tbnGhiChuNCC.Text = new NhaCungCapBUS().LayGhiChuBangMaSanPham(matHang.MaMatHang);

                DonGia donGia = new DonGia();
                donGia = new DonGiaBUS().LayDonGiaBangMaSanPham(matHang.MaMatHang);

                this.tbnGiaNhap.Text = donGia.GiaNhap.ToString();
                this.tbnGiaXuat.Text = donGia.GiaXuat.ToString();

                //Load hình
                HinhAnhBUS _HinhAnhBLT = new HinhAnhBUS();
                DataTable dt = _HinhAnhBLT.LayHinhMatHang(matHang.MaMatHang);
                if (dt != null && dt.Rows.Count > 0)
                {
                    this.pbHinhAnh.Image = ConvertImage.Base64ToImage(dt.Rows[0].ItemArray[0].ToString());
                    pbHinhAnh.Invalidate();
                }
            }
        }
        private void THEMSANPHAM_Load(object sender, EventArgs e)
        {
            
        }

        private void pbHinhAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Chọn Hình";
            openFileDialog1.FileName = "HinhAnh.png";
            openFileDialog1.Filter = "Portable Network Graphics(*.png)|*.png|Joint Photographic Experts Group (*.jpg)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(openFileDialog1.FileName);
                if (img.Height <= 1500 && img.Width <= 1500)
                {
                    this.pbHinhAnh.Image = img;
                }
                else
                {
                    MessageBox.Show("Kích thước ảnh lớn hơn quy định \nQuy định dài <= 1500 và rộng <= 1500", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbbLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Is Dienthoai
            if (this.cbbLoaiSanPham.SelectedValue.ToString().Equals("LMH000000000001"))
            {
                this.groupCauHinhDT.Enabled = true;

            }
            else
            {
                this.groupCauHinhDT.Enabled = false;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.tbnTenSanPham.Text = "";
            this.cbbLoaiSanPham.SelectedIndex = 0;
            this.cbbNhaSanXuat.SelectedIndex = 0;

            // this.teSoLuongTon.Text = "";
            this.tbnThoiGianBaoHanh.Text = "";
            this.tbnMoTa.Text = "";
            this.tbnGhiChu.Text = "";

            this.tbnKichThuocManHinh.Text = "";
            this.tbnHeDieuHanh.Text = "";
            this.tbnRam.Text = "";
            this.cbbMau.SelectedIndex = 0;
            this.tbnDungLuongPin.Text = "";
            this.cbbCPU.SelectedIndex = 0;
            this.tbnBoNho.Text = "";
            this.tbnSoSim.Text = "";

            this.cbbNhaCC.SelectedIndex = 0;
            this.tbnGhiChuNCC.Text = "";

            this.tbnGiaNhap.Text = "";
            this.tbnGiaXuat.Text = "";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //Mat Hang
            HinhAnh hinh = new HinhAnh();
            MatHang mh = new MatHang();

            hinh.NoiDungHinhAnh = ConvertImage.ImageToBase64(pbHinhAnh.Image);
            if (this.tbnTenSanPham.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống tên sản phẩm");
                return;
            }

            mh.TenMatHang = this.tbnTenSanPham.Text;

            if (this.cbbLoaiSanPham.SelectedValue == null)
            {
                MessageBox.Show("Không được để trống loại sản phẩm");
                return;
            }

            mh.MaLoaiMatHang = this.cbbLoaiSanPham.SelectedValue == null ? "" : this.cbbLoaiSanPham.SelectedValue.ToString();

            if (this.cbbNhaSanXuat.SelectedValue == null)
            {
                MessageBox.Show("Không được để trống tên nhà sản xuất");
                return;
            }

            mh.MaNhaSanXuat = this.cbbNhaSanXuat.SelectedValue == null ? "" : this.cbbNhaSanXuat.SelectedValue.ToString();

            
            if (this.tbnThoiGianBaoHanh.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống thời gian bảo hành");
                return;
            }

            mh.ThoiGianBaoHanh = Convert.ToInt32(this.tbnThoiGianBaoHanh.Text);

            ThamSo ts = new ThamSo();
            ts.TenThamSo = "ThoiGianBaoHanhToiThieu";
            int tgBaoHanhNhoNhat = (int)Convert.ToDecimal(new ThamSoBUS().LayGiaTriThamSo(ts));
            if (mh.ThoiGianBaoHanh < tgBaoHanhNhoNhat)
            {
                MessageBox.Show("Thời gian bảo hành không được nhỏ hơn " + tgBaoHanhNhoNhat.ToString() + " tháng");
                return;
            }

            mh.MoTa = this.tbnMoTa.Text;
            mh.GhiChu = this.tbnGhiChu.Text;


            //Nha Cung cap
            string maNhaCC = "";
            string ghiChuNhaCC = "";

            if (this.cbbNhaCC.SelectedValue == null)
            {
                MessageBox.Show("Không được để trống nhà cung cấp");
                return;
            }

            maNhaCC = this.cbbNhaCC.SelectedValue == null ? "" : this.cbbNhaCC.SelectedValue.ToString();

            ghiChuNhaCC = this.tbnGhiChuNCC.Text;

            //Don Gia
            DonGia dg = new DonGia();

            if (this.tbnGiaNhap.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống giá nhập");
                return;
            }

            dg.GiaNhap = Convert.ToDecimal(this.tbnGiaNhap.Text);

            if (this.tbnGiaXuat.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống giá xuất");
                return;
            }

            dg.GiaXuat = Convert.ToDecimal(this.tbnGiaXuat.Text);

            // Cau Hinh Dien Thoai

            CauHinhDienThoai chdt = new CauHinhDienThoai();

            //Mobile
            if (this.groupCauHinhDT.Enabled == true)
            {
                if (this.tbnKichThuocManHinh.Text.Equals(""))
                {
                    MessageBox.Show("Không được để trống kích thước màn hình");
                    return;
                }


                chdt.KichThuocManHinh = Convert.ToDecimal(this.tbnKichThuocManHinh.Text);
                ts = new ThamSo();
                ts.TenThamSo = "KichThuocManHinhToiThieu";
                decimal kichThuocManHinhToiThieu = Convert.ToDecimal(new ThamSoBUS().LayGiaTriThamSo(ts));
                if (chdt.KichThuocManHinh < kichThuocManHinhToiThieu)
                {
                    MessageBox.Show("Kích thước màn hình không được nhỏ hơn " + kichThuocManHinhToiThieu.ToString() + " Inch");
                    return;
                }

                chdt.HeDieuHanh = this.tbnHeDieuHanh.Text;
                chdt.Ram = this.tbnRam.Text == "" ? 1 : Convert.ToInt32(this.tbnRam.Text);

                chdt.MaMauSac = this.cbbMau.SelectedValue == null ? "" : this.cbbMau.SelectedValue.ToString();

                chdt.DungLuongPin = this.tbnDungLuongPin.Text == "" ? 1 : Convert.ToInt32(this.tbnDungLuongPin.Text);
                chdt.MaCPU = this.cbbCPU.SelectedValue == null ? "" : this.cbbCPU.SelectedValue.ToString();
                chdt.BoNho = this.tbnBoNho.Text == "" ? 1 : Convert.ToInt32(this.tbnBoNho.Text);
                chdt.SoSim = this.tbnSoSim.Text == "" ? 1 : Convert.ToInt32(this.tbnSoSim.Text);

            }
            else// Other SP
            {
                // do nothing
            }


            if (StaticVariables.gMatHang != null)//Update
            {
                mh.MaMatHang = StaticVariables.gMatHang.MaMatHang;
                if (this.matHangBUS.CapNhatMatHang(mh, chdt, maNhaCC, ghiChuNhaCC, dg, hinh))
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Cập nhật sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK);
                }

            }
            else//Add
            {
                if (this.matHangBUS.ThemMatHang(mh, chdt, maNhaCC, ghiChuNhaCC, dg, hinh))
                {
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }

        }
    }
}
