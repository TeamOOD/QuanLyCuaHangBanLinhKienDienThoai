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
    public class NhaSanXuatBUS
    {
          private NhaSanXuatDAL nhaSXDAL;

          public NhaSanXuatBUS()
        {
            this.nhaSXDAL = new NhaSanXuatDAL();
        }

          public string LayMaNhaSanXuat(string tenNhaSX)
          {
              try
              {
                  return this.nhaSXDAL.LayMaNhaSanXuat(tenNhaSX);
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
                  return this.nhaSXDAL.LoadComboBox();
              }
              catch (System.Exception ex)
              {
                  Console.WriteLine("Message= {1}", ex.Message);
              }
              return null;
          }

          public DataTable LayDanhSachNhaSanXuat()
        {
            DataTable data = new DataTable();
            try
            {
                data = this.nhaSXDAL.LayDanhSachNhaSanXuat();
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

          public bool ThemNhaSanXuat(NhaSanXuat nhaSX)
        {
            try
            {
                return this.nhaSXDAL.ThemNhaSanXuat(nhaSX);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

          public bool CapNhatNhaSanXuat(NhaSanXuat nhaSX)
        {

            try
            {
                return this.nhaSXDAL.CapNhatNhaSanXuat(nhaSX);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

          public bool XoaNhaSanXuat(String maNhaSX)
        {

            try
            {
                return this.nhaSXDAL.XoaNhaSanXuat(maNhaSX);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

          public DataTable TimKiemNhaSanXuat(NhaSanXuat nhaSX)
        {
            try
            {
                return this.nhaSXDAL.TimKiemNhaSanXuat(nhaSX);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
