namespace QUAN_LI_CUA_HANG_DIEN_TU
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBC_HangTon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBC_DoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHienTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.usC_TimKiem1 = new QUAN_LI_CUA_HANG_DIEN_TU.USC_TimKiem();
            this.usC_HoaDon2 = new QUAN_LI_CUA_HANG_DIEN_TU.USC_HoaDon();
            this.usC_TimKiem3 = new QUAN_LI_CUA_HANG_DIEN_TU.USC_TimKiem();
            this.usC_HoaDon1 = new QUAN_LI_CUA_HANG_DIEN_TU.USC_HoaDon();
            this.usC_DanhMuc1 = new QUAN_LI_CUA_HANG_DIEN_TU.USC_DanhMuc();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuDanhMuc,
            this.mnuHoaDon,
            this.mnuTimKiem,
            this.báoCáoToolStripMenuItem,
            this.mnuTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1468, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.mnuFile.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(116, 42);
            this.mnuFile.Text = "Tập tin";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(151, 42);
            this.mnuThoat.Text = "Exit";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(158, 42);
            this.mnuDanhMuc.Text = "Danh mục";
            this.mnuDanhMuc.Click += new System.EventHandler(this.mnuDanhMuc_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(138, 42);
            this.mnuHoaDon.Text = "Hóa đơn";
            this.mnuHoaDon.Click += new System.EventHandler(this.mnuHoaDon_Click);
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(145, 42);
            this.mnuTimKiem.Text = "Tìm kiếm";
            this.mnuTimKiem.Click += new System.EventHandler(this.mnuTimKiem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBC_HangTon,
            this.mnuBC_DoanhThu});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(128, 42);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // mnuBC_HangTon
            // 
            this.mnuBC_HangTon.Name = "mnuBC_HangTon";
            this.mnuBC_HangTon.Size = new System.Drawing.Size(239, 42);
            this.mnuBC_HangTon.Text = "Hàng tồn";
            // 
            // mnuBC_DoanhThu
            // 
            this.mnuBC_DoanhThu.Name = "mnuBC_DoanhThu";
            this.mnuBC_DoanhThu.Size = new System.Drawing.Size(239, 42);
            this.mnuBC_DoanhThu.Text = "Doanh thu";
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHienTroGiup,
            this.mnuThongTin});
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(134, 42);
            this.mnuTroGiup.Text = "Trợ giúp";
            // 
            // mnuHienTroGiup
            // 
            this.mnuHienTroGiup.Name = "mnuHienTroGiup";
            this.mnuHienTroGiup.Size = new System.Drawing.Size(227, 42);
            this.mnuHienTroGiup.Text = "Trợ giúp";
            // 
            // mnuThongTin
            // 
            this.mnuThongTin.Name = "mnuThongTin";
            this.mnuThongTin.Size = new System.Drawing.Size(227, 42);
            this.mnuThongTin.Text = "Thông tin";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1208, 695);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // usC_TimKiem1
            // 
            this.usC_TimKiem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.usC_TimKiem1.Location = new System.Drawing.Point(0, 49);
            this.usC_TimKiem1.Name = "usC_TimKiem1";
            this.usC_TimKiem1.Size = new System.Drawing.Size(1536, 786);
            this.usC_TimKiem1.TabIndex = 9;
            // 
            // usC_HoaDon2
            // 
            this.usC_HoaDon2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.usC_HoaDon2.Location = new System.Drawing.Point(426, 91);
            this.usC_HoaDon2.Name = "usC_HoaDon2";
            this.usC_HoaDon2.Size = new System.Drawing.Size(8, 8);
            this.usC_HoaDon2.TabIndex = 8;
            // 
            // usC_TimKiem3
            // 
            this.usC_TimKiem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.usC_TimKiem3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usC_TimKiem3.BackgroundImage")));
            this.usC_TimKiem3.Location = new System.Drawing.Point(876, 598);
            this.usC_TimKiem3.Name = "usC_TimKiem3";
            this.usC_TimKiem3.Size = new System.Drawing.Size(8, 8);
            this.usC_TimKiem3.TabIndex = 7;
            // 
            // usC_HoaDon1
            // 
            this.usC_HoaDon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.usC_HoaDon1.Location = new System.Drawing.Point(0, 49);
            this.usC_HoaDon1.Name = "usC_HoaDon1";
            this.usC_HoaDon1.Size = new System.Drawing.Size(1468, 518);
            this.usC_HoaDon1.TabIndex = 4;
            // 
            // usC_DanhMuc1
            // 
            this.usC_DanhMuc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.usC_DanhMuc1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.usC_DanhMuc1.Location = new System.Drawing.Point(0, 49);
            this.usC_DanhMuc1.Name = "usC_DanhMuc1";
            this.usC_DanhMuc1.Size = new System.Drawing.Size(1468, 678);
            this.usC_DanhMuc1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1468, 729);
            this.ControlBox = false;
            this.Controls.Add(this.usC_TimKiem1);
            this.Controls.Add(this.usC_HoaDon2);
            this.Controls.Add(this.usC_TimKiem3);
            this.Controls.Add(this.usC_HoaDon1);
            this.Controls.Add(this.usC_DanhMuc1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí bán thiết bị điện tử";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBC_HangTon;
        private System.Windows.Forms.ToolStripMenuItem mnuBC_DoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuHienTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private USC_DanhMuc usC_DanhMuc1;
        private USC_HoaDon usC_HoaDon1;
        private USC_TimKiem usC_TimKiem3;
        private USC_HoaDon usC_HoaDon2;
        private USC_TimKiem usC_TimKiem1;
    }
}

