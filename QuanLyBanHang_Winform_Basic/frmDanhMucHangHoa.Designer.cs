
namespace QuanLyBanHang_Winform_Basic
{
    partial class frmDanhMucHangHoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMucHangHoa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.pnNhapDL = new System.Windows.Forms.Panel();
            this.nmrDonGiaXuat = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nmrDonGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nmrSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.cboChatLieu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.D = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.pnNhapDL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDonGiaXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDonGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvHangHoa);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 240);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(870, 310);
            this.panel3.TabIndex = 1;
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AllowUserToAddRows = false;
            this.dgvHangHoa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Blue;
            this.dgvHangHoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHangHoa.BackgroundColor = System.Drawing.Color.White;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Anh});
            this.dgvHangHoa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHangHoa.Location = new System.Drawing.Point(12, 6);
            this.dgvHangHoa.MultiSelect = false;
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHangHoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvHangHoa.RowHeadersVisible = false;
            this.dgvHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHangHoa.Size = new System.Drawing.Size(846, 298);
            this.dgvHangHoa.TabIndex = 0;
            this.dgvHangHoa.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_RowEnter);
            // 
            // pnNhapDL
            // 
            this.pnNhapDL.Controls.Add(this.nmrDonGiaXuat);
            this.pnNhapDL.Controls.Add(this.label7);
            this.pnNhapDL.Controls.Add(this.nmrDonGiaNhap);
            this.pnNhapDL.Controls.Add(this.label6);
            this.pnNhapDL.Controls.Add(this.nmrSoLuong);
            this.pnNhapDL.Controls.Add(this.label5);
            this.pnNhapDL.Controls.Add(this.txtGhiChu);
            this.pnNhapDL.Controls.Add(this.btnChonAnh);
            this.pnNhapDL.Controls.Add(this.txtAnh);
            this.pnNhapDL.Controls.Add(this.picAnh);
            this.pnNhapDL.Controls.Add(this.cboChatLieu);
            this.pnNhapDL.Controls.Add(this.label4);
            this.pnNhapDL.Controls.Add(this.txtDiaChi);
            this.pnNhapDL.Controls.Add(this.label3);
            this.pnNhapDL.Controls.Add(this.txtTenHang);
            this.pnNhapDL.Controls.Add(this.label2);
            this.pnNhapDL.Controls.Add(this.txtMaHang);
            this.pnNhapDL.Controls.Add(this.D);
            this.pnNhapDL.Controls.Add(this.label1);
            this.pnNhapDL.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNhapDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnNhapDL.Location = new System.Drawing.Point(0, 0);
            this.pnNhapDL.Name = "pnNhapDL";
            this.pnNhapDL.Size = new System.Drawing.Size(870, 240);
            this.pnNhapDL.TabIndex = 0;
            // 
            // nmrDonGiaXuat
            // 
            this.nmrDonGiaXuat.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrDonGiaXuat.Location = new System.Drawing.Point(118, 184);
            this.nmrDonGiaXuat.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nmrDonGiaXuat.Name = "nmrDonGiaXuat";
            this.nmrDonGiaXuat.Size = new System.Drawing.Size(186, 21);
            this.nmrDonGiaXuat.TabIndex = 5;
            this.nmrDonGiaXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmrDonGiaXuat.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(26, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Đơn giá bán";
            // 
            // nmrDonGiaNhap
            // 
            this.nmrDonGiaNhap.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrDonGiaNhap.Location = new System.Drawing.Point(118, 153);
            this.nmrDonGiaNhap.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nmrDonGiaNhap.Name = "nmrDonGiaNhap";
            this.nmrDonGiaNhap.Size = new System.Drawing.Size(186, 21);
            this.nmrDonGiaNhap.TabIndex = 4;
            this.nmrDonGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmrDonGiaNhap.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(26, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Đơn giá nhập";
            // 
            // nmrSoLuong
            // 
            this.nmrSoLuong.Location = new System.Drawing.Point(118, 123);
            this.nmrSoLuong.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nmrSoLuong.Name = "nmrSoLuong";
            this.nmrSoLuong.Size = new System.Drawing.Size(186, 21);
            this.nmrSoLuong.TabIndex = 3;
            this.nmrSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmrSoLuong.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(26, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Số lượng";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(433, 125);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(186, 76);
            this.txtGhiChu.TabIndex = 9;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(582, 90);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(37, 23);
            this.btnChonAnh.TabIndex = 8;
            this.btnChonAnh.Text = "...";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // txtAnh
            // 
            this.txtAnh.Enabled = false;
            this.txtAnh.Location = new System.Drawing.Point(433, 91);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(143, 21);
            this.txtAnh.TabIndex = 7;
            // 
            // picAnh
            // 
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.Location = new System.Drawing.Point(666, 56);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(151, 149);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 17;
            this.picAnh.TabStop = false;
            this.picAnh.WaitOnLoad = true;
            // 
            // cboChatLieu
            // 
            this.cboChatLieu.FormattingEnabled = true;
            this.cboChatLieu.Location = new System.Drawing.Point(433, 57);
            this.cboChatLieu.Name = "cboChatLieu";
            this.cboChatLieu.Size = new System.Drawing.Size(186, 23);
            this.cboChatLieu.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(345, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ghi chú";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoSize = true;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.Blue;
            this.txtDiaChi.Location = new System.Drawing.Point(345, 94);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(28, 15);
            this.txtDiaChi.TabIndex = 8;
            this.txtDiaChi.Text = "Ảnh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(341, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chất liệu";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHang.Location = new System.Drawing.Point(118, 91);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(186, 21);
            this.txtTenHang.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(26, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên hàng";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Enabled = false;
            this.txtMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHang.Location = new System.Drawing.Point(118, 59);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(186, 21);
            this.txtMaHang.TabIndex = 1;
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.ForeColor = System.Drawing.Color.Blue;
            this.D.Location = new System.Drawing.Point(26, 62);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(56, 15);
            this.D.TabIndex = 1;
            this.D.Text = "Mã hàng";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC HÀNG HOÁ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnBoQua);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 73);
            this.panel1.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLamMoi.ForeColor = System.Drawing.Color.Blue;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(627, 18);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(86, 36);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "&Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTimKiem.ForeColor = System.Drawing.Color.Blue;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(533, 18);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(86, 36);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "&Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(157, 18);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 36);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "&Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBoQua.Enabled = false;
            this.btnBoQua.ForeColor = System.Drawing.Color.Blue;
            this.btnBoQua.Image = ((System.Drawing.Image)(resources.GetObject("btnBoQua.Image")));
            this.btnBoQua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoQua.Location = new System.Drawing.Point(439, 18);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(86, 36);
            this.btnBoQua.TabIndex = 4;
            this.btnBoQua.Text = "&Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDong.ForeColor = System.Drawing.Color.Blue;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(721, 18);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(86, 36);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(251, 18);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 36);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.Enabled = false;
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(345, 18);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(86, 36);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.ForeColor = System.Drawing.Color.Blue;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(63, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 36);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "MaHang";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column1.HeaderText = "Mã hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "TenHang";
            this.Column2.HeaderText = "Tên hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 180;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.DataPropertyName = "TenChatLieu";
            this.Column6.HeaderText = "Chất liệu";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuong";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "DonGiaNhap";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column4.HeaderText = "Đơn giá nhập";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N0";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column5.HeaderText = "Đơn giá bán";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "GhiChu";
            this.Column7.HeaderText = "Ghi chú";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Anh
            // 
            this.Anh.DataPropertyName = "Anh";
            this.Anh.HeaderText = "Anh";
            this.Anh.Name = "Anh";
            this.Anh.ReadOnly = true;
            this.Anh.Visible = false;
            // 
            // frmDanhMucHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 623);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnNhapDL);
            this.Controls.Add(this.panel1);
            this.Name = "frmDanhMucHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh mục hàng hoá";
            this.Load += new System.EventHandler(this.frmDanhMucHangHoa_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.pnNhapDL.ResumeLayout(false);
            this.pnNhapDL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDonGiaXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDonGiaNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Panel pnNhapDL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.ComboBox cboChatLieu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.NumericUpDown nmrDonGiaXuat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmrDonGiaNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmrSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anh;
    }
}