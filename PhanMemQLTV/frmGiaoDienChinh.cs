using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQLTV
{
    public partial class frmGiaoDienChinh : Form
    {
        public frmGiaoDienChinh()
        {
            InitializeComponent();
        }

        private void DongForm(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void quảnLýSinhViênToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmQLSinhVien QLSV = new frmQLSinhVien();
            QLSV.Show();
        }

        private void qLTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLThucTap QLTT = new frmQLThucTap();
            QLTT.Show();
        }
        

        private void frmGiaoDienChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
             }

        private void đổiMậtKhậuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau DoiMKTT = new frmDoiMatKhau();
            DoiMKTT.Show();
        }

        private void frmGiaoDienChinh_Load(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            frmDangNhap Dn = new frmDangNhap();
            Dn.FormClosed += new FormClosedEventHandler(DongForm);
            this.Hide();
            Dn.Show();

        }

       private void mnuHeThong_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
          
        }

        
    }
}
