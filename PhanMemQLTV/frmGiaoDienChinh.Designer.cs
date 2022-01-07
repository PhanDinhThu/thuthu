namespace PhanMemQLTV
{
    partial class frmGiaoDienChinh
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.mnuHeThong = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhậuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSinhViênToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tRỢGIÚPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gIỚITHIỆUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLTTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.mnuHeThong.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.Gray;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Black;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 584);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1180, 86);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ THÔNG TIN THỰC TẬP ";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.BackColor = System.Drawing.Color.OrangeRed;
            this.mnuHeThong.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuHeThong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnuHeThong.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mnuHeThong.ImageScalingSize = new System.Drawing.Size(50, 40);
            this.mnuHeThong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.quảnLýSinhViênToolStripMenuItem1,
            this.qLTTToolStripMenuItem,
            this.tRỢGIÚPToolStripMenuItem,
            this.gIỚITHIỆUToolStripMenuItem});
            this.mnuHeThong.Location = new System.Drawing.Point(176, 114);
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuHeThong.Size = new System.Drawing.Size(1060, 31);
            this.mnuHeThong.TabIndex = 0;
            this.mnuHeThong.Text = "menuStrip1";
            this.mnuHeThong.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuHeThong_ItemClicked);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhậuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(231, 27);
            this.tàiKhoảnToolStripMenuItem.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // đổiMậtKhậuToolStripMenuItem
            // 
            this.đổiMậtKhậuToolStripMenuItem.Name = "đổiMậtKhậuToolStripMenuItem";
            this.đổiMậtKhậuToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.đổiMậtKhậuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhậuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhậuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // quảnLýSinhViênToolStripMenuItem1
            // 
            this.quảnLýSinhViênToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.quảnLýSinhViênToolStripMenuItem1.Name = "quảnLýSinhViênToolStripMenuItem1";
            this.quảnLýSinhViênToolStripMenuItem1.Size = new System.Drawing.Size(219, 27);
            this.quảnLýSinhViênToolStripMenuItem1.Text = "QUẢN LÝ SINH VIÊN";
            this.quảnLýSinhViênToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýSinhViênToolStripMenuItem1_Click_1);
            // 
            // tRỢGIÚPToolStripMenuItem
            // 
            this.tRỢGIÚPToolStripMenuItem.Name = "tRỢGIÚPToolStripMenuItem";
            this.tRỢGIÚPToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.tRỢGIÚPToolStripMenuItem.Text = "TRỢ GIÚP";
            // 
            // gIỚITHIỆUToolStripMenuItem
            // 
            this.gIỚITHIỆUToolStripMenuItem.Name = "gIỚITHIỆUToolStripMenuItem";
            this.gIỚITHIỆUToolStripMenuItem.Size = new System.Drawing.Size(110, 23);
            this.gIỚITHIỆUToolStripMenuItem.Text = "GIỚI THIỆU";
            // 
            // qLTTToolStripMenuItem
            // 
            this.qLTTToolStripMenuItem.Name = "qLTTToolStripMenuItem";
            this.qLTTToolStripMenuItem.Size = new System.Drawing.Size(265, 23);
            this.qLTTToolStripMenuItem.Text = "QUẢN LÝ THÔNG TIN THỰC TẬP";
            this.qLTTToolStripMenuItem.Click += new System.EventHandler(this.qLTTToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-1, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1124, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "MEMU HỆ THỐNG";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmGiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1180, 670);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.mnuHeThong);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuHeThong;
            this.MaximizeBox = false;
            this.Name = "frmGiaoDienChinh";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiaoDienChinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGiaoDienChinh_FormClosing);
            this.Load += new System.EventHandler(this.frmGiaoDienChinh_Load);
            this.mnuHeThong.ResumeLayout(false);
            this.mnuHeThong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.MenuStrip mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhậuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSinhViênToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem tRỢGIÚPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gIỚITHIỆUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLTTToolStripMenuItem;
    }
}