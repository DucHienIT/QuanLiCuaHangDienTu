using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QUAN_LI_CUA_HANG_DIEN_TU.Class;
namespace QUAN_LI_CUA_HANG_DIEN_TU
{
    public partial class frmDM_KhachHang : Form
    {
        string str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\QuanLiCuaHang.mdf;Integrated Security=True;User Instance=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        SqlCommandBuilder cmd = null;
        bool isAdd = false;

        public frmDM_KhachHang()
        {
            InitializeComponent();
        }
        public void LoadDataGridView()
        {
            da = new SqlDataAdapter("Select * From KHACHHANG", conn);
            ds = new DataSet();
            da.Fill(ds, "KHACHHANG");
            dgvKhachHang.DataSource = ds.Tables["KHACHHANG"];
        }

        private void frmDM_KhachHang_Load(object sender, EventArgs e)
        {
            txtMaKhach.Enabled = false;
            btn_Luu.Enabled = false;
            btn_BoQua.Enabled = false;
            conn = new SqlConnection(str);
            conn.Open();
            LoadDataGridView();
            conn.Close();
           
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            isAdd = true;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_BoQua.Enabled = true;
            btn_Luu.Enabled = true;
            btn_Them.Enabled = false;
            ResetValues();
            txtMaKhach.Enabled = true;
            txtMaKhach.Focus();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dgvKhachHang.Rows.Count == 1)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE Khachhang WHERE MaKhachHang='" + txtMaKhach.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhach.Focus();
                return;
            }
            if (txtTenKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhach.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (txtSDT.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            
            sql = "SELECT MaKhachHang FROM KHACHHANG WHERE MaKhachHang='" + txtMaKhach.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhach.Focus();
                txtMaKhach.Text = "";
                return;
            }
            cmd = new SqlCommandBuilder(da);
            DataRow row = ds.Tables["KHACHHANG"].NewRow();
            row["MaKhachHang"] = txtMaKhach.Text;
            row["TenKhachHang"] = txtTenKhach.Text;
            row["DiaChi"] = txtDiaChi.Text;
            row["DienThoai"] = txtSDT.Text;
            
            ds.Tables["KHACHHANG"].Rows.Add(row);
            if (da.Update(ds, "KHACHHANG") > 0)
            {
                MessageBox.Show("Thêm thành công");
                
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            LoadDataGridView();
            ResetValues();
            isAdd = false;
            btn_Xoa.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_BoQua.Enabled = false;
            btn_Luu.Enabled = false;
            txtMaKhach.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql;
            if (dgvKhachHang.Rows.Count == 1)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhach.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (txtSDT.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            
            sql = "UPDATE KHACHHANG SET  TenKhachHang=N'" + txtTenKhach.Text.Trim().ToString() +
                    "', DiaChi=N'" + txtDiaChi.Text.Trim().ToString() +
                    "', DienThoai='" + txtSDT.Text.ToString() +  
                    "' WHERE MaKhachHang='" + txtMaKhach.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btn_BoQua.Enabled = false;
        }

        private void btn_BoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_BoQua.Enabled = false;
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Luu.Enabled = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ResetValues()
        {
            txtMaKhach.Text = "";
            txtTenKhach.Text = "";
         
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        private void dgvKhachHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            if (isAdd == true)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhach.Focus();
                return;
            }
            if (dgvKhachHang.Rows[e.RowIndex].Cells[0].Value != null)
            {
                txtMaKhach.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKhach.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSDT.Text = dgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_Xoa.Enabled = true;
            }
            
            
        }
    }
}
