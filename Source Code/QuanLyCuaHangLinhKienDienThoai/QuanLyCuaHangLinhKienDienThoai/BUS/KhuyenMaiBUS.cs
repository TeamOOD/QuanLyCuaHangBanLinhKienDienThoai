using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using System.Data;
using DataTransferObject;
using System.Xml.Linq;

namespace BusinessLogicTier
{
    public class KhuyenMaiBUS
    {
         private KhuyenMaiDAL khuyenMaiDAL;

         public KhuyenMaiBUS()
        {
            this.khuyenMaiDAL = new KhuyenMaiDAL();
        }

        public DataTable LayDanhSachCTKhuyenMai()
        {
            DataTable data = new DataTable();
            try
            {
                data = this.khuyenMaiDAL.LayDanhSachCTKhuyenMai();          
                return data;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayDanhSachChiTietKhuyenMai()
        {
            DataTable data = new DataTable();
            try
            {
                data = this.khuyenMaiDAL.LayDanhSachChiTietKhuyenMai();
                return data;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }


        public bool ThemCTKhuyenMai(KhuyenMai km, XElement xml)
        {
            try
            {
                return this.khuyenMaiDAL.ThemCTKhuyenMai(km, xml);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatCTKhuyenMai(KhuyenMai km, XElement xml)
        {

            try
            {
                return this.khuyenMaiDAL.CapNhatCTKhuyenMai(km, xml);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatCTSoLuongKhuyenMai(CTKHuyenMai km)
        {
            try
            {
                return this.khuyenMaiDAL.CapNhatCTSoLuongKhuyenMai(km);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool XoaCTKhuyenMai(String maKhuyenMai)
        {

            try
            {
                return this.khuyenMaiDAL.XoaCTKhuyenMai(maKhuyenMai);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public DataTable TimKiemCTKhuyenMai(KhuyenMai km)
        {
            try
            {
                return this.khuyenMaiDAL.TimKiemCTKhuyenMai(km);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
        public DataTable TimKiemChiTietCTKhuyenMai(CTKHuyenMai km)
        {
            try
            {
                return this.khuyenMaiDAL.TimKiemChiTietKhuyenMai(km);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

    }
}
