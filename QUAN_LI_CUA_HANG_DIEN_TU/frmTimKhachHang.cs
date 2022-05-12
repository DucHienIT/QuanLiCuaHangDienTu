using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LI_CUA_HANG_DIEN_TU
{
    public partial class frmTimKhachHang : Form
    {
        DataTable tblHDB;
        public frmTimKhachHang()
        {
            InitializeComponent();
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtMaKhachHang.Focus();
        }
        private void LoadDataGridView()
        {
            dgvTKKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgvTKKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgvTKKhachHang.Columns[2].HeaderText = "Địa chỉ";
            dgvTKKhachHang.Columns[3].HeaderText = "Số điện thoại";
            
            dgvTKKhachHang.Columns[0].Width = 150;
            dgvTKKhachHang.Columns[1].Width = 100;
            dgvTKKhachHang.Columns[2].Width = 80;
            dgvTKKhachHang.Columns[3].Width = 80;
            
            dgvTKKhachHang.AllowUserToAddRows = false;
            dgvTKKhachHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
