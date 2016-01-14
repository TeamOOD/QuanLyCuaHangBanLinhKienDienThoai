using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace QuanLyCuaHangLinhKienDienThoai
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.UserSkins.BonusSkins.Register();
            
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "The Asphalt World";
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 8);
            Application.Run(new FormDangNhap());
        }
    }
}
