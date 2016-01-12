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
    public class MauSacBUS
    {
        private MauSacDAL mauSacDAL;

        public MauSacBUS()
        {
            this.mauSacDAL = new MauSacDAL();
        }

        public DataTable LoadComBoBox()
        {
            try
            {
                return this.mauSacDAL.LoadComboBox();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayDanhSachMauSac()
        {
            DataTable data = new DataTable();
            try
            {
                data = this.mauSacDAL.LayDanhSachMauSac();
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

        public bool ThemMauSac(MauSac mauSac)
        {
            try
            {
                return this.mauSacDAL.ThemMauSac(mauSac);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatMauSac(MauSac mauSac)
        {

            try
            {
                return this.mauSacDAL.CapNhatMauSac(mauSac);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool XoaMauSac(String maMauSac)
        {

            try
            {
                return this.mauSacDAL.XoaMauSac(maMauSac);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public DataTable TimKiemMauSac(MauSac mauSac)
        {
            try
            {
                return this.mauSacDAL.TimKiemMauSac(mauSac);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
