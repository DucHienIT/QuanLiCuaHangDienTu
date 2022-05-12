namespace QUAN_LI_CUA_HANG_DIEN_TU
{
    partial class frmTimHangHoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_TimLai = new System.Windows.Forms.Button();
            this.btn_TimKiemHD = new System.Windows.Forms.Button();
            this.dgvTKHangHoa = new System.Windows.Forms.DataGridView();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenHangHoa = new System.Windows.Forms.TextBox();
            this.txtMaHangHoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(84, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(397, 22);
            this.label7.TabIndex = 79;
            this.label7.Text = "Nháp đúp vào hàng hóa để hiện thông tin chi tiểt";
            // 
            // btn_Dong
            // 
            this.btn_Dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Location = new System.Drawing.Point(709, 475);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(178, 39);
            this.btn_Dong.TabIndex = 78;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_TimLai
            // 
            this.btn_TimLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimLai.Location = new System.Drawing.Point(471, 475);
            this.btn_TimLai.Name = "btn_TimLai";
            this.btn_TimLai.Size = new System.Drawing.Size(178, 39);
            this.btn_TimLai.TabIndex = 77;
            this.btn_TimLai.Text = "Tìm lại";
            this.btn_TimLai.UseVisualStyleBackColor = true;
            this.btn_TimLai.Click += new System.EventHandler(this.btn_TimLai_Click);
            // 
            // btn_TimKiemHD
            // 
            this.btn_TimKiemHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiemHD.Location = new System.Drawing.Point(236, 475);
            this.btn_TimKiemHD.Name = "btn_TimKiemHD";
            this.btn_TimKiemHD.Size = new System.Drawing.Size(178, 39);
            this.btn_TimKiemHD.TabIndex = 76;
            this.btn_TimKiemHD.Text = "Tìm kiếm";
            this.btn_TimKiemHD.UseVisualStyleBackColor = true;
            this.btn_TimKiemHD.Click += new System.EventHandler(this.btn_TimKiemHD_Click);
            // 
            // dgvTKHangHoa
            // 
            this.dgvTKHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKHangHoa.Location = new System.Drawing.Point(79, 199);
            this.dgvTKHangHoa.Name = "dgvTKHangHoa";
            this.dgvTKHangHoa.RowHeadersWidth = 51;
            this.dgvTKHangHoa.RowTemplate.Height = 24;
            this.dgvTKHangHoa.Size = new System.Drawing.Size(919, 219);
            this.dgvTKHangHoa.TabIndex = 75;
            this.dgvTKHangHoa.DoubleClick += new System.EventHandler(this.dgvTKHangHoa_DoubleClick);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(695, 98);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(303, 28);
            this.txtGiaBan.TabIndex = 70;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(563, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 69;
            this.label4.Text = "Giá bán";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap.Location = new System.Drawing.Point(695, 55);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(303, 28);
            this.txtGiaNhap.TabIndex = 68;
            this.txtGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNhap_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(563, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 67;
            this.label3.Text = "Giá nhập";
            // 
            // txtTenHangHoa
            // 
            this.txtTenHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHangHoa.Location = new System.Drawing.Point(198, 101);
            this.txtTenHangHoa.Name = "txtTenHangHoa";
            this.txtTenHangHoa.Size = new System.Drawing.Size(303, 28);
            this.txtTenHangHoa.TabIndex = 66;
            // 
            // txtMaHangHoa
            // 
            this.txtMaHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHangHoa.Location = new System.Drawing.Point(198, 52);
            this.txtMaHangHoa.Name = "txtMaHangHoa";
            this.txtMaHangHoa.Size = new System.Drawing.Size(303, 28);
            this.txtMaHangHoa.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(75, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 63;
            this.label1.Text = "Mã hàng hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(75, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 65;
            this.label2.Text = "Tên hàng hóa";
            // 
            // frmTimHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 566);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_TimLai);
            this.Controls.Add(this.btn_TimKiemHD);
            this.Controls.Add(this.dgvTKHangHoa);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenHangHoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaHangHoa);
            this.Controls.Add(this.label1);
            this.Name = "frmTimHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimHangHoa";
            this.Load += new System.EventHandler(this.frmTimHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_TimLai;
        private System.Windows.Forms.Button btn_TimKiemHD;
        private System.Windows.Forms.DataGridView dgvTKHangHoa;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenHangHoa;
        private System.Windows.Forms.TextBox txtMaHangHoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}