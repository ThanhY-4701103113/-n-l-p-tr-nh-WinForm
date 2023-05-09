namespace DoAnQLBH
{
    partial class FrmDonHang
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
            this.dgvDH = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaSP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGiaSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuongSP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongTienDH = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtMaDH = new System.Windows.Forms.ComboBox();
            this.txtMaNV = new System.Windows.Forms.ComboBox();
            this.txtMaKH = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.txtNgayGiaoHangDH = new System.Windows.Forms.DateTimePicker();
            this.txtSoDienThoaiKH = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNgayDatHangDH = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTongHD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDH)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDH
            // 
            this.dgvDH.BackgroundColor = System.Drawing.Color.White;
            this.dgvDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDH.Location = new System.Drawing.Point(12, 342);
            this.dgvDH.Name = "dgvDH";
            this.dgvDH.RowHeadersWidth = 51;
            this.dgvDH.RowTemplate.Height = 24;
            this.dgvDH.Size = new System.Drawing.Size(1158, 186);
            this.dgvDH.TabIndex = 7;
            this.dgvDH.Click += new System.EventHandler(this.dgvDH_Click);
            this.dgvDH.DoubleClick += new System.EventHandler(this.dgvDH_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 583);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 70);
            this.panel1.TabIndex = 6;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLuu.Location = new System.Drawing.Point(271, 10);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(199, 52);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu đơn hàng";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnThem.Location = new System.Drawing.Point(37, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(199, 52);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm đơn hàng";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnIn.Location = new System.Drawing.Point(740, 10);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(184, 52);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "In đơn hàng";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnHuy.Location = new System.Drawing.Point(507, 10);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(199, 52);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Làm mới";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDong.Location = new System.Drawing.Point(990, 10);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(135, 52);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 336);
            this.panel2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaSP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtGiaSP);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSoLuongSP);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtTenSP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTongTienDH);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(20, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1135, 102);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đơn hàng";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.FormattingEnabled = true;
            this.txtMaSP.Location = new System.Drawing.Point(140, 30);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(185, 28);
            this.txtMaSP.TabIndex = 32;
            this.txtMaSP.TextChanged += new System.EventHandler(this.txtMaSP_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(388, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(19, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Mã sản phẩm";
            // 
            // txtGiaSP
            // 
            this.txtGiaSP.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaSP.Location = new System.Drawing.Point(524, 69);
            this.txtGiaSP.Name = "txtGiaSP";
            this.txtGiaSP.Size = new System.Drawing.Size(185, 28);
            this.txtGiaSP.TabIndex = 30;
            this.txtGiaSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(770, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Thành tiền";
            // 
            // txtSoLuongSP
            // 
            this.txtSoLuongSP.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongSP.Location = new System.Drawing.Point(140, 66);
            this.txtSoLuongSP.Name = "txtSoLuongSP";
            this.txtSoLuongSP.Size = new System.Drawing.Size(185, 28);
            this.txtSoLuongSP.TabIndex = 31;
            this.txtSoLuongSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoLuongSP.TextChanged += new System.EventHandler(this.txtSoLuongSP_TextChanged);
            this.txtSoLuongSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongSP_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(390, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Giá sản phẩm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(388, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Tên sản phẩm";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(524, 30);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(185, 28);
            this.txtTenSP.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Số lượng";
            // 
            // txtTongTienDH
            // 
            this.txtTongTienDH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTienDH.Location = new System.Drawing.Point(878, 49);
            this.txtTongTienDH.Name = "txtTongTienDH";
            this.txtTongTienDH.Size = new System.Drawing.Size(200, 28);
            this.txtTongTienDH.TabIndex = 25;
            this.txtTongTienDH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtMaDH);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtDiaChiKH);
            this.groupBox1.Controls.Add(this.txtNgayGiaoHangDH);
            this.groupBox1.Controls.Add(this.txtSoDienThoaiKH);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNgayDatHangDH);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(20, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1135, 226);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Info;
            this.btnTimKiem.BackgroundImage = global::DoAnQLBH.Properties.Resources.download;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(501, 44);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(34, 33);
            this.btnTimKiem.TabIndex = 41;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtMaDH
            // 
            this.txtMaDH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDH.FormattingEnabled = true;
            this.txtMaDH.Location = new System.Drawing.Point(268, 46);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(227, 28);
            this.txtMaDH.TabIndex = 40;
            this.txtMaDH.TextChanged += new System.EventHandler(this.txtMaDH_TextChanged_1);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.FormattingEnabled = true;
            this.txtMaNV.Location = new System.Drawing.Point(268, 184);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(227, 28);
            this.txtMaNV.TabIndex = 33;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.FormattingEnabled = true;
            this.txtMaKH.Location = new System.Drawing.Point(784, 46);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(227, 28);
            this.txtMaKH.TabIndex = 34;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(94, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 20);
            this.label11.TabIndex = 38;
            this.label11.Text = "Ngày giao hàng";
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiKH.Location = new System.Drawing.Point(784, 137);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(227, 28);
            this.txtDiaChiKH.TabIndex = 32;
            // 
            // txtNgayGiaoHangDH
            // 
            this.txtNgayGiaoHangDH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayGiaoHangDH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayGiaoHangDH.Location = new System.Drawing.Point(268, 134);
            this.txtNgayGiaoHangDH.Name = "txtNgayGiaoHangDH";
            this.txtNgayGiaoHangDH.Size = new System.Drawing.Size(227, 28);
            this.txtNgayGiaoHangDH.TabIndex = 39;
            // 
            // txtSoDienThoaiKH
            // 
            this.txtSoDienThoaiKH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoaiKH.Location = new System.Drawing.Point(784, 182);
            this.txtSoDienThoaiKH.Mask = "0000 000 000";
            this.txtSoDienThoaiKH.Name = "txtSoDienThoaiKH";
            this.txtSoDienThoaiKH.Size = new System.Drawing.Size(227, 28);
            this.txtSoDienThoaiKH.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(612, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Số điện thoại";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(784, 90);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(227, 28);
            this.txtTenKH.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã đơn hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(612, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Địa chỉ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(612, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(611, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(95, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(94, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ngày đặt hàng";
            // 
            // txtNgayDatHangDH
            // 
            this.txtNgayDatHangDH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayDatHangDH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayDatHangDH.Location = new System.Drawing.Point(268, 90);
            this.txtNgayDatHangDH.Name = "txtNgayDatHangDH";
            this.txtNgayDatHangDH.Size = new System.Drawing.Size(227, 28);
            this.txtNgayDatHangDH.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txtTongHD);
            this.panel3.Location = new System.Drawing.Point(0, 534);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1182, 43);
            this.panel3.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(790, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 20);
            this.label15.TabIndex = 33;
            this.label15.Text = "Tổng tiền";
            // 
            // txtTongHD
            // 
            this.txtTongHD.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongHD.ForeColor = System.Drawing.Color.Black;
            this.txtTongHD.Location = new System.Drawing.Point(898, 8);
            this.txtTongHD.Name = "txtTongHD";
            this.txtTongHD.Size = new System.Drawing.Size(200, 28);
            this.txtTongHD.TabIndex = 34;
            this.txtTongHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvDH);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmDonHang";
            this.Text = "frmDonHang";
            this.Load += new System.EventHandler(this.frmDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtSoDienThoaiKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtNgayDatHangDH;
        private System.Windows.Forms.TextBox txtTongTienDH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGiaSP;
        private System.Windows.Forms.TextBox txtSoLuongSP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker txtNgayGiaoHangDH;
        private System.Windows.Forms.ComboBox txtMaSP;
        private System.Windows.Forms.ComboBox txtMaNV;
        private System.Windows.Forms.ComboBox txtMaKH;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox txtMaDH;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTongHD;
    }
}