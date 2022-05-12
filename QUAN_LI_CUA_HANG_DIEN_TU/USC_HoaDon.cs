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
    public partial class USC_HoaDon : UserControl
    {
        public USC_HoaDon()
        {
            InitializeComponent();
        }

        private void bnt_HangHoa_Click(object sender, EventArgs e)
        {
            frmHoaDonBan one = new frmHoaDonBan();
            one.ShowDialog();
        }
    }
}
