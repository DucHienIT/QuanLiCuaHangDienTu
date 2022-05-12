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
    public partial class frmDM_NhanVien : Form
    {
        DataTable tblNV; //Lưu dữ liệu bảng nhân viên
        string str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\QuanLiCuaHang.mdf;Integrated Security=True;User Instance=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        SqlCommandBuilder cmd = null;
        bool isAdd = false;
        public frmDM_NhanVien()
        {
            InitializeComponent();
        }

        private void frmDM_NhanVien_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = false;
            btn_Luu.Enabled = false;
            btn_BoQua.Enabled = false;
            conn = new SqlConnection(str);
            conn.Open();
            LoadDataGridView();
            conn.Close();
        }
        public void LoadDataGridView()
        {
            da = new SqlDataAdapter("Select * From NHANVIEN", conn);
            ds = new DataSet();
            da.Fill(ds, "NHANVIEN");
            dgvNhanVien.DataSource = ds.Tables["NHANVIEN"];           
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
            txtMaNhanVien.Enabled = true;
            txtMaNhanVien.Focus();
        }
        private void ResetValues()
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            checkBox_Sex.Checked = false;
            txtDiaChiNV.Text = "";
            txtNgaySinh.Text = "";
            txtSDTNV.Text = "";
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtMaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return;
            }
            if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return;
            }
            if (txtDiaChiNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChiNV.Focus();
                return;
            }
            if (txtSDTNV.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDTNV.Focus();
                return;
            }
            if (txtNgaySinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgaySinh.Focus();
                return;
            }
            if (!Functions.IsDate(txtNgaySinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                txtNgaySinh.Focus();
                return;
            }
            if (checkBox_Sex.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT MaNhanVien FROM NhanVien WHERE MaNhanVien='" + txtMaNhanVien.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                txtMaNhanVien.Text = "";
                return;
            }
            cmd = new SqlCommandBuilder(da);
            DataRow row = ds.Tables["NHANVIEN"].NewRow();
            row["MaNhanVien"] = txtMaNhanVien.Text;
            row["TenNhanVien"] = txtTenNhanVien.Text;
            row["DiaChi"] = txtDiaChiNV.Text;
            row["DienThoai"] = txtSDTNV.Text;
            string[] NgaySinh;
            NgaySinh = txtNgaySinh.Text.Trim().Split('/');


            row["NgaySinh"] = NgaySinh[2] + "/" + NgaySinh[1] + "/" + NgaySinh[0];
            row["GioiTinh"] = gt;
            ds.Tables["NHANVIEN"].Rows.Add(row);
            if (da.Update(ds, "NHANVIEN") > 0)
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
            txtMaNhanVien.Enabled = false;
        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (isAdd == true)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhanVien.Focus();
                return;
            }
            if (dgvNhanVien.Rows[e.RowIndex].Cells[0].Value != null)
            {
                txtMaNhanVien.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNhanVien.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();

                if (dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString() == "Nam")
                    checkBox_Sex.Checked = true;
                else
                    checkBox_Sex.Checked = false;
                txtDiaChiNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSDTNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtNgaySinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_Xoa.Enabled = true;
            }    
            
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (dgvNhanVien.Rows.Count == 1)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return;
            }
            if (txtDiaChiNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChiNV.Focus();
                return;
            }
            if (txtSDTNV.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDTNV.Focus();
                return;
            }
            if (txtNgaySinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgaySinh.Focus();
                return;
            }
            
            if (checkBox_Sex.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "UPDATE NhanVien SET  TenNhanVien=N'" + txtTenNhanVien.Text.Trim().ToString() +
                    "',DiaChi=N'" + txtDiaChiNV.Text.Trim().ToString() +
                    "',DienThoai='" + txtSDTNV.Text.ToString() + "',GioiTinh=N'" + gt +
                    "',NgaySinh='" + Functions.ConvertDateTime(txtNgaySinh.Text) +
                    "' WHERE MaNhanVien='" + txtMaNhanVien.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btn_BoQua.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dgvNhanVien.Rows.Count == 1)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE NhanVien WHERE MaNhanVien='" + txtMaNhanVien.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
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

        private void frmDM_NhanVien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
