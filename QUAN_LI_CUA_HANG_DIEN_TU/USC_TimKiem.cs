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
    public partial class USC_TimKiem : UserControl
    {
        public USC_TimKiem()
        {
            InitializeComponent();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            frmTimHDBan one = new frmTimHDBan();
            one.ShowDialog();
        }

        private void bnt_HangHoa_Click(object sender, EventArgs e)
        {
            frmTimHangHoa one = new frmTimHangHoa();
            one.ShowDialog();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            frmTimKhachHang one = new frmTimKhachHang();
            one.ShowDialog();
        }
    }
}
