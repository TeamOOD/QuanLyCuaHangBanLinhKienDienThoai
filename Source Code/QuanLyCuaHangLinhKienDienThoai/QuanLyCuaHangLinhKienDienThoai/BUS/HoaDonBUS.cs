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
    public class HoaDonBUS
    {
        private HoaDonDAL _HoaDonDAL;
        public HoaDonBUS()
        {
            _HoaDonDAL = new HoaDonDAL();
        }

        public bool ThemHoaDon(HoaDon hd)
        {
            return _HoaDonDAL.ThemHoaDon(hd);
        }
    }
}
