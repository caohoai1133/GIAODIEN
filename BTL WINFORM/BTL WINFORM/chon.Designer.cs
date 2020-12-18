namespace BTL_WINFORM
{
    partial class chon
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
            this.DX = new System.Windows.Forms.Button();
            this.THONGKE = new System.Windows.Forms.Button();
            this.RAP = new System.Windows.Forms.Button();
            this.LICHCHIEU = new System.Windows.Forms.Button();
            this.NHANVIEN = new System.Windows.Forms.Button();
            this.BANVE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DX
            // 
            this.DX.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DX.Location = new System.Drawing.Point(157, 272);
            this.DX.Name = "DX";
            this.DX.Size = new System.Drawing.Size(139, 124);
            this.DX.TabIndex = 11;
            this.DX.Text = "ĐĂNG XUẤT";
            this.DX.UseVisualStyleBackColor = false;
            this.DX.Click += new System.EventHandler(this.DX_Click);
            // 
            // THONGKE
            // 
            this.THONGKE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.THONGKE.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.THONGKE.Image = global::BTL_WINFORM.Properties.Resources.growth_statistics_icon;
            this.THONGKE.Location = new System.Drawing.Point(12, 272);
            this.THONGKE.Name = "THONGKE";
            this.THONGKE.Size = new System.Drawing.Size(139, 124);
            this.THONGKE.TabIndex = 10;
            this.THONGKE.Text = "THỐNG KÊ";
            this.THONGKE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.THONGKE.UseVisualStyleBackColor = false;
            this.THONGKE.Click += new System.EventHandler(this.THONGKE_Click);
            // 
            // RAP
            // 
            this.RAP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RAP.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.RAP.Image = global::BTL_WINFORM.Properties.Resources.theatre_icon;
            this.RAP.Location = new System.Drawing.Point(157, 142);
            this.RAP.Name = "RAP";
            this.RAP.Size = new System.Drawing.Size(139, 124);
            this.RAP.TabIndex = 9;
            this.RAP.Text = "QUẢN LÝ RẠP";
            this.RAP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RAP.UseVisualStyleBackColor = false;
            this.RAP.Click += new System.EventHandler(this.RAP_Click);
            // 
            // LICHCHIEU
            // 
            this.LICHCHIEU.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LICHCHIEU.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LICHCHIEU.Image = global::BTL_WINFORM.Properties.Resources.Actions_view_calendar_day_icon;
            this.LICHCHIEU.Location = new System.Drawing.Point(12, 142);
            this.LICHCHIEU.Name = "LICHCHIEU";
            this.LICHCHIEU.Size = new System.Drawing.Size(139, 124);
            this.LICHCHIEU.TabIndex = 8;
            this.LICHCHIEU.Text = "QUẢN LÝ LICH CHIẾU";
            this.LICHCHIEU.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LICHCHIEU.UseVisualStyleBackColor = false;
            this.LICHCHIEU.Click += new System.EventHandler(this.LICHCHIEU_Click);
            // 
            // NHANVIEN
            // 
            this.NHANVIEN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NHANVIEN.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NHANVIEN.Image = global::BTL_WINFORM.Properties.Resources.Manager_icon;
            this.NHANVIEN.Location = new System.Drawing.Point(157, 12);
            this.NHANVIEN.Name = "NHANVIEN";
            this.NHANVIEN.Size = new System.Drawing.Size(139, 124);
            this.NHANVIEN.TabIndex = 7;
            this.NHANVIEN.Text = "QUẢN LÝ NHÂN VIÊN";
            this.NHANVIEN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NHANVIEN.UseVisualStyleBackColor = false;
            this.NHANVIEN.Click += new System.EventHandler(this.NHANVIEN_Click);
            // 
            // BANVE
            // 
            this.BANVE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BANVE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BANVE.Image = global::BTL_WINFORM.Properties.Resources.Add_ticket_icon__1_;
            this.BANVE.Location = new System.Drawing.Point(12, 12);
            this.BANVE.Name = "BANVE";
            this.BANVE.Size = new System.Drawing.Size(139, 124);
            this.BANVE.TabIndex = 6;
            this.BANVE.Text = "BÁN VÉ";
            this.BANVE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BANVE.UseVisualStyleBackColor = false;
            this.BANVE.Click += new System.EventHandler(this.BANVE_Click);
            // 
            // chon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL_WINFORM.Properties.Resources.Background_dep_vector1;
            this.ClientSize = new System.Drawing.Size(312, 409);
            this.Controls.Add(this.DX);
            this.Controls.Add(this.THONGKE);
            this.Controls.Add(this.RAP);
            this.Controls.Add(this.LICHCHIEU);
            this.Controls.Add(this.NHANVIEN);
            this.Controls.Add(this.BANVE);
            this.Name = "chon";
            this.Text = "chon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DX;
        private System.Windows.Forms.Button THONGKE;
        private System.Windows.Forms.Button RAP;
        private System.Windows.Forms.Button LICHCHIEU;
        private System.Windows.Forms.Button NHANVIEN;
        private System.Windows.Forms.Button BANVE;
    }
}