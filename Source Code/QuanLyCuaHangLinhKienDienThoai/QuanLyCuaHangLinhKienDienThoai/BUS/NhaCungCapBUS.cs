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
   public  class NhaCungCapBUS
    {
        NhaCungCapDAL _NhaCungCapDAL;

        public NhaCungCapBUS()
        {
            this._NhaCungCapDAL = new NhaCungCapDAL();
        }

        public DataTable LoadComBoBox()
        {
            try
            {
                return this._NhaCungCapDAL.LoadComboBox();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable layDanhSachNhaCungCap()
        {
            DataTable data = new DataTable();
            try
            {
                data = this._NhaCungCapDAL.layDanhSachNhaCungCap();
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

        public bool ThemNhaCungCap(NhaCungCap nhaCC)
        {
            try
            {
                return this._NhaCungCapDAL.ThemNhaCungCap(nhaCC);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatNhaCungCap(NhaCungCap nhaCC)
        {

            try
            {
                return this._NhaCungCapDAL.CapNhatNhaCungCap(nhaCC);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool XoaNhaCungCap(String maNhaCC)
        {

            try
            {
                return this._NhaCungCapDAL.XoaNhaCungCap(maNhaCC);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public DataTable TimKiemNhaCungCap(NhaCungCap nhaCC)
        {
            try
            {
                return this._NhaCungCapDAL.TimKiemNhaCungCap(nhaCC);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public string LayMaCCBangMaSanPham(string maSanPham)
        {
            DataTable table;
            string maNhaCC = "";
            try
            {
                table = this._NhaCungCapDAL.LayMaCCBangMaSanPham(maSanPham);

                foreach (DataRow row in table.Rows)
                {
                    maNhaCC = row["MaNhaCungCap"].ToString();  
                }

                return maNhaCC;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public string LayGhiChuBangMaSanPham(string maSanPham)
        {
            DataTable table;
            string ghiChuNhaCC = "";
            try
            {
                table = this._NhaCungCapDAL.LayMaCCBangMaSanPham(maSanPham);

                foreach (DataRow row in table.Rows)
                {
                    ghiChuNhaCC = row["GhiChu"].ToString();
                }

                return ghiChuNhaCC;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public string LayMaNhaCCBangTenNhaCungCap(string tenNhaCungCap)
        {
            DataTable table;
            try
            {
                table = this._NhaCungCapDAL.LayMaNhaCCBangTenNhaCungCap(tenNhaCungCap);
                if (table != null && table.Rows.Count > 0)
                    return table.Rows[0].ItemArray[0].ToString();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool XoaChiTietNhaCungCap(string mamathang)
       {
            try
            {
                return this._NhaCungCapDAL.XoaChiTietNhaCungCap(mamathang);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
       }

       public bool ThemChiTietNhaCungCap(ChiTietNhaCungCap ncc)
        {
            try
            {
                return this._NhaCungCapDAL.ThemChiTietNhaCungCap(ncc);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }
    }
}
