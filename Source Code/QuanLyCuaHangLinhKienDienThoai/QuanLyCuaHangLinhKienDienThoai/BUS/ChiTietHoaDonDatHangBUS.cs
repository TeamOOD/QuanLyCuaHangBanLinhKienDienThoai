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
    public class ChiTietHoaDonDatHangBUS
    {
        private ChiTietHoaDonDatHangDAL _ChiTietHoaDonDatHangDAL;
        public ChiTietHoaDonDatHangBUS()
        {
            _ChiTietHoaDonDatHangDAL = new ChiTietHoaDonDatHangDAL();
        }

        public bool ThemChiTietHoaDonDatHang(ChiTietHoaDonDatHang cthd)
        {
            return _ChiTietHoaDonDatHangDAL.ThemChiTietHoaDonDatHang(cthd);
        }

        public DataTable LayChiTietHoaDonDatHangTheoMaHoaDon(string mahoadon)
        {
            return _ChiTietHoaDonDatHangDAL.LayChiTietHoaDonDatHangTheoMaHoaDon(mahoadon);
        }

        public bool XoaChiTietHoaDonDathang(string MaHoaDon)
        {
            return _ChiTietHoaDonDatHangDAL.XoaChiTietHoaDonDathang(MaHoaDon);
        }
    }
}
