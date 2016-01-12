using DataAccessTier;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{
    public class HoaDonNhapHangBUS
    {
        HoaDonNhapHangDAL _HoaDonNhapHangDAL;

        public HoaDonNhapHangBUS()
        {
            _HoaDonNhapHangDAL = new HoaDonNhapHangDAL();
        }
        public object ThemHoaDonNhapHang(HoaDonNhapHang hd)
        {
            return _HoaDonNhapHangDAL.ThemHoaDonNhapHang(hd);
        }
    }
}
