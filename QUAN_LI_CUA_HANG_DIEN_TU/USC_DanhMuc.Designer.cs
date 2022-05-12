namespace QUAN_LI_CUA_HANG_DIEN_TU
{
    partial class USC_DanhMuc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_KhachHang = new System.Windows.Forms.Button();
            this.bnt_HangHoa = new System.Windows.Forms.Button();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(120, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(619, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 54);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hàng Hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(1111, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 54);
            this.label3.TabIndex = 5;
            this.label3.Text = "Khách Hàng";
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.BackgroundImage = global::QUAN_LI_CUA_HANG_DIEN_TU.Properties.Resources.customer;
            this.btn_KhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_KhachHang.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_KhachHang.Location = new System.Drawing.Point(991, 3);
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.Size = new System.Drawing.Size(488, 383);
            this.btn_KhachHang.TabIndex = 2;
            this.btn_KhachHang.UseVisualStyleBackColor = true;
            this.btn_KhachHang.Click += new System.EventHandler(this.btn_KhachHang_Click);
            // 
            // bnt_HangHoa
            // 
            this.bnt_HangHoa.BackgroundImage = global::QUAN_LI_CUA_HANG_DIEN_TU.Properties.Resources.boxes;
            this.bnt_HangHoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnt_HangHoa.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bnt_HangHoa.Location = new System.Drawing.Point(497, 3);
            this.bnt_HangHoa.Name = "bnt_HangHoa";
            this.bnt_HangHoa.Size = new System.Drawing.Size(488, 383);
            this.bnt_HangHoa.TabIndex = 1;
            this.bnt_HangHoa.UseVisualStyleBackColor = true;
            this.bnt_HangHoa.Click += new System.EventHandler(this.bnt_HangHoa_Click);
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.BackgroundImage = global::QUAN_LI_CUA_HANG_DIEN_TU.Properties.Resources.employee;
            this.btn_NhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_NhanVien.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_NhanVien.Location = new System.Drawing.Point(3, 3);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(488, 383);
            this.btn_NhanVien.TabIndex = 0;
            this.btn_NhanVien.UseVisualStyleBackColor = true;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // USC_DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_KhachHang);
            this.Controls.Add(this.bnt_HangHoa);
            this.Controls.Add(this.btn_NhanVien);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "USC_DanhMuc";
            this.Size = new System.Drawing.Size(1568, 681);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NhanVien;
        private System.Windows.Forms.Button bnt_HangHoa;
        private System.Windows.Forms.Button btn_KhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
