using DataAccessTier;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLogicTier
{
    public class LePhiGiaoHangBUS
    {
        private LePhiGiaoHangDAL lePhiGiaoHangDAL;

        public LePhiGiaoHangBUS()
        {
            this.lePhiGiaoHangDAL = new LePhiGiaoHangDAL();
        }

        public DataTable LayDanhSachLePhiGiaoHang()
        {
            DataTable data = new DataTable();
            try
            {
                data = this.lePhiGiaoHangDAL.LayDanhSachLePhiGiaoHang();
                return data;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool ThemLePhiGiaoHang(LePhiGiaoHang lp)
        {
            try
            {
                return this.lePhiGiaoHangDAL.ThemLePhiGiaoHang(lp);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatLePhiGiaoHang(LePhiGiaoHang lp)
        {

            try
            {
                return this.lePhiGiaoHangDAL.CapNhatLePhiGiaoHang(lp);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool XoaLePhiGiaoHang(String maLephi)
        {

            try
            {
                return this.lePhiGiaoHangDAL.XoaLePhiGiaoHang(maLephi);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public DataTable TimKiemLePhiGiaoHang(LePhiGiaoHang lp)
        {
            try
            {
                return this.lePhiGiaoHangDAL.TimKiemLePhiGiaoHang(lp);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }      
    }
}
