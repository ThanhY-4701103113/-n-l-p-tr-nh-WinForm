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
    public partial class FrmKhachHang : Form
    {
        DataTable tblKhachHang;
        string txtSua = "";
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            dgvKH.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            txtMaKH.Enabled = false;
            btnCNDL.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaKH.MaxLength = 20;
            txtDiaChiKH.MaxLength = 20;
            txtTenKH.MaxLength = 20;
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblKhachHang";
            tblKhachHang = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvKH.DataSource = tblKhachHang; //Nguồn dữ liệu            
            dgvKH.Columns[0].HeaderText = "Mã khách hàng";
            dgvKH.Columns[1].HeaderText = "Tên khách hàng";
            dgvKH.Columns[2].HeaderText = "Địa chỉ";
            dgvKH.Columns[3].HeaderText = "Số điên thoại";

            dgvKH.Columns[0].Width = 160;
            dgvKH.Columns[1].Width = 160;
            dgvKH.Columns[2].Width = 160;
            dgvKH.Columns[3].Width = 160;


            dgvKH.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvKH.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp

        }

        private void dgvKH_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return;
            }
            if (tblKhachHang.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaKH.Text = dgvKH.CurrentRow.Cells["MaKhachHang"].Value.ToString();
            txtTenKH.Text = dgvKH.CurrentRow.Cells["TenKhachHang"].Value.ToString();
            txtDiaChiKH.Text = dgvKH.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtSoDienThoaiKH.Text = dgvKH.CurrentRow.Cells["SoDienThoai"].Value.ToString();
            
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMaKH.Enabled = true;
            txtSua = txtMaKH.Text;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
 
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnCNDL.Enabled = false;
            txtMaKH.Enabled = false;
        }
        private void ResetValue()
        {
            txtMaKH .Text= "";
            txtTenKH.Text = "";
            txtDiaChiKH.Text = "";
            txtSoDienThoaiKH.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnCNDL.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMaKH.Enabled = true; //cho phép nhập mới
            txtMaKH.Focus();
        }

        private void btnCNDL_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaKH.Text.Trim().Length == 0) //Nếu chưa nhập mã kh
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return;
            }
            if (txtTenKH.Text.Trim().Length == 0) //Nếu chưa nhập tên KH
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKH.Focus();
                return;
            }
            if (txtDiaChiKH.Text.Trim().Length == 0) //Nếu chưa nhập ĐC KH
            {
                MessageBox.Show("Bạn phải nhập địa chỉ khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChiKH.Focus();
                return;
            }
            if (txtSoDienThoaiKH.Text.Trim().Length == 0) //Nếu chưa nhap SDT KH
            {
                MessageBox.Show("Bạn phải nhập Số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoDienThoaiKH.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "INSERT INTO tblKhachHang VALUES(N'" + txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'" + txtDiaChiKH.Text + "',N'" + txtSoDienThoaiKH.Text + "')";
                Functions.RunSQL(sql); //Thực hiện câu lệnh sql
                LoadDataGridView(); //Nạp lại DataGridView
                ResetValue();
            }
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnCNDL.Enabled = false;
            txtMaKH.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKH.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblKhachHang WHERE MaKhachHang=N'" + txtMaKH.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaKH.Text.Trim().Length == 0) //Nếu chưa nhập mã kh
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return;
            }
            if (txtTenKH.Text.Trim().Length == 0) //Nếu chưa nhập tên KH
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKH.Focus();
                return;
            }
            if (txtDiaChiKH.Text.Trim().Length == 0) //Nếu chưa nhập ĐC KH
            {
                MessageBox.Show("Bạn phải nhập địa chỉ khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChiKH.Focus();
                return;
            }
            if (txtSoDienThoaiKH.Text.Trim().Length == 0) //Nếu chưa nhap SDT KH
            {
                MessageBox.Show("Bạn phải nhập Số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoDienThoaiKH.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (txtSua == txtMaKH.Text)
            {
                sql = "UPDATE tblKhachHang SET TenKhachHang=N'" + txtTenKH.Text.ToString() + "', DiaChi=N'" + txtDiaChiKH.Text + "', SoDienThoai=N'" + txtSoDienThoaiKH.Text + "'  WHERE MaKhachHang=N'" + txtMaKH.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
            }
            else
            {
                sql = "SELECT * FROM tblKhachHang WHERE MaKhachHang=N'" + txtMaKH.Text + "'";
                bool ktMaSP = Functions.RunSQLD(sql);
                sql = "SELECT * FROM tblDonHang WHERE MaKhachHang=N'" + txtSua + "'";
                bool ktMaCTHD = Functions.RunSQLD(sql);
                if (ktMaCTHD)
                {
                    MessageBox.Show("Mã khách hàng không thể sửa do đơn hàng đang mua trước đó chưa hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaKH.Focus();
                    return;
                }
                else if (ktMaSP)
                {
                    MessageBox.Show("Mã Khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaKH.Focus();
                    return;
                }
                else
                {
                    sql = "DELETE tblKhachHang WHERE MaKhachHang=N'" + txtSua + "'";
                    Functions.RunSQL(sql);

                    sql = "INSERT INTO tblKhachHang VALUES(N'" + txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'" + txtDiaChiKH.Text + "',N'" + txtSoDienThoaiKH.Text + "')";
                    Functions.RunSQL(sql); //Thực hiện câu lệnh sql
                    LoadDataGridView(); //Nạp lại DataGridView
                    ResetValue();

                }
            }
        }
    }
}
