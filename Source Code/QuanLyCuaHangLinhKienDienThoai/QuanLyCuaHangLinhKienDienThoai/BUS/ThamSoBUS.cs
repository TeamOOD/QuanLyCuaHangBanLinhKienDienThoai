using DataAccessTier;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{
    public class ThamSoBUS
    {
        ThamSoDAL _ThamSoDAL;
        public ThamSoBUS()
        {
            _ThamSoDAL = new ThamSoDAL();
        }
        public bool SuaThamSo(ThamSo thamso)
        {
            return _ThamSoDAL.SuaThamSo(thamso);
        }

        public string LayGiaTriThamSo(ThamSo thamso)
        {
            return _ThamSoDAL.LayGiaTriThamSo(thamso);
        }
    }
}
