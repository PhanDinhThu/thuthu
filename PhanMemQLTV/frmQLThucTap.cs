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
    public partial class frmQLThucTap : Form
    {
        public frmQLThucTap()
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
            dataGridViewDSTT.DataSource = myTable;
            return myTable;
        }

        // Phương thức thiết lập Controls
        private void setControls(bool edit)
        {
            txtSTT.Enabled = edit;
            txtMaSV.Enabled = edit;
            txtGiangVien.Enabled = edit;
            txtTenDeTai.Enabled = edit;
            txtCongTy.Enabled = edit;
            dtmNgayBatDau.Enabled = edit;
            dtmNgayKetThuc.Enabled = edit;
            txtGhiChu.Enabled = edit;
           
        }
        

        private void frmQLThucTap_Load(object sender, EventArgs e)
        {
            string cauTruyVan = "select * from tblThongTinThucTap";
            dataGridViewDSTT.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSTT.AutoGenerateColumns = false;
            myConnection.Close();
            setControls(false);
            dataGridViewDSTT.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            radMaSinhVien.Checked = true;
            // radHoTen.Checked = true;
        }
        // Phương thức hiển thị các thuộc tính bảng TT lên txt
        public string sTT, maSV, giangVien, tenDeTai, congTy, ngayBatDau, ngayKetThuc, ghiChu;
        private void dataGridViewDSTT_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try

            {
                int row = e.RowIndex;
                txtSTT.Text = myTable.Rows[row]["STT"].ToString();
                sTT = txtSTT.Text;
                txtMaSV.Text = myTable.Rows[row]["MaSinhVien"].ToString();
                maSV = txtMaSV.Text;
                txtGiangVien.Text = myTable.Rows[row]["GiangVienHuongDan"].ToString();
                giangVien = txtGiangVien.Text;
                txtTenDeTai.Text = myTable.Rows[row]["DeTaiThucTap"].ToString();
                tenDeTai = txtTenDeTai.Text;
                txtCongTy.Text = myTable.Rows[row]["CongTyThucTap"].ToString();
                congTy = txtCongTy.Text;
                dtmNgayBatDau.Text = myTable.Rows[row]["NgayBatDauThucTap"].ToString();
                ngayBatDau = dtmNgayBatDau.Text;
                dtmNgayKetThuc.Text = myTable.Rows[row]["NgayKetThucThucTap"].ToString();
                ngayKetThuc = dtmNgayKetThuc.Text;
                txtGhiChu.Text = myTable.Rows[row]["GhiChu"].ToString();
                ghiChu = txtGhiChu.Text;

            }
            catch
            {

            }
        }
     

        // Phương thức thêm TT
        public int xuly;
        private void btnThem_Click(object sender, EventArgs e)
        {
            setControls(true);
            txtSTT.Text = "";
            txtMaSV.Text = "";
            txtGiangVien.Text = "";
            txtTenDeTai.Text = "";
            txtCongTy.Text = "";
            dtmNgayBatDau.Text = "";
            dtmNgayKetThuc.Text = "";
            txtGhiChu.Text = "";

            txtMaSV.Focus();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            xuly = 0;
            dataGridViewDSTT.Enabled = false;
        }

        

        // Phương thức sửa thông tin TT
        private void suaTT()
        {
            setControls(true);
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            txtSTT.Enabled = false;

            txtMaSV.Focus();
            dataGridViewDSTT.Enabled = false;

            xuly = 1;
        }

        
        private void btnSua_Click(object sender, EventArgs e)
        {
            suaTT();
        }

        private void radMaSinhVien_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radCongTy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void xoaTT()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa không?.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string xoadongsql = "delete from tblThongTinThucTap where STT='" + txtSTT.Text + "'";
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
            string cauTruyVan = "select * from tblThongTinThucTap";
            dataGridViewDSTT.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSTT.AutoGenerateColumns = false;
            myConnection.Close();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaTT();
        }
        // Lưu
        private void themTT()
        {
            try
            {
                string themdongsql = "insert into tblThongTinThucTap values ('" + txtSTT.Text + "','" + txtMaSV.Text + "',N'" + txtGiangVien.Text + "',N'" + txtTenDeTai.Text + "','" + txtCongTy.Text + "','" + dtmNgayKetThuc.Text + "','" + dtmNgayBatDau.Text + "',N'" + txtGhiChu.Text + "')";
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
                errMaSV.SetError(txtMaSV, "Vui lòng nhập Mã Sinh Viên");
            }
            else
            {
                errMaSV.Clear();
            }
            if (txtGiangVien.Text == "")
            {
                errGiangVien.SetError(txtGiangVien, "Vui lòng nhập tên giảng viên");
            }
            else
            {
                errGiangVien.Clear();
            }

            if (txtTenDeTai.Text == "")
            {
                errTenDeTai.SetError(txtTenDeTai, "Vui lòng nhập tên đề tài");
            }
            else
            {
                errTenDeTai.Clear();
            }

            if (txtCongTy.Text == "")
            {
                errCongTy.SetError(txtCongTy, "Vui lòng nhập tên công ty");
            }
            else
            {
                errCongTy.Clear();
            }

            if (txtGhiChu.Text == "")
            {
                errGhiChu.SetError(txtGhiChu, "Vui lòng nhập ghi chú");
            }
            else
            {
                errGhiChu.Clear();
            }

            if (txtSTT.Text.Length > 0 && txtMaSV.Text.Length > 0 && txtGiangVien.Text.Length > 0 && txtTenDeTai.Text.Length > 0 && txtCongTy.Text.Length > 0 && dtmNgayBatDau.Text.Length > 0 && dtmNgayKetThuc.Text.Length > 0 && txtGhiChu.Text.Length > 0)
            {
                if (xuly == 0)
                {
                    themTT();
                }
                else if (xuly == 1)
                {
                    try
                    {
                        string capnhatdongsql;

                        capnhatdongsql = "update tblThongTinThucTap set MaSinhVien=N'" + txtMaSV.Text + "',GiangVienHuongDan=N'" + txtGiangVien.Text + "',DeTaiThucTap=N'" + txtTenDeTai.Text + "',CongTyThucTap='" + txtCongTy.Text + "',NgayBatDauThucTap='" + dtmNgayBatDau.Text + "',NgayKetThucThucTap='" + dtmNgayKetThuc.Text + "',GhiChu=N'" + txtGhiChu.Text + "'where STT='" + txtSTT.Text + "'";
                        ketnoi(capnhatdongsql);
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("Sửa thông tin thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Sửa không thành công.\nVui lòng kiểm tra lại thông tin.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                string cauTruyVan = "select * from tblThongTinThucTap";
                dataGridViewDSTT.DataSource = ketnoi(cauTruyVan);
                dataGridViewDSTT.AutoGenerateColumns = false;
                myConnection.Close();
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                setControls(false);
                dataGridViewDSTT.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (txtMaSV.Text.Length == 0)
                    txtMaSV.Focus();
                else if (txtGiangVien.Text.Length == 0)
                    txtGiangVien.Focus();
                else if (txtTenDeTai.Text.Length == 0)
                    txtTenDeTai.Focus();
                else if (txtCongTy.Text.Length == 0)
                    txtCongTy.Focus();
                else if (txtGhiChu.Text.Length == 0)
                    txtGhiChu.Focus();

            }
        }

        // Phương thức nút hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtSTT.Text = sTT;
            txtMaSV.Text = maSV;
            txtGiangVien.Text = giangVien;
            txtTenDeTai.Text = tenDeTai;
            txtCongTy.Text = congTy;
            dtmNgayBatDau.Text = ngayBatDau;
            dtmNgayKetThuc.Text = ngayBatDau;
            txtGhiChu.Text = ghiChu;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            setControls(false);
            dataGridViewDSTT.Enabled = true;
            errGhiChu.Clear();
            errTenDeTai.Clear();
            errMaSV.Clear();
            errGiangVien.Clear();
            errCongTy.Clear();
            errNgayKetThuc.Clear();
            errNgayBatDau.Clear();
        }
        // Thoát form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtNDTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (radMaSinhVien.Checked)
            {
                string timkiem = "select * from tblThongTinThucTap where MaSinhVien like '%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiem);
                myCommand.ExecuteNonQuery();
                dataGridViewDSTT.DataSource = ketnoi(timkiem);
                dataGridViewDSTT.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radCongTy.Checked)
            {
                string timkiem = "select * from tblThongTinThucTap where CongTyThucTap like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiem);
                myCommand.ExecuteNonQuery();
                dataGridViewDSTT.DataSource = ketnoi(timkiem);
                dataGridViewDSTT.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radNgayBatDau.Checked)
            {
                string timkiem = "select * from tblThongTinThucTap where NgayBatDauThucTap like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiem);
                myCommand.ExecuteNonQuery();
                dataGridViewDSTT.DataSource = ketnoi(timkiem);
                dataGridViewDSTT.AutoGenerateColumns = false;
                myConnection.Close();
            }
        }


    }
}
