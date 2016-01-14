using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
using DevExpress.Utils.Win;
using BusinessLogicTier;
using DataTransferObject;
using QuanLyCuaHangLinhKienDienThoai.XtraReport;
using DevExpress.XtraReports.UI;

namespace QuanLyCuaHangLinhKienDienThoai.UserControl
{
    public partial class ucBaoCaoNhapHang : DevExpress.XtraEditors.XtraUserControl
    {
        private BaoCaoNhapHangBUS _BaoCaoNhapHangBUS;
        public ucBaoCaoNhapHang()
        {
            InitializeComponent();
            _BaoCaoNhapHangBUS = new BaoCaoNhapHangBUS();

            deThoiGian.DateTime = DateTime.Now;
            gcChiTietBaoCao.DataSource = null;
            gvChiTietBaoCao.Columns.Clear();
            BaoCaoNhapHang bc = new BaoCaoNhapHang();
            bc.ThoiGian = ((DateTime)deThoiGian.EditValue).ToString("MM/dd/yyyy");
            gcChiTietBaoCao.DataSource = _BaoCaoNhapHangBUS.LayChiTietBaoCao(bc);
        }

        private void deThang_Popup(object sender, EventArgs e)
        {
            DateEdit edit = sender as DateEdit;
            PopupDateEditForm form = (edit as IPopupControl).PopupWindow as PopupDateEditForm;
            form.Calendar.View = DevExpress.XtraEditors.Controls.DateEditCalendarViewType.YearInfo;
        }

        private void deThang_TextChanged(object sender, EventArgs e)
        {
            gcChiTietBaoCao.DataSource = null;
            gvChiTietBaoCao.Columns.Clear();
            BaoCaoNhapHang bc = new BaoCaoNhapHang();
            bc.ThoiGian = ((DateTime)deThoiGian.EditValue).ToString("MM/dd/yyyy");
            gcChiTietBaoCao.DataSource = _BaoCaoNhapHangBUS.LayChiTietBaoCao(bc);
        }

        private void sbChiTietBaoCao_Click(object sender, EventArgs e)
        {
            BaoCaoNhapHang bc = new BaoCaoNhapHang();

            DataTable dt = gcChiTietBaoCao.DataSource as DataTable;
            if (dt != null && dt.Rows.Count > 0)
            {
                bc.ChiTietBaoCao = gcChiTietBaoCao.DataSource as DataTable;
                bc.ThoiGian = ((DateTime)deThoiGian.EditValue).ToString("MM/dd/yyyy");
                XRBaoCaoNhapHang BCTonKho = new XRBaoCaoNhapHang(bc);
                try
                {
                    BCTonKho.CreateDocument();
                }
                catch (Exception ex)
                {

                }
                ReportPrintTool printTool = new ReportPrintTool(BCTonKho);
                printTool.ShowPreviewDialog();
            }
            else
            {
                MessageBox.Show("Danh Sách Báo Cáo Trống",
                   "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }
    }
}
