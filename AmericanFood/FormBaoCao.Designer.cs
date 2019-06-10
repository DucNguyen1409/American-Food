namespace AmericanFood
{
    partial class FormBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaoCao));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBaoCao = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnThongKeDoanhThu = new System.Windows.Forms.Button();
            this.btnThongKeSoLuong = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThongTinCaNhan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(1, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(959, 747);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnThongTinCaNhan);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.lblBaoCao);
            this.panel1.Controls.Add(this.btnDangKy);
            this.panel1.Controls.Add(this.btnDoiMatKhau);
            this.panel1.Controls.Add(this.btnThongKeDoanhThu);
            this.panel1.Controls.Add(this.btnThongKeSoLuong);
            this.panel1.Location = new System.Drawing.Point(966, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 748);
            this.panel1.TabIndex = 1;
            // 
            // lblBaoCao
            // 
            this.lblBaoCao.AutoSize = true;
            this.lblBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoCao.Location = new System.Drawing.Point(37, 67);
            this.lblBaoCao.Name = "lblBaoCao";
            this.lblBaoCao.Size = new System.Drawing.Size(230, 29);
            this.lblBaoCao.TabIndex = 4;
            this.lblBaoCao.Text = "Báo Cáo Doanh Thu";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(160, 310);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(126, 106);
            this.btnDangKy.TabIndex = 3;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(9, 310);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(126, 106);
            this.btnDoiMatKhau.TabIndex = 2;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            // 
            // btnThongKeDoanhThu
            // 
            this.btnThongKeDoanhThu.BackColor = System.Drawing.Color.Brown;
            this.btnThongKeDoanhThu.Location = new System.Drawing.Point(160, 175);
            this.btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            this.btnThongKeDoanhThu.Size = new System.Drawing.Size(126, 106);
            this.btnThongKeDoanhThu.TabIndex = 1;
            this.btnThongKeDoanhThu.Text = "THỐNG KÊ DOANH THU";
            this.btnThongKeDoanhThu.UseVisualStyleBackColor = false;
            // 
            // btnThongKeSoLuong
            // 
            this.btnThongKeSoLuong.BackColor = System.Drawing.Color.Brown;
            this.btnThongKeSoLuong.Location = new System.Drawing.Point(9, 175);
            this.btnThongKeSoLuong.Name = "btnThongKeSoLuong";
            this.btnThongKeSoLuong.Size = new System.Drawing.Size(126, 106);
            this.btnThongKeSoLuong.TabIndex = 0;
            this.btnThongKeSoLuong.Text = "THỐNG KÊ SỐ LƯỢNG";
            this.btnThongKeSoLuong.UseVisualStyleBackColor = false;
            this.btnThongKeSoLuong.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Red;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(161, 557);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(125, 91);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.Location = new System.Drawing.Point(161, 433);
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.Size = new System.Drawing.Size(126, 106);
            this.btnThongTinCaNhan.TabIndex = 13;
            this.btnThongTinCaNhan.Text = "Thông Tin Cá Nhân";
            this.btnThongTinCaNhan.UseVisualStyleBackColor = true;
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormBaoCao";
            this.Text = "FormBaoCao";
            this.Load += new System.EventHandler(this.FormBaoCao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThongKeSoLuong;
        private System.Windows.Forms.Label lblBaoCao;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnThongKeDoanhThu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThongTinCaNhan;
    }
}