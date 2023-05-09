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
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
            txtTaiKhoan.MaxLength = 20;
            txtNMatKhau.MaxLength = 20;
            txtMatKhau.MaxLength = 20;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            string nmk = txtNMatKhau.Text;
            string sql = "select * from tblTaiKhoan where TaiKhoan = '" + tk + "'";
            if (tk == "")
            {
                txtkq.Text = "";
                Thread.Sleep(200);
                txtkq.Text = "Bạn phải nhập tài khoản đăng ký";
                txtTaiKhoan.Focus();
                return;
            }
            if (Functions.RunSQLD(sql) == true)
            {
                txtkq.Text = "";
                Thread.Sleep(200);
                txtkq.Text = "Tài khoản đăng ký đã tồn tại";
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
            if (nmk == "")
            {
                txtkq.Text = "";
                Thread.Sleep(200);
                txtkq.Text = "Bạn phải nhập lại mật khẩu";
                txtNMatKhau.Focus();
                return;
            }
            if (mk.Length < 8) 
            {
                txtkq.Text = "";
                Thread.Sleep(200);
                txtkq.Text = "Mật khẩu phải từ 8 ký tự trở lên";
                txtMatKhau.Focus();
                return;
            }
            
            if(mk!=nmk)
            {
                txtkq.Text = "";
                Thread.Sleep(200);
                txtkq.Text = "Nhập lại mật khẩu không khớp";
                return;
            }
            sql = "INSERT INTO tblTaiKhoan VALUES(N'" + tk + "',N'" + mk + "')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            MessageBox.Show("Đăng ký thành công");
            this.Close();
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            //Kiểm tra hiện tại có hiện mk hay không 
            if (cbShow.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
                txtNMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                txtNMatKhau.PasswordChar = '*';
            }
        }

        
    }
}
