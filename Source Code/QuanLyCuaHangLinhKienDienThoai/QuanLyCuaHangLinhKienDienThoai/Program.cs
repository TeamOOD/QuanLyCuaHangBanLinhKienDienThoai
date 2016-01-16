using System;
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

            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Sharp Plus";
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 8);
            Application.Run(new FormDangNhap());
        }
    }
}
