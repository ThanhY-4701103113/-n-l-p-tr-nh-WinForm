using DoAnQLBH.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLBH
{
    public partial class FrmBaoCao : Form
    {
        public FrmBaoCao()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT COUNT(*) FROM tblKhachHang";
            txtKH.Text = Functions.GetFieldValues(sql);
            sql = "SELECT COUNT(*) FROM tblNhanVien";
            txtNV.Text = Functions.GetFieldValues(sql);
            sql = "SELECT COUNT(*) FROM tblSanPham";
            txtSP.Text = Functions.GetFieldValues(sql);
            sql = "SELECT COUNT(*) FROM tblDonHang";
            txtDH.Text = Functions.GetFieldValues(sql);

            sql = "SELECT SUM(TongTien) FROM tblDonHang";
            txtTong.Text = Functions.DinhDangTien(Functions.GetFieldValues(sql)) + " VNĐ";
            txtDH.ReadOnly = true;
            txtKH.ReadOnly = true;
            txtNV.ReadOnly = true;
            txtSP.ReadOnly = true;
            txtTong.ReadOnly = true;
        }
    }
}
