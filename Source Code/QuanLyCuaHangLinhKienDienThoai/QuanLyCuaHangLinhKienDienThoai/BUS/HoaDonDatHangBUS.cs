using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using DataTransferObject;
using System.Data;

namespace BusinessLogicTier
{
    public class HoaDonDatHangBUS
    {
        private HoaDonDatHangDAL _HoaDonDatHangDAL;

        public HoaDonDatHangBUS()
        {
            _HoaDonDatHangDAL = new HoaDonDatHangDAL();
        }
        public  object ThemHoaDonDatHang(HoaDonDatHang hd)
        {
            return _HoaDonDatHangDAL.ThemHoaDonDatHang(hd);
        }

        public DataTable LayDanhSachHoaDonDatHang()
        {
            return _HoaDonDatHangDAL.LayDanhSachHoaDonDatHang();
        }

        public bool CapNhatHoaDonDatHang(HoaDonDatHang hd)
        {
            return _HoaDonDatHangDAL.CapNhatHoaDonDatHang(hd);
        }
    }
}
