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
    public partial class frmQLSinhVien : Form
    {
        public frmQLSinhVien()
        {
            InitializeComponent();
        }

        // Khai báo 
        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection; // kết nối tới csdl
        private SqlDataAdapter myDataAdapter;   // Vận chuyển csdl qa DataSet
        private DataTable myTable;  // Dùng để lưu bảng lấy từ c#
        SqlCommand myCommand;   // Thực hiện cách lệnh truy vấn

        // Phương thức kết nối
        private DataTable ketnoi(string truyvan)
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            dataGridViewDSSV.DataSource = myTable;
            return myTable;
        }

        // Phương thức thiết lập Controls
        private void setControls(bool edit)
        {
            txtMaSV.Enabled = edit;
            txtHoTen.Enabled = edit;
            dtmNgaySinh.Enabled = edit;
            cboGioiTinh.Enabled = edit;
            txtNganh.Enabled = edit;
            txtSoDT.Enabled = edit;
            txtGhiChu.Enabled = edit;
            cboKhoa.Enabled = edit;
        }

        // Load
        private void frmQLSinhVien_Load(object sender, EventArgs e)
        
        {
            string cauTruyVan = "select * from tblSinhVien";
            dataGridViewDSSV.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSSV.AutoGenerateColumns = false;
            myConnection.Close();
            setControls(false);
            dataGridViewDSSV.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            radMaSinhVien.Checked = true;
           // radHoTen.Checked = true;
            
        }

        // Phương thức hiển thị các thuộc tính bảng Sinh Viên lên txt
        public string maSV, hoTen, gioiTinh, ngaySinh, Nganh, SDT, Khoa, ghiChu; 
        private void dataGridViewDSSV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtMaSV.Text = myTable.Rows[row]["MaSinhVien"].ToString();
                maSV = txtMaSV.Text;
                txtHoTen.Text = myTable.Rows[row]["HoTen"].ToString();
                hoTen = txtHoTen.Text;
                cboGioiTinh.Text = myTable.Rows[row]["GioiTinh"].ToString();
                gioiTinh = cboGioiTinh.Text;
                dtmNgaySinh.Text = myTable.Rows[row]["NgaySinh"].ToString();
                ngaySinh = dtmNgaySinh.Text;
                txtSoDT.Text = myTable.Rows[row]["SoDienThoai"].ToString();
                SDT = txtSoDT.Text;
                txtNganh.Text = myTable.Rows[row]["Nganh"].ToString();
                Nganh = txtNganh.Text;
                cboKhoa.Text = myTable.Rows[row]["Khoa"].ToString();
                Khoa = cboKhoa.Text;
                txtGhiChu.Text = myTable.Rows[row]["GhiChu"].ToString();
                ghiChu = txtGhiChu.Text;
                
            }
            catch
            {

            }
        }

       
        // Phương thức thêm SV
        public int xuly;
        private void btnThem_Click(object sender, EventArgs e)
        {
            setControls(true);
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            txtSoDT.Text = "";
            txtNganh.Text = "";
            cboGioiTinh.Text = "Nam";
            dtmNgaySinh.Text = "";
            cboKhoa.Text = "Khóa 42";
            txtGhiChu.Text = "";
         
            txtMaSV.Focus();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            xuly = 0;
            dataGridViewDSSV.Enabled = false;
        }

        // Phương thức sửa thông tin SV
        private void suaSV()
        {
            setControls(true);
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            txtMaSV.Enabled = false;

            txtHoTen.Focus();
            dataGridViewDSSV.Enabled = false;
          
            xuly = 1;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            suaSV();
        }


        // Phương thức xóa SV
        private void xoaSV()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa sinh viên không?.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string xoadongsql = "delete from tblSinhVien where MaSinhVien='" + txtMaSV.Text + "'";
                    ketnoi(xoadongsql);
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnXoa.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa không thành công.\nSinh Viên này đang trong thời gian thực tập!!!.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            string cauTruyVan = "select * from tblSinhVien";
            dataGridViewDSSV.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSSV.AutoGenerateColumns = false;
            myConnection.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaSV();
        }

        // Lưu
        private void themSV()
        {
            try
            {
                string themdongsql = "insert into  tblSinhVien values ('" + txtMaSV.Text + "',N'" + txtHoTen.Text + "',N'" + cboGioiTinh.Text + "','" + dtmNgaySinh.Text + "','" + txtSoDT.Text + "',N'" + txtNganh.Text + "',N'" + cboKhoa.Text + "',N'" + txtGhiChu.Text + "')"; 
                MessageBox.Show("Thêm sinh viên thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "")
            {
                errHoTen.SetError(txtMaSV, "Vui lòng nhập Mã Sinh Viên");
            }
            else
            {
                errMaSV.Clear();
            }
            if (txtHoTen.Text == "")
            {
                errHoTen.SetError(txtHoTen, "Vui lòng nhập Họ Tên");
            }
            else
            {
                errHoTen.Clear();
            }

            if (txtSoDT.Text == "")
            {
                errSDT.SetError(txtSoDT, "Vui lòng nhập Số điện thoại");
            }
            else
            {
                errSDT.Clear();
            }

            if (txtNganh.Text == "")
            {
                errNganh.SetError(txtNganh, "Vui lòng nhập Ngành Học");
            }
            else
            {
                errNganh.Clear();
            }

            if (txtGhiChu.Text == "")
            {
                errGhiChu.SetError(txtGhiChu, "Vui lòng nhập ghi chú");
            }
            else
            {
                errGhiChu.Clear();
            }

            

            if (cboGioiTinh.Text == "")
            {
                errGT.SetError(cboGioiTinh, "Vui lòng chọn Giới tính");
            }
            else
            {
                errGT.Clear();
            }

            if (cboKhoa.Text == "")
            {
                errKhoa.SetError(cboKhoa, "Vui lòng nhập Khóa");
            }
            else
            {
                errKhoa.Clear();
            }
            int ktSDT;
            bool isNumberSDT = int.TryParse(txtSoDT.Text, out ktSDT);
            if (isNumberSDT==false || txtSoDT.Text.Length>12)
            {
               // MessageBox.Show("Vui lòng nhập số điện thoại.");
            }

            if (txtMaSV.Text.Length > 0 && txtHoTen.Text.Length > 0 && txtNganh.Text.Length > 0 && isNumberSDT == true && dtmNgaySinh.Text.Length > 0 && cboGioiTinh.Text.Length > 0 && cboKhoa.Text.Length > 0)
                {
                if(xuly==0)
                {
                    themSV();
                }
                else if(xuly==1)
                {
                    try
                    {
                        string capnhatdongsql;
            
                        capnhatdongsql = "update tblSinhVien set HoTen=N'" + txtHoTen.Text + "',GioiTinh=N'" + cboGioiTinh.Text + "',NgaySinh='" + dtmNgaySinh.Text + "',Nganh=N'" + txtNganh.Text + "',SoDienThoai='" + txtSoDT.Text + "',Khoa=N'" + cboKhoa.Text + "',GhiChu=N'" + txtGhiChu.Text + "'where MaSinhVien='" + txtMaSV.Text + "'";
                        ketnoi(capnhatdongsql);
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("Sửa thông tin thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Sửa không thành công.\nVui lòng kiểm tra lại thông tin.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                string cauTruyVan = "select * from tblSinhVien";
                dataGridViewDSSV.DataSource = ketnoi(cauTruyVan);
                dataGridViewDSSV.AutoGenerateColumns = false;
                myConnection.Close();
                btnLuu.Enabled=false;
                btnHuy.Enabled=false;
                btnThem.Enabled=true;
                btnSua.Enabled=true;
                btnXoa.Enabled=true;
                setControls(false);
                dataGridViewDSSV.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (txtHoTen.Text.Length == 0)
                    txtHoTen.Focus();
                else if (txtNganh.Text.Length == 0)
                    txtNganh.Focus();
                else if (txtSoDT.Text.Length == 0)
                    txtSoDT.Focus();
                else if (txtGhiChu.Text.Length == 0)
                    txtGhiChu.Focus();
               
            }
        }

        // Phương thức nút hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = maSV;
            txtHoTen.Text = hoTen;
            txtSoDT.Text = SDT;
            txtNganh.Text = Nganh;
            cboGioiTinh.Text = gioiTinh;
            dtmNgaySinh.Text = ngaySinh;
            cboKhoa.Text = Khoa;
            txtGhiChu.Text = ghiChu;
         
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            setControls(false);
            dataGridViewDSSV.Enabled = true;
            errGhiChu.Clear();
            errSDT.Clear();
            errMaSV.Clear();
            errHoTen.Clear();
            errNganh.Clear();
            errKhoa.Clear();
            errGT.Clear();
        }

        // Thoát form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Tìm kiếm 
        private void txtNDTimKiem_TextChanged(object sender, EventArgs e)
        {
           
            
            if (radMaSinhVien.Checked)
            {
                string timkiem = "select * from tblSinhVien where MaSinhVien like '%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiem);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSV.DataSource = ketnoi(timkiem);
                dataGridViewDSSV.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radHoTen.Checked)
            {
                string timkiem = "select * from tblSinhVien where HoTen like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiem);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSV.DataSource = ketnoi(timkiem);
                dataGridViewDSSV.AutoGenerateColumns = false;
                myConnection.Close();
            }
        }

        
        private void radHoTen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radMaSinhVien_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void txtMaDG_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
