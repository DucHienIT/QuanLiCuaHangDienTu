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
    public partial class USC_DanhMuc : UserControl
    {
        public USC_DanhMuc()
        {
            InitializeComponent();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            frmDM_NhanVien one = new frmDM_NhanVien();
            one.ShowDialog();
        }

        private void bnt_HangHoa_Click(object sender, EventArgs e)
        {
            frmDMHang one = new frmDMHang();
            one.ShowDialog();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            frmDM_KhachHang one = new frmDM_KhachHang();
            one.ShowDialog();
        }
    }
}
