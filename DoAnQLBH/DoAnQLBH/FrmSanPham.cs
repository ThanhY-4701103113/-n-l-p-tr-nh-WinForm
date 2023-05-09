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
    public partial class FrmSanPham : Form
    {
        DataTable tblSanPham;
        string txtSua = "";
        //private frmMain main;
        public FrmSanPham(/*frmMain main*/)
        {
            InitializeComponent();
            //this.main = main;
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            txtMaSP.Enabled = false;
            btnCNDL.Enabled = false;
            btnBoQua.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng tblSanPham
            dgvSP.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            txtGiaSP.MaxLength = 20;
            txtMaSP.MaxLength = 20;
            txtNhaSanXuatSP.MaxLength = 20;
            txtSoLuongSP.MaxLength = 20;
            txtTenSP.MaxLength = 20;
        }
        //Tải dữ liệu
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblSanPham";
            tblSanPham = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvSP.DataSource = tblSanPham; //Nguồn dữ liệu            
            dgvSP.Columns[0].HeaderText = "Mã sản phẩm";
            dgvSP.Columns[1].HeaderText = "Tên sản phẩm";
            dgvSP.Columns[2].HeaderText = "Giá sản phẩm";
            dgvSP.Columns[3].HeaderText = "Số lượng";
            dgvSP.Columns[4].HeaderText = "Nhà sản xuất";

            dgvSP.Columns[0].Width = 140;
            dgvSP.Columns[1].Width = 150;
            dgvSP.Columns[2].Width = 140;
            dgvSP.Columns[3].Width = 120;
            dgvSP.Columns[4].Width = 150;


            dgvSP.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvSP.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
            /*dgvSP.AllowUserToAddRows = true; //Cho phép người dùng thêm dữ liệu trực tiếp
            dgvSP.EditMode = DataGridViewEditMode.EditOnEnter; //Cho phép người dùng sửa dữ liệu trực tiếp*/

            /*//Xử lý sự kiện RowsAdded để thêm dữ liệu vào database khi người dùng thêm mới dòng
            dgvSP.RowsAdded += (sender, e) =>
            {
                //Lấy dòng mới được thêm
                DataGridViewRow row = dgvSP.Rows[e.RowIndex];

                //Thêm dữ liệu vào database
                string sqlInsert = "INSERT INTO tblSanPham VALUES(N'" + row.Cells[0].Value + "',N'" + row.Cells[1].Value + "',N'" + row.Cells[2].Value + "',N'" + row.Cells[3].Value + "',N'" + row.Cells[4].Value + "' WHERE MaSanPham!=N'" + txtMaSP.Text + "' )";                Functions.RunSQL(sqlInsert);
            };*/
        }

        private void dgvSP_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSP.Focus();
                return;
            }
            if (tblSanPham.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaSP.Text = dgvSP.CurrentRow.Cells["MaSanPham"].Value.ToString();
            txtTenSP.Text = dgvSP.CurrentRow.Cells["TenSanPham"].Value.ToString();
            txtGiaSP.Text = dgvSP.CurrentRow.Cells["GiaSanPham"].Value.ToString();
            txtSoLuongSP.Text = dgvSP.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtNhaSanXuatSP.Text = dgvSP.CurrentRow.Cells["NhaSanXuat"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = false;
            btnCNDL.Enabled = false;
            txtSua = txtMaSP.Text;
            txtMaSP.Enabled = true;

        }

        private void ResetValue()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaSP.Text = "";
            txtSoLuongSP.Text = "";
            txtNhaSanXuatSP.Text = "";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            //main.OpenEnabled(); //hien thi chon nut
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnCNDL.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMaSP.Enabled = true; //cho phép nhập mới
            txtMaSP.Focus();
        }

        private void btnCNDL_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaSP.Text.Trim().Length == 0) //Nếu chưa nhập mã sp
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSP.Focus();
                return;
            }
            if (txtTenSP.Text.Trim().Length == 0) //Nếu chưa nhập tên sp
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSP.Focus();
                return;
            }
            if (txtGiaSP.Text.Trim().Length == 0) //Nếu chưa nhập Gia sp
            {
                MessageBox.Show("Bạn phải nhập giá sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaSP.Focus();
                return;
            }
            if (txtSoLuongSP.Text.Trim().Length == 0) //Nếu chưa nhập So luong sp
            {
                MessageBox.Show("Bạn phải nhập Số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuongSP.Focus();
                return;
            }
            if (txtNhaSanXuatSP.Text.Trim().Length == 0) //Nếu chưa nhap nha san xuat
            {
                MessageBox.Show("Bạn phải nhập Nhà sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhaSanXuatSP.Focus();
                return;
            }
            sql = "Select MaSanPham From tblSanPham where MaSanPham=N'" + txtMaSP.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã SP này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSP.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "INSERT INTO tblSanPham VALUES(N'" + txtMaSP.Text + "',N'" + txtTenSP.Text + "',N'" + txtGiaSP.Text + "',N'" + txtSoLuongSP.Text + "',N'" + txtNhaSanXuatSP.Text + "')";
                Functions.RunSQL(sql); //Thực hiện câu lệnh sql
                LoadDataGridView(); //Nạp lại DataGridView
                ResetValue();
            }
            btnThem.Enabled = true;
            btnBoQua.Enabled = false;
            btnCNDL.Enabled = false;
            txtMaSP.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSP.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                sql = "DELETE tblSanPham WHERE MaSanPham=N'" + txtMaSP.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnCNDL.Enabled = false;
            txtMaSP.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtMaSP.Text.Trim().Length == 0) //Nếu chưa nhập mã sp
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSP.Focus();
                return;
            }
            if (txtTenSP.Text.Trim().Length == 0) //Nếu chưa nhập tên sp
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSP.Focus();
                return;
            }
            if (txtGiaSP.Text.Trim().Length == 0) //Nếu chưa nhập Gia sp
            {
                MessageBox.Show("Bạn phải nhập giá sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaSP.Focus();
                return;
            }
            if (txtSoLuongSP.Text.Trim().Length == 0) //Nếu chưa nhập So luong sp
            {
                MessageBox.Show("Bạn phải nhập Số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuongSP.Focus();
                return;
            }
            if (txtNhaSanXuatSP.Text.Trim().Length == 0) //Nếu chưa nhap nha san xuat
            {
                MessageBox.Show("Bạn phải nhập Nhà sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhaSanXuatSP.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtSua == txtMaSP.Text)
                {
                    sql = "UPDATE tblSanPham SET TenSanPham=N'" + txtTenSP.Text.ToString() + "', GiaSanPham=N'" + txtGiaSP.Text + "', SoLuong=N'" + txtSoLuongSP.Text + "', NhaSanXuat=N'" + txtNhaSanXuatSP.Text + "'  WHERE MaSanPham=N'" + txtMaSP.Text + "'";
                    Class.Functions.RunSQL(sql);
                    LoadDataGridView();
                }
                else
                {
                    sql = "SELECT * FROM tblSanPham WHERE MaSanPham=N'"+txtMaSP.Text+"'";
                    bool ktMaSP = Functions.RunSQLD(sql);
                    sql = "SELECT * FROM tblCTHD WHERE MaSanPham=N'" + txtSua + "'";
                    bool ktMaCTHD = Functions.RunSQLD(sql);
                    if (ktMaCTHD) 
                    {
                        MessageBox.Show("Mã sản phẩm không thể sửa do đơn hàng đang mua trước đó chưa hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaSP.Focus();
                        return;
                    }
                    else if (ktMaSP)
                    {
                        MessageBox.Show("Mã sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaSP.Focus();
                        return;
                    }
                    else
                    {
                        sql = "DELETE tblSanPham WHERE MaSanPham=N'" + txtSua + "'";
                        Functions.RunSQL(sql);

                        sql = "INSERT INTO tblSanPham VALUES(N'" + txtMaSP.Text + "',N'" + txtTenSP.Text + "',N'" + txtGiaSP.Text + "',N'" + txtSoLuongSP.Text + "',N'" + txtNhaSanXuatSP.Text + "')";
                        Functions.RunSQL(sql); //Thực hiện câu lệnh sql
                        LoadDataGridView(); //Nạp lại DataGridView
                        ResetValue();
                    }
                }
            }
 
        }

        private void txtGiaSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuongSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
