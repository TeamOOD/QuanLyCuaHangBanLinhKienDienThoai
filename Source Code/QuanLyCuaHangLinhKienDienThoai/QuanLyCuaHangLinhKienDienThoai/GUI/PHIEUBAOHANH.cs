using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier;

namespace QuanLyCuaHangLinhKienDienThoai.GUI
{
    public partial class PHIEUBAOHANH : MetroFramework.Forms.MetroForm
    {
        CPUBUS cpu;
        public PHIEUBAOHANH()
        {
            InitializeComponent();
            cpu = new CPUBUS();
        }

        private void PHIEUBAOHANH_Load(object sender, EventArgs e)
        {
            dtPhieuBaoHanh.DataSource = cpu.LayDanhSachCPU();
        }
    }
}
