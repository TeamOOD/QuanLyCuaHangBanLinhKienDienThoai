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
    public class DonGiaBUS
    {
         private DonGiaDAL donGiaDAL;

         public DonGiaBUS()
        {
            this.donGiaDAL = new DonGiaDAL();
        }

         public DataTable LayDanhSachDonGia()
        {
            DataTable data = new DataTable();
            try
            {
                data = this.donGiaDAL.LayDanhSachDonGia();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    // data.Rows[i].
                }
                return data;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

         public bool ThemDonGia(DonGia donGia)
        {
            try
            {
                return this.donGiaDAL.ThemDonGia(donGia);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

         public bool CapNhatDonGia(DonGia donGia)
        {

            try
            {
                return this.donGiaDAL.CapNhatDonGia(donGia);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

         public bool XoaDonGia(String maDonGia)
        {

            try
            {
                return this.donGiaDAL.XoaDonGia(maDonGia);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

         public DataTable TimKiemDonGia(DonGia donGia)
        {
            try
            {
                return this.donGiaDAL.TimKiemDonGia(donGia);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

         public DonGia LayDonGiaBangMaSanPham(string maSP)
         {
             DonGia donGia = new DonGia();
             DataTable table;

             try
             {
                 table = this.donGiaDAL.LayDonGiaBangMaSanPham(maSP);

                 foreach (DataRow row in table.Rows)
                 {
                     donGia.MaDonGia = row["MaDonGia"].ToString();
                     donGia.GiaNhap = Convert.ToDecimal(row["GiaNhap"].ToString());
                     donGia.GiaXuat = Convert.ToDecimal(row["GiaXuat"].ToString());
                    
                 }

                 return donGia;
             }
             catch (System.Exception ex)
             {
                 Console.WriteLine("Message= {1}", ex.Message);
             }
             return null;
         }

         public DataTable LayMaDonGiaBangMaSanPham(DonGia dongia)
         {
             try
             {
                 return this.donGiaDAL.LayMaDonGiaBangMaSanPham(dongia);
             }
             catch (System.Exception ex)
             {
                 Console.WriteLine("Message= {1}", ex.Message);
             }
             return null;
         }

         public string ThemDonGiaVaLayMaDonGia(DonGia dongia)
         {
             try
             {
                 return this.donGiaDAL.ThemDonGiaVaLayMaDonGia(dongia);
             }
             catch (System.Exception ex)
             {
                 Console.WriteLine("Message= {1}", ex.Message);
             }
             return null;
         }
    }
}
