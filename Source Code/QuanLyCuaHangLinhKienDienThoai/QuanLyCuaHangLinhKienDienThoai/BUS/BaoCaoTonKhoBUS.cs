using DataAccessTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{
    public class BaoCaoTonKhoBUS
    {
        BaoCaoTonKhoDAL _BaoCaoTonKhoDAL;
        public BaoCaoTonKhoBUS()
        {
            _BaoCaoTonKhoDAL = new BaoCaoTonKhoDAL();
        }

        public DataTable LayDanhSachBaoCao()
        {
            return _BaoCaoTonKhoDAL.LayDanhSachBaoCao();
        }

        public object LapBaoCao(string thoigian)
        {
            return _BaoCaoTonKhoDAL.LapBaoCao(thoigian );
        }
        public DataTable LayBaoCaoTheoThoiGian(string thoigian)
        {
            return _BaoCaoTonKhoDAL.LayBaoCaoTheoThoiGian(thoigian);
        }
    }
}
