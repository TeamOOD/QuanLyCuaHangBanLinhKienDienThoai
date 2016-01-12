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
    public class HinhAnhBUS
    {
        private HinhAnhDAL _HinhAnhDAL;
        public HinhAnhBUS()
        {
            _HinhAnhDAL = new HinhAnhDAL();
        }
        public bool ThemHinhAnh(HinhAnh hinhanh)
        {
            return _HinhAnhDAL.ThemHinhAnh(hinhanh);
        }
        public bool XoaHinhAnh(HinhAnh hinhanh)
        {
            return _HinhAnhDAL.XoaHinhAnh(hinhanh);
        }
        public DataTable LayHinhMatHang(string mamathang)
        {
            return _HinhAnhDAL.LayHinhMatHang(mamathang);
        }
    }
}
