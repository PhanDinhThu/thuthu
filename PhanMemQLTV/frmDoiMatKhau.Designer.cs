namespace PhanMemQLTV
{
    partial class frmDoiMatKhau
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
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.txtNhapLaiMKMoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkNhapLaiMatKhau = new System.Windows.Forms.CheckBox();
            this.chkMatKhauMoi = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(74, 106);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTenTaiKhoan.Multiline = true;
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(513, 35);
            this.txtTenTaiKhoan.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(76, 191);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(513, 36);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(74, 272);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMatKhauMoi.Multiline = true;
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(513, 36);
            this.txtMatKhauMoi.TabIndex = 2;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            this.txtMatKhauMoi.TextChanged += new System.EventHandler(this.txtMatKhauMoi_TextChanged);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.AutoSize = true;
            this.btnDoiMatKhau.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(75, 458);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(512, 46);
            this.btnDoiMatKhau.TabIndex = 4;
            this.btnDoiMatKhau.Text = "ĐỔI MẬT KHẨU";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // txtNhapLaiMKMoi
            // 
            this.txtNhapLaiMKMoi.Location = new System.Drawing.Point(74, 360);
            this.txtNhapLaiMKMoi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNhapLaiMKMoi.Multiline = true;
            this.txtNhapLaiMKMoi.Name = "txtNhapLaiMKMoi";
            this.txtNhapLaiMKMoi.Size = new System.Drawing.Size(513, 36);
            this.txtNhapLaiMKMoi.TabIndex = 3;
            this.txtNhapLaiMKMoi.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu hiện tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Xác nhân mật khẩu mới";
            // 
            // chkNhapLaiMatKhau
            // 
            this.chkNhapLaiMatKhau.AutoSize = true;
            this.chkNhapLaiMatKhau.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNhapLaiMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkNhapLaiMatKhau.Location = new System.Drawing.Point(468, 314);
            this.chkNhapLaiMatKhau.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkNhapLaiMatKhau.Name = "chkNhapLaiMatKhau";
            this.chkNhapLaiMatKhau.Size = new System.Drawing.Size(121, 21);
            this.chkNhapLaiMatKhau.TabIndex = 8;
            this.chkNhapLaiMatKhau.Text = "Show password";
            this.chkNhapLaiMatKhau.UseVisualStyleBackColor = true;
            this.chkNhapLaiMatKhau.CheckedChanged += new System.EventHandler(this.chkNhapLaiMatKhau_CheckedChanged);
            // 
            // chkMatKhauMoi
            // 
            this.chkMatKhauMoi.AutoSize = true;
            this.chkMatKhauMoi.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkMatKhauMoi.Location = new System.Drawing.Point(466, 402);
            this.chkMatKhauMoi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkMatKhauMoi.Name = "chkMatKhauMoi";
            this.chkMatKhauMoi.Size = new System.Drawing.Size(121, 21);
            this.chkMatKhauMoi.TabIndex = 7;
            this.chkMatKhauMoi.Text = "Show password";
            this.chkMatKhauMoi.UseVisualStyleBackColor = true;
            this.chkMatKhauMoi.CheckedChanged += new System.EventHandler(this.chkMatKhauMoi_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(230, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "ĐỔI MẬT KHẨU";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(652, 595);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkNhapLaiMatKhau);
            this.Controls.Add(this.chkMatKhauMoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhapLaiMKMoi);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoiMatKhau";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.TextBox txtNhapLaiMKMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkNhapLaiMatKhau;
        private System.Windows.Forms.CheckBox chkMatKhauMoi;
        private System.Windows.Forms.Label label5;
    }
}