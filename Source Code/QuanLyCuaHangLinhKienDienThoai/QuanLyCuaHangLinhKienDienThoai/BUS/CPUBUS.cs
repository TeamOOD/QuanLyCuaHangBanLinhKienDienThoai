using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DataAccessTier;
using System.Data;

namespace BusinessLogicTier
{
    public class CPUBUS
    {
         private CPUDAL cpuDAL;

         public CPUBUS()
        {
            this.cpuDAL = new CPUDAL();
        }

         public DataTable LoadComBoBox()
         {
             try
             {
                 return this.cpuDAL.LoadComboBox();
             }
             catch (System.Exception ex)
             {
                 Console.WriteLine("Message= {1}", ex.Message);
             }
             return null;
         }

        public DataTable LayDanhSachCPU()
        {
            DataTable data = new DataTable();
            try
            {
                data = this.cpuDAL.LayDanhSachCPU();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    // data.Rows[i].
                }
                return data;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool ThemCPU(CPU cpu)
        {
            try
            {
                return this.cpuDAL.ThemCPU(cpu);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatCPU(CPU cpu)
        {

            try
            {
                return this.cpuDAL.CapNhatCPU(cpu);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool XoaCPU(String maCPU)
        {

            try
            {
                return this.cpuDAL.XoaCPU(maCPU);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public DataTable TimKiemCPU(CPU cpu)
        {
            try
            {
                return this.cpuDAL.TimKiemCPU(cpu);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
