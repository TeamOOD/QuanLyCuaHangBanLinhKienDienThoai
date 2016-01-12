using DataTransferObject;
using DataAccessTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLogicTier
{
   public class HoaDonBanBUS
    {
        private HoaDonBanDAL hoaDonDAL;

        public HoaDonBanBUS()
        {
            this.hoaDonDAL = new HoaDonBanDAL();
        }

        public DataTable LayDanhSachhoaDon()
        {         
            try
            {
                return this.hoaDonDAL.LayDanhSachHoaDon();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayDanhSachKhachHang()
        {
            try
            {
                return this.hoaDonDAL.LayDanhSachKhachHang();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayDanhSachTrangThai()
        {
            try
            {
                return this.hoaDonDAL.LayDanhSachTrangThai();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool ThemhoaDon(HoaDonBan hoaDon, XElement xml)
        {
            try
            {
                return this.hoaDonDAL.ThemHoaDon(hoaDon, xml);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhathoaDon(HoaDonBan hoaDon, XElement xml)
        {
            try
            {
                return this.hoaDonDAL.CapNhatHoaDon(hoaDon, xml);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool XoahoaDon(String mahoaDon)
        {
            try
            {
                return this.hoaDonDAL.XoaHoaDon(mahoaDon);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public DataTable TimKiemhoaDon(HoaDonBan hoaDon)
        {
            try
            {
                return this.hoaDonDAL.TimKiemHoaDon(hoaDon);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable TimKiemCThoaDon(HoaDonBan hoaDon)
        {
            try
            {
                return this.hoaDonDAL.TimKiemCTHoaDon(hoaDon);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable TimKiemCThoaDonBH(HoaDonBan hoaDon)
        {
            try
            {
                return this.hoaDonDAL.TimKiemCTHoaDonBH(hoaDon);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
