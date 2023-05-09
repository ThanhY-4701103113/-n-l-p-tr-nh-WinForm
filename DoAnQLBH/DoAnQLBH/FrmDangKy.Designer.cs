namespace DoAnQLBH
{
    partial class FrmDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.txtkq = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNMatKhau = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "ĐĂNG KÝ HỆ THỐNG";
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShow.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShow.Location = new System.Drawing.Point(237, 307);
            this.cbShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(199, 30);
            this.cbShow.TabIndex = 26;
            this.cbShow.Text = "Hiển thị mật khẩu";
            this.cbShow.UseVisualStyleBackColor = true;
            this.cbShow.CheckedChanged += new System.EventHandler(this.cbShow_CheckedChanged);
            // 
            // txtkq
            // 
            this.txtkq.AutoSize = true;
            this.txtkq.BackColor = System.Drawing.SystemColors.Window;
            this.txtkq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtkq.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkq.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtkq.Location = new System.Drawing.Point(240, 343);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(0, 26);
            this.txtkq.TabIndex = 25;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKy.Location = new System.Drawing.Point(324, 360);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(151, 50);
            this.btnDangKy.TabIndex = 24;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tài khoản đăng ký:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(237, 186);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(337, 34);
            this.txtMatKhau.TabIndex = 21;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(237, 108);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(337, 34);
            this.txtTaiKhoan.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 26);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nhập lại mật khẩu:";
            // 
            // txtNMatKhau
            // 
            this.txtNMatKhau.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNMatKhau.Location = new System.Drawing.Point(237, 266);
            this.txtNMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNMatKhau.Name = "txtNMatKhau";
            this.txtNMatKhau.PasswordChar = '*';
            this.txtNMatKhau.Size = new System.Drawing.Size(337, 34);
            this.txtNMatKhau.TabIndex = 29;
            // 
            // FrmDangKy
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNMatKhau);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbShow);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbShow;
        private System.Windows.Forms.Label txtkq;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNMatKhau;
    }
}