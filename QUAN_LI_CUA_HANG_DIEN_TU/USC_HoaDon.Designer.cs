namespace QUAN_LI_CUA_HANG_DIEN_TU
{
    partial class USC_HoaDon
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
            this.label2 = new System.Windows.Forms.Label();
            this.bnt_HangHoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(525, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 54);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hóa Đơn Bán Hàng";
            // 
            // bnt_HangHoa
            // 
            this.bnt_HangHoa.BackgroundImage = global::QUAN_LI_CUA_HANG_DIEN_TU.Properties.Resources.bill;
            this.bnt_HangHoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnt_HangHoa.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bnt_HangHoa.Location = new System.Drawing.Point(497, 3);
            this.bnt_HangHoa.Name = "bnt_HangHoa";
            this.bnt_HangHoa.Size = new System.Drawing.Size(488, 383);
            this.bnt_HangHoa.TabIndex = 7;
            this.bnt_HangHoa.UseVisualStyleBackColor = true;
            this.bnt_HangHoa.Click += new System.EventHandler(this.bnt_HangHoa_Click);
            // 
            // USC_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bnt_HangHoa);
            this.Name = "USC_HoaDon";
            this.Size = new System.Drawing.Size(1392, 739);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bnt_HangHoa;
    }
}
