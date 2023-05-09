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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private Form FormChild;

        private void OpenFormChild(Form childFrom)
        {
            //nếu khởi tạo rồi thì đóng lại
            if (Functions.admin != "admin")
            {
                btnNhanVien.Enabled = false;
            }
            if (FormChild != null)
            {
                FormChild.Close();
            }
            FormChild = childFrom;
            childFrom.TopLevel = false; //Khi mà show lên thì vẫn thực hiện tiêp lên được form cha
            childFrom.FormBorderStyle = FormBorderStyle.None;//bỏ khung 
            childFrom.Dock = DockStyle.Fill;//Chèn đầy body
            pnBody.Controls.Add(childFrom);//them vao
            pnBody.Tag = childFrom; //chuyển dữ liệu 
            childFrom.BringToFront();//Mang đến phía trước
            childFrom.Show();//hiển thị form lên màn hình body pn
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Functions.admin != "admin")
            {
                btnNhanVien.Enabled = false;
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FrmSanPham(/*this*/));
            txtMain.Text = btnSanPham.Text;
            

        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FrmDonHang());
            txtMain.Text = btnDonHang.Text;
        

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FrmKhachHang());
            txtMain.Text = btnKhachHang.Text;
           

        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FrmNhanVien());
            txtMain.Text = btnNhanVien.Text;
            

        }


        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FrmBaoCao());
            txtMain.Text = btnBaoCao.Text;
           

        }

        

        private void picMain_Click(object sender, EventArgs e)
        {
            txtMain.Text = "Quản lý bán hàng";
            if (FormChild != null)
            {
                FormChild.Close();
            }
        }

        private void btnDMK_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FrmDoiMatKhau());
            txtMain.Text = btnDMK.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
