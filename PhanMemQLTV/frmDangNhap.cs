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
using System.Configuration;

namespace PhanMemQLTV
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlCommand myCommand;

        //Đóng form
        private void DongForm(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // Kiểm tra điều kiện tài khoản
        private int kq = 0;
        private void kiemTraDK()
        {
            if (txtTenDangNhap.Text.Length > 0 && txtMatKhau.Text.Length > 0)
                kq = 1;
        }

        // Kiểm tra tài khoản
        private int x = 0; 
        //Kiểm tra tài khoản
        private void xacThucTK()
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string strCauTruyVan = "select count(*) from tblDangNhap where TenTaiKhoan=@acc and MatKhau=@pass";
            myCommand = new SqlCommand(strCauTruyVan, myConnection);
            myCommand.Parameters.Add(new SqlParameter("@acc", txtTenDangNhap.Text));
            myCommand.Parameters.Add(new SqlParameter("@pass", txtMatKhau.Text));
            x = (int)myCommand.ExecuteScalar();
            myConnection.Close();
        }

       
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            kiemTraDK();
            if (kq == 1)
            {
                        xacThucTK();
                        if (x == 1)
                        {
                            MessageBox.Show("Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmGiaoDienChinh GiaoDienChinh = new frmGiaoDienChinh();
                            GiaoDienChinh.FormClosed += new FormClosedEventHandler(DongForm);
                            this.Hide();
                            GiaoDienChinh.Show();
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.\nVui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtTenDangNhap.Clear();
                            txtMatKhau.Clear();
                            txtTenDangNhap.Focus();
                
                }
            

            }
            else
                MessageBox.Show("Vui lòng nhập Tên đăng nhập và Mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void lblMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
        
        }
    }
}
