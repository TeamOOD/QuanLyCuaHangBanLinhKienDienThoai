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
    public class LoaiMatHangBUS
    {
         private LoaiMatHangDAL loaiMHDAL;

         public LoaiMatHangBUS()
        {
            this.loaiMHDAL = new LoaiMatHangDAL();
        }
         public string LayMaLoaiMatHang(string tenloaiMH)
         {
             try
             {
                 return this.loaiMHDAL.LayMaLoaiMatHang(tenloaiMH);
             }
             catch (System.Exception ex)
             {
                 Console.WriteLine("Message= {1}", ex.Message);
             }

             return null;
         }

         public DataTable LoadComBoBox()
         {
             try
             {
                 return this.loaiMHDAL.LoadComboBox();
             }
             catch (System.Exception ex)
             {
                 Console.WriteLine("Message= {1}", ex.Message);
             }
             return null;
         }

         public DataTable LayDanhSachLoaiMatHang()
        {
            DataTable data = new DataTable();
            try
            {
                data = this.loaiMHDAL.LayDanhSachLoaiMatHang();
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

         public bool ThemLoaiMatHang(LoaiMatHang loaiMH)
        {
            try
            {
                return this.loaiMHDAL.ThemLoaiMatHang(loaiMH);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

         public bool CapNhatLoaiMatHang(LoaiMatHang loaiMH)
        {

            try
            {
                return this.loaiMHDAL.CapNhatLoaiMatHang(loaiMH);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

         public bool XoaLoaiMatHang(String maLoaiMH)
        {

            try
            {
                return this.loaiMHDAL.XoaLoaiMatHang(maLoaiMH);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

         public DataTable TimKiemLoaiMatHang(LoaiMatHang loaiMH)
        {
            try
            {
                return this.loaiMHDAL.TimKiemLoaiMatHang(loaiMH);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
