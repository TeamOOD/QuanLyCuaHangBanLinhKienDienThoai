using DataAccessTier;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{
    public class ChiTietHoaDonNhapHangBUS
    {
        ChiTietHoaDonNhapHangDAL _ChiTietHoaDonNhapHangDAL;
        public ChiTietHoaDonNhapHangBUS()
        {
            _ChiTietHoaDonNhapHangDAL = new ChiTietHoaDonNhapHangDAL();
        }

        public bool ThemChiTietHoaDonNhapHang(ChiTietHoaDonNhapHang cthd)
        {
            return _ChiTietHoaDonNhapHangDAL.ThemChiTietHoaDonNhapHang(cthd);
        }
    }
}
