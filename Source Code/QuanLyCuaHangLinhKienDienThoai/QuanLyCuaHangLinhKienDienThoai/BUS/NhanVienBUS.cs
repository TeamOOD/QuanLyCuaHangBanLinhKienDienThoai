using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DataTransferObject;
using DataAccessTier;

namespace BusinessLogicTier
{
    public class NhanVienBUS 
    {
        private NhanVienDAL nhanVienDAL;

        public NhanVienBUS()
        {
            this.nhanVienDAL = new NhanVienDAL();
        }

        public NhanVien DangNhap(string taikhoan, string matkhau)
        {
            try
            {
                return this.nhanVienDAL.DangNhap(taikhoan, matkhau);            
            }
            
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
        public DataTable LayDanhSachNhanVien()
        {
            DataTable data = new DataTable();
            try
            {
                data = this.nhanVienDAL.LayDanhSachNhanVien();
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

        public bool ThemNhanVien(NhanVien nhanVien)
        {
            try
            {
                return this.nhanVienDAL.ThemNhanVien(nhanVien);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatNhanVien(NhanVien nhanVien)
        {

            try
            {
                return this.nhanVienDAL.CapNhatNhanVien(nhanVien);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool XoaNhanVien(String maNhanVien)
        {

            try
            {
                return this.nhanVienDAL.XoaNhanVien(maNhanVien);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public DataTable TimKiemNhanVien(NhanVien nhanVien)
        {
            try
            {
                return this.nhanVienDAL.TimKiemNhanVien(nhanVien);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
        
    }
}
