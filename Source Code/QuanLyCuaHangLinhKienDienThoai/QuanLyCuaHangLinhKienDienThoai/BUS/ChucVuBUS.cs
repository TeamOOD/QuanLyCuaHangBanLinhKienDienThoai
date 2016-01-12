using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using System.Data;

namespace BusinessLogicTier
{
   public class ChucVuBUS
    {
        private ChucVuDAL chucVuDAL;

        public ChucVuBUS()
        {
            this.chucVuDAL = new ChucVuDAL();
        }

        public DataTable LoadComBoBox()
        {          
            try
            {
                return this.chucVuDAL.LoadComboBox();              
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
