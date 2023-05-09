using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Sử dụng thư viện để làm việc SQL server
using DoAnQLBH.Class;
namespace DoAnQLBH
{
    public partial class FrmNhanVien : Form
    {
        DataTable tblNhanVien;
        string txtSua = "";
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            LoadDataGridView();
            dgvNV.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            btnBoQua.Enabled = false;
            btnCNDL.Enabled = false;
            txtMaNV.MaxLength = 20;
            txtTenNV.MaxLength = 20;
            txtDiaChiNV.MaxLength = 20;
       
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblNhanVien";
            tblNhanVien = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvNV.DataSource = tblNhanVien; //Nguồn dữ liệu            
            dgvNV.Columns[0].HeaderText = "Mã nhân viên";
            dgvNV.Columns[1].HeaderText = "Tên nhân viên";
            dgvNV.Columns[2].HeaderText = "Giới tính";
            dgvNV.Columns[3].HeaderText = "Địa chỉ";
            dgvNV.Columns[4].HeaderText = "Ngày sinh";
            dgvNV.Columns[5].HeaderText = "Số điện thoại";

            dgvNV.Columns[0].Width = 140;
            dgvNV.Columns[1].Width = 160;
            dgvNV.Columns[2].Width = 120;
            dgvNV.Columns[3].Width = 140;
            dgvNV.Columns[4].Width = 140;
            dgvNV.Columns[5].Width = 140;


            dgvNV.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvNV.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvNV_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return;
            }
            if (tblNhanVien.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNV.Text = dgvNV.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            txtTenNV.Text = dgvNV.CurrentRow.Cells["TenNhanVien"].Value.ToString();
            if (dgvNV.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nữ")
            {
                txtGioiTinh.Checked = false;
            }
            else
            {
                txtGioiTinh.Checked = true;
            }
            txtDiaChiNV.Text = dgvNV.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtNgaySinhNV.Text = dgvNV.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txtSoDienThoaiNV.Text = dgvNV.CurrentRow.Cells["SoDienTHoai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
            txtMaNV.Enabled = true;
            txtSua = txtMaNV.Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnCNDL.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMaNV.Enabled = true; //cho phép nhập mới
            txtMaNV.Focus();
        }

        private void ResetValue()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtNgaySinhNV.Text = "";
            txtDiaChiNV.Text = "";
            txtSoDienThoaiNV.Text = "";
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCNDL_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaNV.Text.Trim().Length == 0) //Nếu chưa nhập mã nv
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0) //Nếu chưa nhập tên sp
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return;
            }
            /*if (txtGioiTinh.Text.Trim().Length == 0) //Nếu chưa nhập Gioi tinh
            {
                MessageBox.Show("Bạn phải nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGioiTinh.Focus();
                return;
            }*/
            if (txtDiaChiNV.Text.Trim().Length == 0) //Nếu chưa nhập ĐCNV
            {
                MessageBox.Show("Bạn phải nhập địa chỉ nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChiNV.Focus();
                return;
            }
            if (txtNgaySinhNV.Text.Trim().Length == 0) //Nếu chưa nhap ngay sinh
            {
                MessageBox.Show("Bạn phải nhập ngày sinh nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgaySinhNV.Focus();
                return;
            }
            if (txtSoDienThoaiNV.Text.Trim().Length == 0) //Nếu chưa nhap SDT 
            {
                MessageBox.Show("Bạn phải nhập Số điện thoại nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoDienThoaiNV.Focus();
                return;
            }
            sql = "Select MaSanPham From tblSanPham where MaSanPham=N'" + txtMaNV.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã NV này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            string GT="";
            if (txtGioiTinh.Checked == true)
            {
                GT = "Nam";
            }
            else
            {
                GT = "Nữ";
            }
            if (MessageBox.Show("Bạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "INSERT INTO tblNhanVien VALUES(N'" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'" + GT + "',N'" + txtDiaChiNV.Text + "',N'" + txtNgaySinhNV.Text + "',N'" + txtSoDienThoaiNV.Text + "')";
                Functions.RunSQL(sql); //Thực hiện câu lệnh sql
                LoadDataGridView(); //Nạp lại DataGridView
                ResetValue();
            }
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnCNDL.Enabled = false;
            txtMaNV.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblNhanVien WHERE MaNhanVien=N'" + txtMaNV.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (txtMaNV.Text.Trim().Length == 0) //Nếu chưa nhập mã nv
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0) //Nếu chưa nhập tên sp
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return;
            }
            /*if (txtGioiTinh.Text.Trim().Length == 0) //Nếu chưa nhập Gioi tinh
            {
                MessageBox.Show("Bạn phải nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGioiTinh.Focus();
                return;
            }*/
            if (txtDiaChiNV.Text.Trim().Length == 0) //Nếu chưa nhập ĐCNV
            {
                MessageBox.Show("Bạn phải nhập địa chỉ nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChiNV.Focus();
                return;
            }
            if (txtNgaySinhNV.Text.Trim().Length == 0) //Nếu chưa nhap ngay sinh
            {
                MessageBox.Show("Bạn phải nhập ngày sinh nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgaySinhNV.Focus();
                return;
            }
            if (txtSoDienThoaiNV.Text.Trim().Length == 0) //Nếu chưa nhap SDT 
            {
                MessageBox.Show("Bạn phải nhập Số điện thoại nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoDienThoaiNV.Focus();
                return;
            }
            string GT = "";
            if (txtGioiTinh.Checked == true)
            {
                GT = "Nam";
            }
            else
            {
                GT = "Nữ";
            }
            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
                if (txtSua==txtMaNV.Text)
            {
                sql = "UPDATE tblNhanVien SET TenNhanVien=N'" + txtTenNV.Text.ToString() + "', GioiTinh=N'" + GT + "', DiaChi=N'" + txtDiaChiNV.Text + "', NgaySinh=N'" + txtNgaySinhNV.Text + "' , SoDienThoai=N'" + txtSoDienThoaiNV.Text + "'  WHERE MaNhanVien=N'" + txtMaNV.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
            }
            else
            {
                sql = "SELECT * FROM tblNhanVien WHERE MaNhanVien=N'" + txtMaNV.Text + "'";
                bool ktMaSP = Functions.RunSQLD(sql);
                sql = "SELECT * FROM tblDonHang WHERE MaNhanVien=N'" + txtSua + "'";
                bool ktMaCTHD = Functions.RunSQLD(sql);
                if (ktMaCTHD)
                {
                    MessageBox.Show("Mã nhân viên không thể sửa do đơn hàng đang mua trước đó chưa hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaNV.Focus();
                    return;
                }
                else if (ktMaSP)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaNV.Focus();
                    return;
                }
                else
                {
                    sql = "DELETE tblNhanVien WHERE MaNhanVien=N'" + txtSua + "'";
                    Functions.RunSQL(sql);

                    sql = "INSERT INTO tblNhanVien VALUES(N'" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'" + GT + "',N'" + txtDiaChiNV.Text + "',N'" + txtNgaySinhNV.Text + "',N'" + txtSoDienThoaiNV.Text + "')";
                    Functions.RunSQL(sql); //Thực hiện câu lệnh sql
                    LoadDataGridView(); //Nạp lại DataGridView
                    ResetValue();
                }
            }


            btnBoQua.Enabled = false;
            btnCNDL.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnCNDL.Enabled = false;
            txtMaNV.Enabled = false;
        }
    }
}
