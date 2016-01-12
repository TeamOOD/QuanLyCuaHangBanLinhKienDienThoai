using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DataAccessTier;
using System.Data;

namespace BusinessLogicTier
{
    public class MatHangBUS
    {
        MatHangDAL _MatHangDAL;
        LoaiMatHangDAL _loaiMHDAL;
        NhaSanXuatDAL _nhaSXDAL;

        public MatHangBUS() {
            _MatHangDAL = new MatHangDAL();
            _loaiMHDAL = new LoaiMatHangDAL();
            _nhaSXDAL = new NhaSanXuatDAL();
        }

        public DataTable LayDanhSachTenMatHangTheoNhaCungCap(string  MaNhaCungCap, int SoLuongToiThieu)
        {
            return _MatHangDAL.LayDanhSachTenMatHangTheoNhaCungCap(MaNhaCungCap, SoLuongToiThieu);
        }

        public DataTable LayDanhSachMatHang()
        {
            DataTable data = new DataTable();
            try
            {
                data = this._MatHangDAL.LayDanhSachMatHang();
             
                foreach (DataRow row in data.Rows)
                {
                    _loaiMHDAL = new LoaiMatHangDAL();
                    row["Loại mặt hàng"] = _loaiMHDAL.LayTenLoaiMatHang(row["Loại mặt hàng"].ToString());
                    _nhaSXDAL = new NhaSanXuatDAL();
                    row["Nhà sản xuất"] = _nhaSXDAL.LayTenNhaSanXuat(row["Nhà sản xuất"].ToString());
                   
                }
                return data;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayDanhSachMatHangBan()
        {
            DataTable data = new DataTable();
            try
            {
                data = this._MatHangDAL.LayDanhSachMatHangBan();              
                return data;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }


     /*   public DataTable TimKiemMatHang(MatHang matHang, int kichThuoc, string heDieuHanh, string mauSac,
            int pin, int soSim, int ram, int boNho, string maCPU)
        {
            try
            {
                return this._MatHangDAL.TimKiemMatHang(matHang, kichThuoc, heDieuHanh,  mauSac,
                     pin, soSim, ram,boNho, maCPU);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }*/
        public DataTable TimKiemMatHang(MatHang matHang, decimal kichThuoc, string heDieuHanh, string mauSac,
           int pin, int soSim, int ram, int boNho, string maCPU)
        {
            DataTable data = new DataTable();
            try
            {
                data = this._MatHangDAL.TimKiemMatHang(matHang, kichThuoc, heDieuHanh, mauSac,
                     pin, soSim, ram, boNho, maCPU);

                foreach (DataRow row in data.Rows)
                {
                    _loaiMHDAL = new LoaiMatHangDAL();
                    string r2 = row[2].ToString();
                    row[2] = _loaiMHDAL.LayTenLoaiMatHang(r2);
                    _nhaSXDAL = new NhaSanXuatDAL();
                    row[3] = _nhaSXDAL.LayTenNhaSanXuat(row[3].ToString());

                }
                return data;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable TimKiemMatHangBan(MatHang matHang, int kichThuoc, string heDieuHanh, string mauSac,
         int pin, int soSim, int ram, int boNho, string maCPU)
        {
            DataTable data = new DataTable();
            try
            {
                data = this._MatHangDAL.TimKiemMatHangBan(matHang, kichThuoc, heDieuHanh, mauSac,
                     pin, soSim, ram, boNho, maCPU);

                //foreach (DataRow row in data.Rows)
                //{
                //    _loaiMHDAL = new LoaiMatHangDAL();
                //    row["Loại mặt hàng"] = _loaiMHDAL.LayTenLoaiMatHang(row["Loại mặt hàng"].ToString());
                //    _nhaSXDAL = new NhaSanXuatDAL();
                //    row["Nhà sản xuất"] = _nhaSXDAL.LayTenNhaSanXuat(row["Nhà sản xuất"].ToString());

                //}
                return data;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable TimKiemMatHangDonGian(MatHang matHang)
        {
            try
            {
                 return this._MatHangDAL.TimKiemMatHangDonGian(matHang);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool XoaMatHang(String maMatHang)
        {

            try
            {
                return this._MatHangDAL.XoaMatHang(maMatHang);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool ThemMatHang(MatHang matHang, CauHinhDienThoai cauhinh, string maNhaCC,
            string GhiChuNhaCC, DonGia donGia, HinhAnh hinh)
        {
            try
            {
                return this._MatHangDAL.ThemMatHang(matHang, cauhinh,maNhaCC,
            GhiChuNhaCC, donGia, hinh);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatMatHang(MatHang matHang, CauHinhDienThoai cauhinh, string maNhaCC,
           string GhiChuNhaCC, DonGia donGia, HinhAnh hinh)
        {
            try
            {
                return this._MatHangDAL.CapNhatMatHang(matHang, cauhinh, maNhaCC,
            GhiChuNhaCC, donGia, hinh);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public string LayMaMatHangTuTenMatHangVaMaNhaCungCap(MatHang mh)
        {
            try
            {
                DataTable result = _MatHangDAL.LayMaMatHangTuTenMatHangVaMaNhaCungCap(mh);
                if (result != null && result.Rows.Count > 0)
                    return result.Rows[0].ItemArray[0].ToString();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable TimKiemMatHangBangTenMatHangDonGian(MatHang mh)
        {  
            try
            {
                DataTable result = _MatHangDAL.TimKiemMatHangBangTenMatHangDonGian(mh);
                if (result != null && result.Rows.Count > 0)
                    return result;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayThongTinDonGiaVaNhaSanXuat(MatHang mh)
        {  
            try
            {
                DataTable result = _MatHangDAL.LayThongTinDonGiaVaNhaSanXuat(mh);
                if (result != null && result.Rows.Count > 0)
                    return result;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
