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
    public partial class frmDMHang : Form
    {
        DataTable tblH; //Lưu dữ liệu bảng nhân viên
        string str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\QuanLiCuaHang.mdf;Integrated Security=True;User Instance=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        SqlCommandBuilder cmd = null;
        bool isAdd = false;

        public frmDMHang()
        {
            InitializeComponent();
        }

        private void frmDMHang_Load(object sender, EventArgs e)
        {
            txtMaHang.Enabled = false;
            btn_Luu.Enabled = false;
            btn_BoQua.Enabled = false;
            conn = new SqlConnection(str);
            conn.Open();
            LoadDataGridView();
            conn.Close();
        }
        public void LoadDataGridView()
        {
            da = new SqlDataAdapter("Select * From HANGHOA", conn);
            ds = new DataSet();
            da.Fill(ds, "HANGHOA");
            dgvHangHoa.DataSource = ds.Tables["HANGHOA"];
        }
        private void dgvHangHoa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (isAdd == true)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            if (dgvHangHoa.Rows[e.RowIndex].Cells[0].Value != null)
            {
                txtMaHang.Text = dgvHangHoa.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenHang.Text = dgvHangHoa.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoLuong.Text = dgvHangHoa.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGiaNhap.Text = dgvHangHoa.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGiaBan.Text = dgvHangHoa.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtAnh.Text = dgvHangHoa.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtGhiChu.Text = dgvHangHoa.Rows[e.RowIndex].Cells[6].Value.ToString();
                try
                {
                    pic_Anh.Image = Image.FromFile(txtAnh.Text);
                }
                catch
                {
                    pic_Anh.Image = null;
                    
                }
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_Xoa.Enabled = true;
            }
        }

        private void btn_BoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Them.Enabled = true;
            btn_BoQua.Enabled = false;
            btn_Luu.Enabled = false;
            txtMaHang.Enabled = false;
        }
        private void ResetValues()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtSoLuong.Text = "0";
            txtGiaNhap.Text = "0";
            txtGiaBan.Text = "0";
            txtSoLuong.Enabled = true;
            txtGiaNhap.Enabled = true;
            txtGiaBan.Enabled = true;
            txtAnh.Text = "";
            pic_Anh.Image = null;
            txtGhiChu.Text = "";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
            txtMaHang.Enabled = true;
            txtMaHang.Focus();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHang.Focus();
                return;
            }
            if (txtTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHang.Focus();
                return;
            }
            if (txtSoLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }
            if (txtGiaNhap.Text.Trim().Length == 0 || int.Parse(txtGiaNhap.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập đúng giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaNhap.Focus();
                return;
            }
            if (txtGiaBan.Text.Trim().Length == 0 || int.Parse(txtGiaBan.Text.Trim()) < 0)
            {
                MessageBox.Show("Bạn phải nhập đúng giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaBan.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đường dẫn ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnh.Focus();
                return;
            }

            sql = "SELECT MaHang FROM HANGHOA WHERE MaHang='" + txtMaHang.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHang.Focus();
                txtMaHang.Text = "";
                return;
            }

            cmd = new SqlCommandBuilder(da);
            DataRow row = ds.Tables["HANGHOA"].NewRow();
            row["MaHang"] = txtMaHang.Text;
            row["TenHang"] = txtTenHang.Text;
            row["SoLuong"] = txtSoLuong.Text;
            row["GiaNhap"] = txtGiaNhap.Text;
            row["GiaBan"] = txtGiaBan.Text;
            row["Anh"] = txtAnh.Text;
            row["GhiChu"] = txtGhiChu.Text;

            ds.Tables["HANGHOA"].Rows.Add(row);
            if (da.Update(ds, "HANGHOA") > 0)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            LoadDataGridView();
            //ResetValues();
            isAdd = false;
            btn_Xoa.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_BoQua.Enabled = false;
            btn_Luu.Enabled = false;
            txtMaHang.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dgvHangHoa.Rows.Count == 1)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE HANGHOA WHERE MaHang='" + txtMaHang.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                if (dgvHangHoa.Rows.Count == 1)
                {
                    MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMaHang.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMaHang.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaHang.Focus();
                    return;
                }
                if (txtTenHang.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenHang.Focus();
                    return;
                }
                if (txtSoLuong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoLuong.Focus();
                    return;
                }
                if (txtGiaNhap.Text.Trim().Length == 0 || int.Parse(txtGiaNhap.Text) < 0)
                {
                    MessageBox.Show("Bạn phải nhập đúng giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGiaNhap.Focus();
                    return;
                }
                if (txtGiaBan.Text.Trim().Length == 0 || int.Parse(txtGiaBan.Text.Trim()) < 0)
                {
                    MessageBox.Show("Bạn phải nhập đúng giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGiaBan.Focus();
                    return;
                }
                if (txtAnh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đường dẫn ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAnh.Focus();
                    return;
                }
                sql = "UPDATE HANGHOA SET  TenHang=N'" + txtTenHang.Text.Trim().ToString() +
                        "', SoLuong=" + txtSoLuong.Text.Trim().ToString() +
                        ", GiaNhap=" + txtGiaNhap.Text.ToString() +
                        ", GiaBan=" + txtGiaBan.Text.ToString() +
                        ", Anh=N'" + txtAnh.Text.ToString() +
                        "', GhiChu=N'" + txtGhiChu.Text.ToString() +
                        "' WHERE MaHang='" + txtMaHang.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
                btn_BoQua.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Lỗi, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                MessageBox.Show("Nhập đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_MoAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                pic_Anh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
                Functions.RunSQL("UPDATE HANGHOA SET Anh=N'" + txtAnh.Text.ToString() +
                    "' WHERE MaHang='" + txtMaHang.Text + "'");
                LoadDataGridView();
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtTenHang.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from HangHoa WHERE 1=1";
            if (txtTenHang.Text != "")
                sql += " AND TenHang LIKE N'%" + txtTenHang.Text + "%'";

            
            tblH = Functions.GetDataToTable(sql);
            if (tblH.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblH.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvHangHoa.DataSource = tblH;
            ResetValues();
        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaHang,TenHang,SoLuong,GiaNhap,GiaBan,Anh,Ghichu FROM HangHoa";
            tblH = Functions.GetDataToTable(sql);
            
            tblH = Functions.GetDataToTable(sql);
            dgvHangHoa.DataSource = tblH;
        }
    }
}
