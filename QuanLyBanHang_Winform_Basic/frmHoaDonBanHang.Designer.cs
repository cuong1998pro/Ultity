
using System.Windows.Forms;

namespace QuanLyBanHang_Winform_Basic
{
    partial class frmHoaDonBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonBanHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnNhapDL2 = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblBangChu = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnHuyHoaDon = new System.Windows.Forms.Button();
            this.nmrDonGia = new System.Windows.Forms.NumericUpDown();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnLuuHoaDon = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.nmrSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nmrThanhTien = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.nmrGiamGia = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboMaHang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnNhapDL = new System.Windows.Forms.GroupBox();
            this.cboMaKhach = new System.Windows.Forms.ComboBox();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.dpkNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaKhach = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.D = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.cboMaHoaDonTimKiem = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHDBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucNang = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnNhapDL2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrThanhTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiamGia)).BeginInit();
            this.pnNhapDL.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.AllowUserToAddRows = false;
            this.dgvChiTietHoaDon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.dgvChiTietHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTietHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHang,
            this.SoLuong,
            this.DonGia,
            this.GiamGia,
            this.ThanhTien,
            this.MaHDBan,
            this.ChucNang});
            this.dgvChiTietHoaDon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(16, 92);
            this.dgvChiTietHoaDon.MultiSelect = false;
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvChiTietHoaDon.RowHeadersVisible = false;
            this.dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(801, 173);
            this.dgvChiTietHoaDon.TabIndex = 6;
            this.dgvChiTietHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHoaDon_CellClick);
            this.dgvChiTietHoaDon.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHoaDon_RowEnter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnNhapDL2);
            this.panel2.Controls.Add(this.pnNhapDL);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 570);
            this.panel2.TabIndex = 0;
            // 
            // pnNhapDL2
            // 
            this.pnNhapDL2.Controls.Add(this.txtTongTien);
            this.pnNhapDL2.Controls.Add(this.label17);
            this.pnNhapDL2.Controls.Add(this.lblBangChu);
            this.pnNhapDL2.Controls.Add(this.label15);
            this.pnNhapDL2.Controls.Add(this.btnDong);
            this.pnNhapDL2.Controls.Add(this.btnHuyHoaDon);
            this.pnNhapDL2.Controls.Add(this.nmrDonGia);
            this.pnNhapDL2.Controls.Add(this.btnInHoaDon);
            this.pnNhapDL2.Controls.Add(this.btnLuuHoaDon);
            this.pnNhapDL2.Controls.Add(this.label12);
            this.pnNhapDL2.Controls.Add(this.nmrSoLuong);
            this.pnNhapDL2.Controls.Add(this.label13);
            this.pnNhapDL2.Controls.Add(this.nmrThanhTien);
            this.pnNhapDL2.Controls.Add(this.btnThem);
            this.pnNhapDL2.Controls.Add(this.label10);
            this.pnNhapDL2.Controls.Add(this.nmrGiamGia);
            this.pnNhapDL2.Controls.Add(this.label11);
            this.pnNhapDL2.Controls.Add(this.txtTenHang);
            this.pnNhapDL2.Controls.Add(this.label9);
            this.pnNhapDL2.Controls.Add(this.cboMaHang);
            this.pnNhapDL2.Controls.Add(this.label8);
            this.pnNhapDL2.Controls.Add(this.dgvChiTietHoaDon);
            this.pnNhapDL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnNhapDL2.Location = new System.Drawing.Point(26, 205);
            this.pnNhapDL2.Name = "pnNhapDL2";
            this.pnNhapDL2.Size = new System.Drawing.Size(834, 361);
            this.pnNhapDL2.TabIndex = 1;
            this.pnNhapDL2.TabStop = false;
            this.pnNhapDL2.Text = "Thông tin các mặt hàng";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(626, 281);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(186, 21);
            this.txtTongTien.TabIndex = 12;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(534, 284);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 15);
            this.label17.TabIndex = 40;
            this.label17.Text = "Tổng tiền";
            // 
            // lblBangChu
            // 
            this.lblBangChu.AutoSize = true;
            this.lblBangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBangChu.ForeColor = System.Drawing.Color.Blue;
            this.lblBangChu.Location = new System.Drawing.Point(21, 296);
            this.lblBangChu.Name = "lblBangChu";
            this.lblBangChu.Size = new System.Drawing.Size(132, 15);
            this.lblBangChu.TabIndex = 38;
            this.lblBangChu.Text = "Bằng chữ: Không đồng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(19, 273);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 15);
            this.label15.TabIndex = 37;
            this.label15.Text = "Nhấn đúp một dòng để xoá";
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDong.ForeColor = System.Drawing.Color.Blue;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(658, 325);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(142, 30);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnHuyHoaDon
            // 
            this.btnHuyHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHuyHoaDon.Enabled = false;
            this.btnHuyHoaDon.ForeColor = System.Drawing.Color.Blue;
            this.btnHuyHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyHoaDon.Image")));
            this.btnHuyHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyHoaDon.Location = new System.Drawing.Point(181, 325);
            this.btnHuyHoaDon.Name = "btnHuyHoaDon";
            this.btnHuyHoaDon.Size = new System.Drawing.Size(142, 30);
            this.btnHuyHoaDon.TabIndex = 8;
            this.btnHuyHoaDon.Text = "&Huỷ hoá đơn";
            this.btnHuyHoaDon.UseVisualStyleBackColor = true;
            this.btnHuyHoaDon.Click += new System.EventHandler(this.btnHuyHoaDon_Click);
            // 
            // nmrDonGia
            // 
            this.nmrDonGia.Location = new System.Drawing.Point(374, 58);
            this.nmrDonGia.Maximum = new decimal(new int[] {
            -469762048,
            -590869294,
            5421010,
            0});
            this.nmrDonGia.Name = "nmrDonGia";
            this.nmrDonGia.Size = new System.Drawing.Size(135, 21);
            this.nmrDonGia.TabIndex = 3;
            this.nmrDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmrDonGia.ThousandsSeparator = true;
            this.nmrDonGia.ValueChanged += new System.EventHandler(this.nmrDonGia_ValueChanged);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInHoaDon.ForeColor = System.Drawing.Color.Blue;
            this.btnInHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnInHoaDon.Image")));
            this.btnInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoaDon.Location = new System.Drawing.Point(499, 325);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(142, 30);
            this.btnInHoaDon.TabIndex = 10;
            this.btnInHoaDon.Text = "&In hoá đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnLuuHoaDon
            // 
            this.btnLuuHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuuHoaDon.Enabled = false;
            this.btnLuuHoaDon.ForeColor = System.Drawing.Color.Blue;
            this.btnLuuHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuHoaDon.Image")));
            this.btnLuuHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuHoaDon.Location = new System.Drawing.Point(340, 325);
            this.btnLuuHoaDon.Name = "btnLuuHoaDon";
            this.btnLuuHoaDon.Size = new System.Drawing.Size(142, 30);
            this.btnLuuHoaDon.TabIndex = 9;
            this.btnLuuHoaDon.Text = "&Lưu hoá đơn";
            this.btnLuuHoaDon.UseVisualStyleBackColor = true;
            this.btnLuuHoaDon.Click += new System.EventHandler(this.btnLuuHoaDon_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(300, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 15);
            this.label12.TabIndex = 35;
            this.label12.Text = "Đơn giá";
            // 
            // nmrSoLuong
            // 
            this.nmrSoLuong.Location = new System.Drawing.Point(374, 29);
            this.nmrSoLuong.Maximum = new decimal(new int[] {
            -469762048,
            -590869294,
            5421010,
            0});
            this.nmrSoLuong.Name = "nmrSoLuong";
            this.nmrSoLuong.Size = new System.Drawing.Size(135, 21);
            this.nmrSoLuong.TabIndex = 2;
            this.nmrSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmrSoLuong.ThousandsSeparator = true;
            this.nmrSoLuong.ValueChanged += new System.EventHandler(this.nmrSoLuong_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(300, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 15);
            this.label13.TabIndex = 33;
            this.label13.Text = "Số lượng";
            // 
            // nmrThanhTien
            // 
            this.nmrThanhTien.Enabled = false;
            this.nmrThanhTien.Location = new System.Drawing.Point(631, 58);
            this.nmrThanhTien.Maximum = new decimal(new int[] {
            -469762048,
            -590869294,
            5421010,
            0});
            this.nmrThanhTien.Name = "nmrThanhTien";
            this.nmrThanhTien.Size = new System.Drawing.Size(135, 21);
            this.nmrThanhTien.TabIndex = 5;
            this.nmrThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmrThanhTien.ThousandsSeparator = true;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.ForeColor = System.Drawing.Color.Blue;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(22, 325);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(142, 30);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "&Thêm hoá đơn";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(539, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "Thành tiền";
            // 
            // nmrGiamGia
            // 
            this.nmrGiamGia.Location = new System.Drawing.Point(631, 29);
            this.nmrGiamGia.Name = "nmrGiamGia";
            this.nmrGiamGia.Size = new System.Drawing.Size(135, 21);
            this.nmrGiamGia.TabIndex = 4;
            this.nmrGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmrGiamGia.ThousandsSeparator = true;
            this.nmrGiamGia.ValueChanged += new System.EventHandler(this.nmrGiamGia_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(539, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Giảm giá (%)";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Enabled = false;
            this.txtTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHang.Location = new System.Drawing.Point(118, 58);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(135, 21);
            this.txtTenHang.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(34, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Tên hàng";
            // 
            // cboMaHang
            // 
            this.cboMaHang.FormattingEnabled = true;
            this.cboMaHang.Location = new System.Drawing.Point(118, 28);
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.Size = new System.Drawing.Size(135, 23);
            this.cboMaHang.TabIndex = 0;
            this.cboMaHang.SelectionChangeCommitted += new System.EventHandler(this.cboMaHang_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(34, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mã hàng";
            // 
            // pnNhapDL
            // 
            this.pnNhapDL.Controls.Add(this.cboMaKhach);
            this.pnNhapDL.Controls.Add(this.cboMaNhanVien);
            this.pnNhapDL.Controls.Add(this.dpkNgayBan);
            this.pnNhapDL.Controls.Add(this.txtDiaChi);
            this.pnNhapDL.Controls.Add(this.label7);
            this.pnNhapDL.Controls.Add(this.txtTenKhach);
            this.pnNhapDL.Controls.Add(this.label6);
            this.pnNhapDL.Controls.Add(this.txtTenNhanVien);
            this.pnNhapDL.Controls.Add(this.label5);
            this.pnNhapDL.Controls.Add(this.label3);
            this.pnNhapDL.Controls.Add(this.mtxtDienThoai);
            this.pnNhapDL.Controls.Add(this.label4);
            this.pnNhapDL.Controls.Add(this.lblMaKhach);
            this.pnNhapDL.Controls.Add(this.label2);
            this.pnNhapDL.Controls.Add(this.txtMaHoaDon);
            this.pnNhapDL.Controls.Add(this.D);
            this.pnNhapDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnNhapDL.Location = new System.Drawing.Point(26, 35);
            this.pnNhapDL.Name = "pnNhapDL";
            this.pnNhapDL.Size = new System.Drawing.Size(835, 164);
            this.pnNhapDL.TabIndex = 0;
            this.pnNhapDL.TabStop = false;
            this.pnNhapDL.Text = "Thông tin chung";
            // 
            // cboMaKhach
            // 
            this.cboMaKhach.FormattingEnabled = true;
            this.cboMaKhach.Location = new System.Drawing.Point(519, 25);
            this.cboMaKhach.Name = "cboMaKhach";
            this.cboMaKhach.Size = new System.Drawing.Size(186, 23);
            this.cboMaKhach.TabIndex = 4;
            this.cboMaKhach.SelectionChangeCommitted += new System.EventHandler(this.cboMaKhach_SeletedIndexChangeCommitted);
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(128, 88);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(186, 23);
            this.cboMaNhanVien.TabIndex = 2;
            this.cboMaNhanVien.SelectionChangeCommitted += new System.EventHandler(this.cboMaNhanVien_SelectionChangeCommitted);
            // 
            // dpkNgayBan
            // 
            this.dpkNgayBan.CustomFormat = "dd/MM/yyyy";
            this.dpkNgayBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkNgayBan.Location = new System.Drawing.Point(128, 58);
            this.dpkNgayBan.Name = "dpkNgayBan";
            this.dpkNgayBan.Size = new System.Drawing.Size(186, 21);
            this.dpkNgayBan.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(519, 88);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(186, 21);
            this.txtDiaChi.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(431, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Địa chỉ";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Enabled = false;
            this.txtTenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhach.Location = new System.Drawing.Point(519, 58);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(186, 21);
            this.txtTenKhach.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(431, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tên khách";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Enabled = false;
            this.txtTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhanVien.Location = new System.Drawing.Point(128, 118);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(186, 21);
            this.txtTenNhanVien.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(36, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(36, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã nhân viên";
            // 
            // mtxtDienThoai
            // 
            this.mtxtDienThoai.Enabled = false;
            this.mtxtDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDienThoai.Location = new System.Drawing.Point(519, 118);
            this.mtxtDienThoai.Mask = "(999) 000-0000";
            this.mtxtDienThoai.Name = "mtxtDienThoai";
            this.mtxtDienThoai.Size = new System.Drawing.Size(186, 21);
            this.mtxtDienThoai.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(431, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Điện thoại";
            // 
            // lblMaKhach
            // 
            this.lblMaKhach.AutoSize = true;
            this.lblMaKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhach.ForeColor = System.Drawing.Color.Blue;
            this.lblMaKhach.Location = new System.Drawing.Point(431, 28);
            this.lblMaKhach.Name = "lblMaKhach";
            this.lblMaKhach.Size = new System.Drawing.Size(61, 15);
            this.lblMaKhach.TabIndex = 8;
            this.lblMaKhach.Text = "Mã khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(36, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày bán";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Enabled = false;
            this.txtMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.Location = new System.Drawing.Point(128, 25);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(186, 21);
            this.txtMaHoaDon.TabIndex = 0;
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.ForeColor = System.Drawing.Color.Blue;
            this.D.Location = new System.Drawing.Point(36, 28);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(73, 15);
            this.D.TabIndex = 1;
            this.D.Text = "Mã hoá đơn";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOÁ ĐƠN BÁN HÀNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 542);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 73);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.cboMaHoaDonTimKiem);
            this.panel3.Controls.Add(this.btnTimKiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(874, 49);
            this.panel3.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(51, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 15);
            this.label14.TabIndex = 26;
            this.label14.Text = "Mã hoá đơn";
            // 
            // cboMaHoaDonTimKiem
            // 
            this.cboMaHoaDonTimKiem.FormattingEnabled = true;
            this.cboMaHoaDonTimKiem.Location = new System.Drawing.Point(143, 15);
            this.cboMaHoaDonTimKiem.Name = "cboMaHoaDonTimKiem";
            this.cboMaHoaDonTimKiem.Size = new System.Drawing.Size(186, 21);
            this.cboMaHoaDonTimKiem.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTimKiem.ForeColor = System.Drawing.Color.Blue;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(337, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 26);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "&Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // MaHang
            // 
            this.MaHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaHang.DataPropertyName = "MaHang";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaHang.HeaderText = "Mã hàng";
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            this.MaHang.Width = 80;
            // 
            // TenHang
            // 
            this.TenHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            this.TenHang.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle3;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 120;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.DonGia.DefaultCellStyle = dataGridViewCellStyle4;
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // GiamGia
            // 
            this.GiamGia.DataPropertyName = "GiamGia";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.GiamGia.DefaultCellStyle = dataGridViewCellStyle5;
            this.GiamGia.HeaderText = "Giảm giá(%)";
            this.GiamGia.Name = "GiamGia";
            this.GiamGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle6;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // MaHDBan
            // 
            this.MaHDBan.DataPropertyName = "MaHDBan";
            this.MaHDBan.HeaderText = "MaHDBan";
            this.MaHDBan.Name = "MaHDBan";
            this.MaHDBan.ReadOnly = true;
            this.MaHDBan.Visible = false;
            // 
            // ChucNang
            // 
            this.ChucNang.HeaderText = "Chức năng";
            this.ChucNang.Name = "ChucNang";
            this.ChucNang.ReadOnly = true;
            this.ChucNang.Text = "Xoá";
            this.ChucNang.UseColumnTextForButtonValue = true;
            // 
            // frmHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmHoaDonBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hoá đơn bán hàng";
            this.Load += new System.EventHandler(this.frmHoaDonBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnNhapDL2.ResumeLayout(false);
            this.pnNhapDL2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrThanhTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiamGia)).EndInit();
            this.pnNhapDL.ResumeLayout(false);
            this.pnNhapDL.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox mtxtDienThoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaKhach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuyHoaDon;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox pnNhapDL;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dpkNgayBan;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.GroupBox pnNhapDL2;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboMaHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmrDonGia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nmrSoLuong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nmrThanhTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nmrGiamGia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblBangChu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboMaHoaDonTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboMaKhach;
        private DataGridViewTextBoxColumn MaHang;
        private DataGridViewTextBoxColumn TenHang;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn GiamGia;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewTextBoxColumn MaHDBan;
        private DataGridViewButtonColumn ChucNang;
    }
}