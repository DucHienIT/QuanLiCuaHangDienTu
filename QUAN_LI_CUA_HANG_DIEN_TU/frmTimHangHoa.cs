using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QUAN_LI_CUA_HANG_DIEN_TU.Class;
namespace QUAN_LI_CUA_HANG_DIEN_TU
{
    public partial class frmTimHangHoa : Form
    {
        DataTable tblHDB;
        public frmTimHangHoa()
        {
            InitializeComponent();
        }

        private void frmTimHangHoa_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgvTKHangHoa.DataSource = null;
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtMaHangHoa.Focus();
        }
        private void LoadDataGridView()
        {
            
            dgvTKHangHoa.AllowUserToAddRows = false;
            dgvTKHangHoa.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btn_TimKiemHD_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaHangHoa.Text == "") && (txtTenHangHoa.Text == "") && (txtGiaNhap.Text == "") &&
               (txtGiaBan.Text == "")) 
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM HANGHOA WHERE 1=1";
            if (txtMaHangHoa.Text != "")
                sql = sql + " AND MaHang Like '%" + txtMaHangHoa.Text + "%'";
            if (txtTenHangHoa.Text != "")
                sql = sql + " AND TenHang Like N'%" + txtTenHangHoa.Text + "%'";
            if (txtGiaNhap.Text != "")
                sql = sql + " AND GiaNhap =" + txtGiaNhap.Text;
            if (txtGiaBan.Text != "")
                sql = sql + " AND GiaBan =" + txtGiaBan.Text;
            tblHDB = Functions.GetDataToTable(sql);
            if (tblHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblHDB.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvTKHangHoa.DataSource = tblHDB;
            LoadDataGridView();
        }

        private void btn_TimLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvTKHangHoa.DataSource = null;
        }

        private void dgvTKHangHoa_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string mahd;
                if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mahd = dgvTKHangHoa.CurrentRow.Cells["MaHang"].Value.ToString();
                    frmDMHang frm = new frmDMHang();
                    frm.txtMaHang.Text = mahd;
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Không có bản ghi nào!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
