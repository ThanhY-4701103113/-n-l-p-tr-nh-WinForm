using DoAnQLBH.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLBH
{
    public partial class FrmDoiMatKhau : Form
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtMatKhau.MaxLength = 20;
            txtTaiKhoan.MaxLength = 20;
            txtNMatKhau.MaxLength = 20;
            txtMatKhauMoi.MaxLength = 20;
        }

        private void btnDMK_Click(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            string mkm = txtMatKhauMoi.Text;
            string nmk = txtNMatKhau.Text;
            string sql = "select * from tblTaiKhoan where TaiKhoan = '" + tk + "'";
            if (tk == "")
            {
                txtkq.Text = "";
                Thread.Sleep(200);
                txtkq.Text = "Bạn phải nhập tài khoản";
                txtTaiKhoan.Focus();
                return;
            }
            if (mk == "")
            {
                txtkq.Text = "";
                Thread.Sleep(200);
                txtkq.Text = "Bạn phải nhập mật khẩu";
                txtMatKhau.Focus();
                return;
            }
            if (mkm == "")
            {
                txtkq.Text = "";
                Thread.Sleep(200);
                txtkq.Text = "Bạn phải nhập mật khẩu mới";
                txtMatKhauMoi.Focus();
                return;
            }
            if (nmk == "")
            {
                txtkq.Text = "";
                Thread.Sleep(200);
                txtkq.Text = "Bạn phải nhập lại mật khẩu";
                txtNMatKhau.Focus();
                return;
            }
            if (Functions.RunSQLD(sql) != true)
            {
                txtkq.Text = "";
                Thread.Sleep(200);
                txtkq.Text = "Tài khoản hoặc mật khẩu không chính xác";
                txtTaiKhoan.Focus();
                return;
            }
            if (mkm.Length < 8)
            {
                txtkq.Text = "";
                Thread.Sleep(200);
                txtkq.Text = "Mật khẩu phải từ 8 ký tự trở lên";
                txtMatKhauMoi.Focus();
                return;
            }
            if (mkm != nmk)
            {
                txtkq.Text = "";
                Thread.Sleep(200);
                txtkq.Text = "Nhập lại mật khẩu không khớp";
                return;
            }
            sql = "UPDATE tblTaiKhoan SET MatKhau=N'" + mkm + "' WHERE TaiKhoan=N'" + tk + "'";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            MessageBox.Show("Đổi mật khẩu thành công");
            this.Close();
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            //Kiểm tra hiện tại có hiện mk hay không 
            if (cbShow.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
                txtNMatKhau.PasswordChar = (char)0;
                txtMatKhauMoi.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                txtNMatKhau.PasswordChar = '*';
                txtMatKhauMoi.PasswordChar = '*';
            }
        }
    }
}
