﻿using DataAccessTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{
    public class BaoCaoBanHangBUS
    {
        private BaoCaoBanHangDAL baoCaoBanHang;

        public BaoCaoBanHangBUS()
        {
            this.baoCaoBanHang = new BaoCaoBanHangDAL();
        }

        public DataTable BaoCaoBanHang(String tuNgay, String denNgay)
        {          
            try
            {
                return this.baoCaoBanHang.BaoCaoBanHang(tuNgay, denNgay);              
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
