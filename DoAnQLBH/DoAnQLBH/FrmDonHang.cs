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
using DoAnQLBH.Class;
using COMExcel = Microsoft.Office.Interop.Excel;
namespace DoAnQLBH
{

    public partial class FrmDonHang : Form
    {
        DataTable tblCTHD;
        public FrmDonHang()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            txtTongHD.ReadOnly = true;
            dgvDH.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            btnHuy.Enabled = false;
            btnIn.Enabled = false;
            
            txtTenKH.ReadOnly = true;
            txtDiaChiKH.ReadOnly = true;
            txtSoDienThoaiKH.ReadOnly = true;
            txtTenSP.ReadOnly = true;
            txtGiaSP.ReadOnly = true;
            txtTongTienDH.ReadOnly = true;
            txtTongTienDH.Text = "0";
            Functions.FillCB("SELECT MaDonHang FROM tblDonHang", txtMaDH, "MaDonHang", "MaDonHang");
            txtMaDH.SelectedIndex = -1;
            Functions.FillCB("SELECT MaKhachHang, TenKhachHang FROM tblKhachHang", txtMaKH, "MaKhachHang", "MaKhachHang");
            txtMaKH.SelectedIndex = -1;
            Functions.FillCB("SELECT MaNhanVien, TenNhanVien FROM tblNhanVien", txtMaNV, "MaNhanVien", "TenKhachHang");
            txtMaNV.SelectedIndex = -1;
            Functions.FillCB("SELECT MaSanPham, TenSanPham FROM tblSanPham", txtMaSP, "MaSanPham", "TenSanPham");
            txtMaSP.SelectedIndex = -1;
            
            /*if (txtMaDH.Text != "")
            {
                LoadInfoDonHang();
                btnHuy.Enabled = true;
                btnIn.Enabled = true;
            }*/
            LoadDataGridView();
            txtMaDH.MaxLength = 20;
            txtMaSP.MaxLength = 20;
            txtMaKH.MaxLength = 20;
            txtTongHD.MaxLength = 20;
            txtTongTienDH.MaxLength = 20;
            txtMaNV.MaxLength = 20;
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.MaSanPham, b.TenSanPham, a.SoLuong, b.GiaSanPham, a.GiaBan FROM tblCTHD AS a, tblSanPham AS b WHERE a.MaDonHang = N'" + txtMaDH.Text + "' AND a.MaSanPham=b.MaSanPham";
            tblCTHD = Functions.GetDataToTable(sql);
            dgvDH.DataSource = tblCTHD;
            dgvDH.Columns[0].HeaderText = "Mã sản phẩm";
            dgvDH.Columns[1].HeaderText = "Tên sản phẩm";
            dgvDH.Columns[2].HeaderText = "Số lượng";
            dgvDH.Columns[3].HeaderText = "Giá sản phẩm";
            dgvDH.Columns[4].HeaderText = "Tổng tiền";

            dgvDH.Columns[0].Width = 140;
            dgvDH.Columns[1].Width = 150;
            dgvDH.Columns[2].Width = 120;
            dgvDH.Columns[3].Width = 140;
            dgvDH.Columns[4].Width = 140;

            dgvDH.AllowUserToAddRows = false;
            dgvDH.EditMode = DataGridViewEditMode.EditProgrammatically;

            
        }

        private void LoadInfoDonHang()
        {
            string str;
            str = "SELECT * FROM tblDonHang WHERE MaDonHang = N'" + txtMaDH.Text + "'";
            if (Functions.RunSQLD(str)==true)
            {
                str = "SELECT NgayDatHang FROM tblDonHang WHERE MaDonHang = N'" + txtMaDH.Text + "'";
                txtNgayDatHangDH.Text = Functions.ConvertDateTime(Functions.GetFieldValues(str));
                str = "SELECT NgayGiaoHang FROM tblDonHang WHERE MaDonHang = N'" + txtMaDH.Text + "'";
                txtNgayGiaoHangDH.Text = Functions.ConvertDateTime(Functions.GetFieldValues(str));
                str = "SELECT MaNhanVien FROM tblDonHang WHERE MaDonHang = N'" + txtMaDH.Text + "'";
                txtMaNV.Text = Functions.GetFieldValues(str);
                str = "SELECT MaKhachHang FROM tblDonHang WHERE MaDonHang = N'" + txtMaDH.Text + "'";
                txtMaKH.Text = Functions.GetFieldValues(str);
                str = "SELECT SUM(TongTien) FROM tblDonHang WHERE MaDonHang=N'" + txtMaDH.Text + "'";
                txtTongHD.Text = Functions.DinhDangTien(Functions.GetFieldValues(str)) + " VNĐ";
            }
            else
            {
                MessageBox.Show("Đơn hàng không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDH_Click(object sender, EventArgs e)
        {
            if (tblCTHD.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaSP.Text= dgvDH.CurrentRow.Cells["MaSanPham"].Value.ToString(); 
            txtTenSP.Text = dgvDH.CurrentRow.Cells["TenSanPham"].Value.ToString();
            txtSoLuongSP.Text= dgvDH.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtGiaSP.Text = dgvDH.CurrentRow.Cells["GiaSanPham"].Value.ToString();
            txtTongTienDH.Text = dgvDH.CurrentRow.Cells["GiaBan"].Value.ToString();
            btnIn.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnIn.Enabled = false;
            btnThem.Enabled = false;
            btnTimKiem.Enabled = false;
            ResetValues();
            txtMaDH.Text = Functions.CreateKey("DH");
            LoadDataGridView();
        }
        private void ResetValues()
        {
            txtMaDH.Text = "";
            txtNgayDatHangDH.Text = DateTime.Now.ToShortDateString();
            txtMaNV.Text = "";
            txtMaKH.Text = "";
            txtTongTienDH.Text = "0";
            txtMaSP.Text = "";
            txtNgayGiaoHangDH.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT MaDonHang FROM tblDonHang WHERE MaDonHang=N'" + txtMaDH.Text + "'";
            if (!Functions.CheckKey(sql))
            {
                // Mã đơn hàng chưa có, tiến hành lưu các thông tin chung
                // Mã dh được sinh tự động do đó không có trường hợp trùng khóa
                if (txtNgayDatHangDH.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày đặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNgayDatHangDH.Focus();
                    return;
                }
                if (txtNgayGiaoHangDH.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày giao hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNgayGiaoHangDH.Focus();
                    return;
                }
                if (txtMaNV.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaNV.Focus();
                    return;
                }
                if (txtMaKH.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaKH.Focus();
                    return;
                }
                sql = "INSERT INTO tblDonHang(MaDonHang, NgayDatHang, NgayGiaoHang, MaNhanVien, MaKhachHang, TongTien) VALUES (N'" + txtMaDH.Text.Trim() + "','" +
                        Functions.ConvertDateTime(txtNgayDatHangDH.Text.Trim()) + "', '" +
                        Functions.ConvertDateTime(txtNgayGiaoHangDH.Text.Trim()) + "',N'" + txtMaNV.SelectedValue + "',N'" +
                        txtMaKH.SelectedValue + "'," + 0 + ")";
                Functions.RunSQL(sql);
            }
            // Lưu thông tin của các mặt hàng
            if (txtMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSP.Focus();
                return;
            }
            if ((txtSoLuongSP.Text.Trim().Length == 0) || (txtSoLuongSP.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuongSP.Text = "";
                txtSoLuongSP.Focus();
                return;
            }
            
            sql = "SELECT MaSanPham FROM tblCTHD WHERE MaSanPham=N'" + txtMaSP.SelectedValue + "' AND MaDonHang = N'" + txtMaDH.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã sản phẩm này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                txtMaSP.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblSanPham WHERE MaSanPham = N'" + txtMaSP.SelectedValue + "'"));
            if (Convert.ToDouble(txtSoLuongSP.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuongSP.Text = "";
                txtSoLuongSP.Focus();
                return;
            }
            double GiaB = 0;
            GiaB= Convert.ToDouble(txtSoLuongSP.Text)* Convert.ToDouble(txtGiaSP.Text); ;
            sql = "INSERT INTO tblCTHD(MaDonHang,MaSanPham,SoLuong,GiaBan) VALUES(N'" + txtMaDH.Text.Trim() + "',N'" + txtMaSP.SelectedValue + "'," + txtSoLuongSP.Text + "," + GiaB + ")";
            Functions.RunSQL(sql);
            LoadDataGridView();
            // Cập nhật lại số lượng của mặt hàng vào bảng tblSanPham
            SLcon = sl - Convert.ToDouble(txtSoLuongSP.Text);
            sql = "UPDATE tblSanPham SET SoLuong =" + SLcon + " WHERE MaSanPham= N'" + txtMaSP.SelectedValue + "'";
            Functions.RunSQL(sql);
            // Cập nhật lại tổng tiền cho đơn bán
            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TongTien FROM tblDonHang WHERE MaDonHang = N'" + txtMaDH.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtTongTienDH.Text);
            sql = "UPDATE tblDonHang SET TongTien =" + Tongmoi + " WHERE MaDonHang = N'" + txtMaDH.Text + "'";
            Functions.RunSQL(sql);
            txtTongTienDH.Text = Tongmoi.ToString();
            ResetValuesHang();
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnIn.Enabled = true;
            string Tempt = txtMaDH.Text;
            Functions.FillCB("SELECT MaDonHang FROM tblDonHang", txtMaDH, "MaDonHang", "MaDonHang");
            txtMaDH.Text = Tempt;
            LoadInfoDonHang();
        }

        private void ResetValuesHang()
        {
            txtMaSP.Text = "";
            txtSoLuongSP.Text = "";
            txtGiaSP.Text = "0";   
        }

        private void txtSoLuongSP_TextChanged(object sender, EventArgs e)
        {

            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg;
            if (txtSoLuongSP.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuongSP.Text);
            if (txtGiaSP.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtGiaSP.Text);
            tt = sl * dg;
            txtTongTienDH.Text = tt.ToString();
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (txtMaSP.Text == "")
            {
                txtTenSP.Text = "";
                txtGiaSP.Text = "";
                txtSoLuongSP.Text = "";
            }
            else
            {
                // Khi chọn mã hàng thì các thông tin về hàng hiện ra
                str = "SELECT TenSanPham FROM tblSanPham WHERE MaSanPham =N'" + txtMaSP.SelectedValue + "'";
                txtTenSP.Text = Functions.GetFieldValues(str);
                str = "SELECT GiaSanPham FROM tblSanPham WHERE MaSanPham=N'" + txtMaSP.SelectedValue + "'";
                txtGiaSP.Text = Functions.GetFieldValues(str);
            }
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (txtMaKH.Text == "")
            {
                txtTenKH.Text = "";
                txtDiaChiKH.Text = "";
                txtSoDienThoaiKH.Text = "";
            }
            else
            {
                // Khi chọn mã hàng thì các thông tin về hàng hiện ra
                str = "SELECT TenKhachHang FROM tblKhachHang WHERE MaKhachHang =N'" + txtMaKH.SelectedValue + "'";
                txtTenKH.Text = Functions.GetFieldValues(str);
                str = "SELECT DiaChi FROM tblKhachHang WHERE MaKhachHang =N'" + txtMaKH.SelectedValue + "'";
                txtDiaChiKH.Text = Functions.GetFieldValues(str);
                str = "SELECT SoDienThoai FROM tblKhachHang WHERE MaKhachHang =N'" + txtMaKH.SelectedValue + "'";
                txtSoDienThoaiKH.Text = Functions.GetFieldValues(str);
            }
        }

        private void txtSoLuongSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            //LoadInfoDonHang();
        }

        private void dgvDH_DoubleClick(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT MaSanPham,SoLuong FROM tblCTHD WHERE MaDonHang = N'" + txtMaDH.Text + "'";
                DataTable tblSP = Functions.GetDataToTable(sql);
                for (int SP = 0; SP <= tblSP.Rows.Count - 1; SP++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblSanPham WHERE MaSanPham = N'" + tblSP.Rows[SP][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(tblSP.Rows[SP][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE tblSanPham SET SoLuong =" + slcon + " WHERE MaSanPham= N'" + tblSP.Rows[SP][0].ToString() + "'";
                    Functions.RunSQL(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE tblCTHD WHERE MaDonHang=N'" + txtMaDH.Text + "'";
                Functions.RunSQL(sql);

                //Xóa DonHang
                sql = "DELETE tblDonHang WHERE MaDonHang=N'" + txtMaDH.Text + "'";
                Functions.RunSQL(sql);
                ResetValues();
                LoadDataGridView();
                txtTongHD.Text = "";

                Functions.FillCB("SELECT MaDonHang FROM tblDonHang", txtMaDH, "MaDonHang", "MaDonHang");
                txtMaKH.SelectedIndex = -1;
            }


        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Cửa hàng tiện lợi";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "TPHCM - Nỗ Lực";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (09)87654321";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN HÀNG";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.MaDonHang, b.MaKhachHang, b.DiaChi, b.SoDienThoai, a.TongTien, a.NgayDatHang, a.MaNhanVien FROM tblDonHang AS a, tblKhachHang AS b, tblCTHD AS c WHERE a.MaKhachHang = b.MaKhachHang AND a.MaDonHang=N'"+txtMaDH.Text+"' AND a.MaDonHang=c.MaDonHang";

            tblThongtinHD = Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã đơn hàng:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][1].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][2].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][3].ToString();


            //Lấy thông tin các mặt hàng
            sql = "SELECT b.TenSanPham, a.SoLuong, b.GiaSanPham, a.GiaBan " +
                  "FROM tblCTHD AS a , tblSanPham AS b WHERE a.MaDonHang = N'" +
                  txtMaDH.Text + "' AND a.MaSanPham = b.MaSanPham";
            tblThongtinHang = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên sản phẩm";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Giá sản phẩm";
            exRange.Range["E11:E11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = Functions.DinhDangTien((tblThongtinHD.Rows[0][4]).ToString())+" VNĐ";
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][5]);
            string ngay = "";
            string thang = "";
            if (d.Day < 10)
            {
                ngay = "0";
            }
            if(d.Month < 3)
            {
                thang = "0";
            }
            exRange.Range["A1:C1"].Value = "TP Hồ Chí Minh, ngày " + ngay+d.Day + " tháng " + thang+ d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }



        private void txtMaDH_TextChanged_1(object sender, EventArgs e)
        {
            if (txtMaDH.Text == "" || btnThem.Enabled == false)
            {
                btnIn.Enabled = false;
            }
            else
            {
                btnIn.Enabled = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtMaDH.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một đơn hàng để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDH.Focus();
                return;
            }
            LoadInfoDonHang();
            LoadDataGridView();
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnIn.Enabled = true;
        }

        
    }
}
