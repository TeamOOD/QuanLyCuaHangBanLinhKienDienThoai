using DataTransferObject;
using DataAccessTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{
   public class ChiTietHoaDonBanBUS
    {
        private ChiTietHoaDonBanDAL hoaDonDAL;

        public ChiTietHoaDonBanBUS()
        {
            this.hoaDonDAL = new ChiTietHoaDonBanDAL();
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

        public bool ThemhoaDon(ChiTietHoaDonBan hoaDon)
        {
            try
            {
                return this.hoaDonDAL.ThemHoaDon(hoaDon);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhathoaDon(ChiTietHoaDonBan hoaDon)
        {
            try
            {
                return this.hoaDonDAL.CapNhatHoaDon(hoaDon);
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

        public DataTable TimKiemhoaDon(ChiTietHoaDonBan hoaDon)
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
    }
}
