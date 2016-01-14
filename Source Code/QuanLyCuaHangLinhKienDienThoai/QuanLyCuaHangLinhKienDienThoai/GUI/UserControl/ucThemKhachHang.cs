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
using BusinessLogicTier;
using DataTransferObject;
using System.Data.SqlClient;

namespace QuanLyCuaHangLinhKienDienThoai.UserControl
{
    public partial class ucThemKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        private KhachHangBUS khBUS;
        private String maKH = "";

        public ucThemKhachHang()
        {
            InitializeComponent();
            this.khBUS = new KhachHangBUS();

            ////Load danh sách Loại khách hàng
            //DataSet dataLoaiKhachHang = new DataSet();
            //dataLoaiKhachHang = (new LoaiKhachHangBUS().LoadComboBox());

            //this.leLoaiKhachHang.Properties.DataSource = dataLoaiKhachHang;
            //this.leLoaiKhachHang.Properties.DisplayMember = "TenLoaiKhachHang";
            //this.leLoaiKhachHang.Properties.ValueMember = "MaLoaiKhachHang";

            
        }

        private void sbLuu_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();

            if (this.teTenKhachHang.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống tên khách hàng");
                return;
            }

            //kh.MaKhachHang = this.teTenKhachHang.Text;
            kh.TenKhachHang = this.teTenKhachHang.Text;
            kh.DiaChi = this.teDiaChi.Text;
            kh.SoDienThoai = this.teSoDienThoai.Text;
            kh.Email = this.teEmail.Text;
            kh.GhiChu = this.txtGhiChu.Text;

            if (StaticVariables.gKhachHang != null)
            {
                kh.MaKhachHang = this.maKH;
                if (this.khBUS.CapNhatKhachHang(kh))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Cập nhật khách hàng thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
                
                if (this.khBUS.ThemKhachHang(kh))
                {
                    MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại", "Thông báo", MessageBoxButtons.OK);
                }
        }

        private void groupControl1_Enter(object sender, EventArgs e)
        {
            if (StaticVariables.gKhachHang != null)
            {
                this.maKH = StaticVariables.gKhachHang.MaKhachHang;
                this.teTenKhachHang.Text = StaticVariables.gKhachHang.TenKhachHang;
                this.teSoDienThoai.Text = StaticVariables.gKhachHang.SoDienThoai;
                this.teEmail.Text = StaticVariables.gKhachHang.Email;
                this.teDiaChi.Text = StaticVariables.gKhachHang.DiaChi;
                this.txtGhiChu.Text = StaticVariables.gKhachHang.GhiChu;

            }
            else
            {
                this.resetValue();
            }
        }

        private void resetValue()
        {
            this.teTenKhachHang.Text = " ";
            this.teSoDienThoai.Text = " ";
            this.teEmail.Text = " ";
            this.teDiaChi.Text = " ";
            this.txtGhiChu.Text = " ";
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }
    }
}
