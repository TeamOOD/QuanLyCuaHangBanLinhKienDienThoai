using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using System.Data;
using DataTransferObject;
namespace BusinessLogicTier
{
    public class ChiTietBaoCaoTonKhoBUS
    {
        ChiTietBaoCaoTonKhoDAL _ChiTietBaoCaoTonKhoDAL;

        public ChiTietBaoCaoTonKhoBUS()
        {
            _ChiTietBaoCaoTonKhoDAL = new ChiTietBaoCaoTonKhoDAL();
        }

        public DataTable LayChiTietTonKho(string thoigian)
        {
            return _ChiTietBaoCaoTonKhoDAL.LayChiTietTonKho(thoigian);
        }

        public bool ThemChiTietBaoCaoTonKho(ChiTietBaoCaoTonKho ct)
        {
            return _ChiTietBaoCaoTonKhoDAL.ThemChiTietBaoCaoTonKho(ct);
        }

        public bool XoaChiTietBaoCaoTonKho(string mabaocao)
        {
            return _ChiTietBaoCaoTonKhoDAL.XoaChiTietBaoCaoTonKho(mabaocao);
        }
       
        public DataTable LayThongTinTonKho()
        {
            return _ChiTietBaoCaoTonKhoDAL.LayThongTinTonKho();
        }
    }
}
