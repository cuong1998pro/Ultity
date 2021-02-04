
namespace QuanLyBanHang_Winform_Basic
{
    partial class frmDanhMucChatLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMucChatLieu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnNhapDL = new System.Windows.Forms.Panel();
            this.txtTenChatLieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaChatLieu = new System.Windows.Forms.TextBox();
            this.D = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvChatLieu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnNhapDL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChatLieu)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnBoQua);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 73);
            this.panel1.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(241, 18);
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
            this.btnBoQua.Location = new System.Drawing.Point(547, 18);
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
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.ForeColor = System.Drawing.Color.Blue;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(649, 18);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(86, 36);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(342, 18);
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
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(445, 18);
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
            this.btnThem.Location = new System.Drawing.Point(139, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 36);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnNhapDL
            // 
            this.pnNhapDL.Controls.Add(this.txtTenChatLieu);
            this.pnNhapDL.Controls.Add(this.label2);
            this.pnNhapDL.Controls.Add(this.txtMaChatLieu);
            this.pnNhapDL.Controls.Add(this.D);
            this.pnNhapDL.Controls.Add(this.label1);
            this.pnNhapDL.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNhapDL.Location = new System.Drawing.Point(0, 0);
            this.pnNhapDL.Name = "pnNhapDL";
            this.pnNhapDL.Size = new System.Drawing.Size(874, 125);
            this.pnNhapDL.TabIndex = 0;
            // 
            // txtTenChatLieu
            // 
            this.txtTenChatLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenChatLieu.Location = new System.Drawing.Point(134, 83);
            this.txtTenChatLieu.Name = "txtTenChatLieu";
            this.txtTenChatLieu.Size = new System.Drawing.Size(186, 21);
            this.txtTenChatLieu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(46, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên chất liệu";
            // 
            // txtMaChatLieu
            // 
            this.txtMaChatLieu.Enabled = false;
            this.txtMaChatLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChatLieu.Location = new System.Drawing.Point(134, 49);
            this.txtMaChatLieu.Name = "txtMaChatLieu";
            this.txtMaChatLieu.Size = new System.Drawing.Size(186, 21);
            this.txtMaChatLieu.TabIndex = 0;
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.ForeColor = System.Drawing.Color.Blue;
            this.D.Location = new System.Drawing.Point(46, 52);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(74, 15);
            this.D.TabIndex = 1;
            this.D.Text = "Mã chất liệu";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC CHẤT LIỆU";
            // 
            // dgvChatLieu
            // 
            this.dgvChatLieu.AllowUserToAddRows = false;
            this.dgvChatLieu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.dgvChatLieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChatLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChatLieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChatLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvChatLieu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvChatLieu.Location = new System.Drawing.Point(12, 6);
            this.dgvChatLieu.MultiSelect = false;
            this.dgvChatLieu.Name = "dgvChatLieu";
            this.dgvChatLieu.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChatLieu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChatLieu.RowHeadersVisible = false;
            this.dgvChatLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChatLieu.Size = new System.Drawing.Size(850, 321);
            this.dgvChatLieu.TabIndex = 0;
            this.dgvChatLieu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChatLieu_RowEnter);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "machatlieu";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Mã chất liệu";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "tenchatlieu";
            this.Column2.HeaderText = "Tên chất liệu";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvChatLieu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(874, 333);
            this.panel3.TabIndex = 1;
            // 
            // frmDanhMucChatLieu
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDong;
            this.ClientSize = new System.Drawing.Size(874, 531);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnNhapDL);
            this.Controls.Add(this.panel1);
            this.Name = "frmDanhMucChatLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh mục chất liệu";
            this.Load += new System.EventHandler(this.frmDanhMucChatLieu_Load);
            this.panel1.ResumeLayout(false);
            this.pnNhapDL.ResumeLayout(false);
            this.pnNhapDL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChatLieu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel pnNhapDL;
        private System.Windows.Forms.DataGridView dgvChatLieu;
        private System.Windows.Forms.TextBox txtTenChatLieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaChatLieu;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}