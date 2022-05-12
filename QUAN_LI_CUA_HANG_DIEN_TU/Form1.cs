using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        private ArrayList listBtn =  new ArrayList();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect(); //Mở kết nối
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect(); //Đóng kết nối
            Application.Exit(); //Thoát
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDM_NhanVien one = new frmDM_NhanVien();
            one.ShowDialog();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDM_KhachHang one = new frmDM_KhachHang();
            one.ShowDialog();
        }

        private void mnuTimKiem_Click(object sender, EventArgs e)
        {
            usC_TimKiem1.BringToFront();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHang one = new frmDMHang();
            one.ShowDialog();
        }

        private void mnuHoaDonBanHang_Click(object sender, EventArgs e)
        {
            frmHoaDonBan one = new frmHoaDonBan();
            one.ShowDialog();
        }

        private void mnuTim_HoaDon_Click(object sender, EventArgs e)
        {
            frmTimHDBan one = new frmTimHDBan();
            one.ShowDialog();
        }

        private void mnuDanhMuc_Click(object sender, EventArgs e)
        {
            usC_DanhMuc1.BringToFront();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            usC_HoaDon1.BringToFront();
        }

        private void usC_TimKiem1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
