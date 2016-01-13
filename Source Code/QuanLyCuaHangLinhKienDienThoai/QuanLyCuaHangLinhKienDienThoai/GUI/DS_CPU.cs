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
using DataTransferObject;

namespace QuanLyCuaHangLinhKienDienThoai.GUI
{
    public partial class DS_CPU : MetroFramework.Forms.MetroForm
    {
        private CPUBUS cpuBUS;
        private CPU cpu;
        DataGridViewCellEventArgs eventClickGrid;
        public DS_CPU()
        {
            InitializeComponent();

            this.cpuBUS = new CPUBUS();

            LoadData();

            //Max length og type text
            this.tbnTenCPU.MaxLength = 50;
            this.tbnMaCPU.MaxLength = 15;
            this.tbnSoNhan.MaxLength = 2;

            // Only type number

        }

        private void LoadData()
        {
            DataTable data = new DataTable();
            data = this.cpuBUS.LayDanhSachCPU();
            this.dtDanhSachCPU.DataSource = data;//Add data 
        }

        private void DS_CPU_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cpu = new CPU();

            if (this.tbnTenCPU.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống Tên CPU");
                return;
            }
            else
            {
                if (this.tbnSoNhan.Text.Equals(""))
                {
                    MessageBox.Show("Không được để trống số nhân CPU");
                    return;
                }
                else
                {

                    cpu.TenCPU = this.tbnTenCPU.Text;
                    cpu.SonhanCPU = Convert.ToInt32(this.tbnSoNhan.Text);

                    if (this.cpuBUS.ThemCPU(cpu))
                    {
                        MessageBox.Show("Thêm CPU thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Thêm CPU thất bại", "Thông báo", MessageBoxButtons.OK);
                    }

                    LoadData();
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            cpu = new CPU();
            cpu.MaCPU = cpu.MaCPU = this.dtDanhSachCPU.Rows[eventClickGrid.RowIndex].Cells["Mã CPU"].Value.ToString();

            if (this.tbnTenCPU.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống Tên CPU");
                return;
            }
            else
            {
                cpu.TenCPU = this.tbnTenCPU.Text;

                if (this.tbnTenCPU.Text.Equals(""))
                {
                    MessageBox.Show("Không được để trống Số nhân CPU");
                    return;
                }
                else
                {
                    cpu.SonhanCPU = Convert.ToInt32(this.tbnSoNhan.Text);

                    String message = "";
                    if (cpuBUS.CapNhatCPU(cpu))
                        message += "Cập Nhật thành công";
                    else
                        message += "Cập Nhật lỗi! \nVui lòng kiểm tra lại thông tin trước khi Cập Nhật.";

                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);

                    LoadData();

                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String message = "";
            if (eventClickGrid != null && cpuBUS.XoaCPU(this.dtDanhSachCPU.Rows[eventClickGrid.RowIndex].Cells["Mã CPU"].Value.ToString()))
            {
                message += "Xóa thành công";
            }
            else
                message += "Xóa lỗi! \nVui lòng kiểm tra lại thông tin trước khi xóa.";

            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
            this.LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            cpu = new CPU();
            cpu.MaCPU = this.tbnMaCPU.Text;
            cpu.TenCPU = this.tbnTenCPU.Text;
            if (!this.tbnSoNhan.Text.Equals(""))
            {
                cpu.SonhanCPU = Convert.ToInt32(this.tbnSoNhan.Text);
            }

            DataTable data = new DataTable();
            data = this.cpuBUS.TimKiemCPU(cpu);

            this.dtDanhSachCPU.DataSource = data;
        }

        private void dtDanhSachCPU_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtDanhSachCPU.RowCount != 0)//Get data
            {
                eventClickGrid = e;
                this.tbnMaCPU.Text = this.dtDanhSachCPU.Rows[eventClickGrid.RowIndex].Cells["Mã CPU"].Value.ToString();
                this.tbnTenCPU.Text = this.dtDanhSachCPU.Rows[eventClickGrid.RowIndex].Cells["Tên CPU"].Value.ToString();
                this.tbnSoNhan.Text = this.dtDanhSachCPU.Rows[eventClickGrid.RowIndex].Cells["Số nhân"].Value.ToString();

            }
        }
    }
}
