using DataAccessTier;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{
    public class BaoCaoNhapHangBUS
    {
        private BaoCaoNhapHangDAL _BaoCaoNhapHangDAL;

        public BaoCaoNhapHangBUS()
        {
            _BaoCaoNhapHangDAL = new BaoCaoNhapHangDAL();
        }

        public DataTable LayChiTietBaoCao(BaoCaoNhapHang bc)
        {
            return _BaoCaoNhapHangDAL.LayChiTietBaoCao(bc);
        }
    }
}
