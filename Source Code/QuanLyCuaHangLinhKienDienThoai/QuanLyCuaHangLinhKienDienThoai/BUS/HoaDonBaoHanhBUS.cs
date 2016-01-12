using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataTransferObject;
using DataAccessTier;
using System.Xml.Linq;

namespace BusinessLogicTier
{
    public class HoaDonBaoHanhBUS
    {
        private HoaDonBaoHanhDAL hdbhDAL;
        public HoaDonBaoHanhBUS()
        {
            hdbhDAL = new HoaDonBaoHanhDAL();
        }

        public DataTable LayDanhSachHoaDonBaoHanh()
        {
            try
            {
                return this.hdbhDAL.LayDanhSachHoaDonBaoHanh();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayDanhSachTrangThai()
        {
            try
            {
                return this.hdbhDAL.LayDanhSachTrangThai();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayDanhSachKhachHang()
        {
            try
            {
                return this.hdbhDAL.LayDanhSachKhachHang();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public bool ThemHoaDonBaoHanh(HoaDonBaoHanh hdbh, XElement xml)
        {
            try
            {
                return this.hdbhDAL.ThemHoaDonBaoHanh(hdbh,xml);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatHoaDonBaoHanh(HoaDonBaoHanh hdbh, XElement xml)
        {
            try
            {
                return this.hdbhDAL.CapNhatHoaDonBaoHanh(hdbh, xml);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return false;
        }

        public bool XoaHoaDonBaoHanh(String mahdbh)
        {
            try
            {
                return this.hdbhDAL.XoaHoaDonBaoHanh(mahdbh);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return false;
        }

        public DataTable TimKiemHoaDonBaoHanh(HoaDonBaoHanh hdbh)
        {
            try
            {
                return this.hdbhDAL.TimKiemHoaDonBaoHanh(hdbh);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public DataTable TimKiemCTHoaDonBaoHanh(HoaDonBaoHanh hdbh)
        {
            try
            {
                return this.hdbhDAL.TimKiemCTHoaDonBaoHanh(hdbh);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }
    }
}
