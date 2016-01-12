using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DataAccessTier;
using DataTransferObject;
using System.Data.SqlClient;

namespace BusinessLogicTier
{
    public class KhachHangBUS
    {
        private KhachHangDAL khDAL;

        public KhachHangBUS()
        {
            this.khDAL = new KhachHangDAL();
        }
        public DataTable LayDanhSachKhachHang()
        {
            
            try
            {
                return this.khDAL.LayDanhSachKhachHang();
                
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public bool ThemKhachHang(KhachHang kh)
        {
            try
            {
                return this.khDAL.ThemKhachHang(kh);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatKhachHang(KhachHang kh)
        {
            try
            {
                return this.khDAL.CapNhatKhachHang(kh);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return false;
        }

        public bool XoaKhachHang(String maKhachHang)
        {
            try
            {
                return this.khDAL.XoaKhachHang(maKhachHang);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return false;

        }

        public DataTable TimKiemKhachHang(KhachHang kh)
        {
            try
            {
                return this.khDAL.TimKiemKhachHang(kh);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }
    }
}
