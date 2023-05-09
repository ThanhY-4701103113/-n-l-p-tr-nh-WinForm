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
using DoAnQLBH.Class;
namespace DoAnQLBH
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            string sql = "select * from tblTaiKhoan where TaiKhoan = '" + tk + "' and MatKhau = '" + mk + "'";

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
            if (Functions.RunSQLD(sql) == true)
            {
                // Tạm dừng chương trình trong 1 giây
                Thread.Sleep(500);
                FrmMain frm = new FrmMain();
                txtkq.Text = "";
                Functions.admin = tk;
                /*MessageBox.Show("Đăng nhập thành công");*/
                frm.ShowDialog();
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
            }
            else
            {
                txtkq.Text = "";
                Thread.Sleep(200);
                txtkq.Text = "Tài khoản hoặc mật khẩu không đúng";
            }
          
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            //Kiểm tra hiện tại có hiện mk hay không 
            if (cbShow.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            txtMatKhau.MaxLength = 20;
            txtTaiKhoan.MaxLength = 20;

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FrmDangKy frm = new FrmDangKy();
            frm.ShowDialog();
        }

        private void btnDMK_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau frm = new FrmDoiMatKhau();
            frm.ShowDialog();
        }
    }
}
