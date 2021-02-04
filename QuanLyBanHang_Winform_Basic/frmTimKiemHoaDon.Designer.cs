
namespace QuanLyBanHang_Winform_Basic
{
    partial class frmTimKiemHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemHoaDon));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimLai = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMaHoaDon = new System.Windows.Forms.ComboBox();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMaKhachHang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nmrTongTien = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTongTien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.dgvHoaDon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(874, 294);
            this.panel3.TabIndex = 4;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvHoaDon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHoaDon.Location = new System.Drawing.Point(12, 6);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(850, 265);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nmrTongTien);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cboMaKhachHang);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cboMaNhanVien);
            this.panel2.Controls.Add(this.cboMaHoaDon);
            this.panel2.Controls.Add(this.txtNam);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtThang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.D);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 164);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtThang
            // 
            this.txtThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.Location = new System.Drawing.Point(134, 81);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(45, 21);
            this.txtThang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(46, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tháng";
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.ForeColor = System.Drawing.Color.Blue;
            this.D.Location = new System.Drawing.Point(46, 52);
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
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM HOÁ ĐƠN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnTimLai);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 73);
            this.panel1.TabIndex = 5;
            // 
            // btnTimLai
            // 
            this.btnTimLai.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTimLai.ForeColor = System.Drawing.Color.Blue;
            this.btnTimLai.Image = ((System.Drawing.Image)(resources.GetObject("btnTimLai.Image")));
            this.btnTimLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimLai.Location = new System.Drawing.Point(394, 18);
            this.btnTimLai.Name = "btnTimLai";
            this.btnTimLai.Size = new System.Drawing.Size(86, 36);
            this.btnTimLai.TabIndex = 4;
            this.btnTimLai.Text = "&Tìm lại";
            this.btnTimLai.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDong.ForeColor = System.Drawing.Color.Blue;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(496, 18);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(86, 36);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(14, 313);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(279, 15);
            this.label15.TabIndex = 38;
            this.label15.Text = "Nhấn đúp vào hoá đơn để hiển thị tìm kiếm chi tiết";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTimKiem.ForeColor = System.Drawing.Color.Blue;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(292, 18);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(86, 36);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "&Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(14, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nhấn đúp vào hoá đơn dể hiển thị thông tin chi tiết";
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(255, 81);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(65, 21);
            this.txtNam.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(198, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Năm";
            // 
            // cboMaHoaDon
            // 
            this.cboMaHoaDon.FormattingEnabled = true;
            this.cboMaHoaDon.Location = new System.Drawing.Point(134, 49);
            this.cboMaHoaDon.Name = "cboMaHoaDon";
            this.cboMaHoaDon.Size = new System.Drawing.Size(186, 21);
            this.cboMaHoaDon.TabIndex = 25;
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(134, 113);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(186, 21);
            this.cboMaNhanVien.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(46, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Mã nhân viên";
            // 
            // cboMaKhachHang
            // 
            this.cboMaKhachHang.FormattingEnabled = true;
            this.cboMaKhachHang.Location = new System.Drawing.Point(561, 49);
            this.cboMaKhachHang.Name = "cboMaKhachHang";
            this.cboMaKhachHang.Size = new System.Drawing.Size(186, 21);
            this.cboMaKhachHang.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(461, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Mã khách hàng";
            // 
            // nmrTongTien
            // 
            this.nmrTongTien.Enabled = false;
            this.nmrTongTien.Location = new System.Drawing.Point(561, 81);
            this.nmrTongTien.Name = "nmrTongTien";
            this.nmrTongTien.Size = new System.Drawing.Size(186, 20);
            this.nmrTongTien.TabIndex = 34;
            this.nmrTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(461, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 33;
            this.label10.Text = "Tổng tiền";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Mã HDB";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "Nhân viên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.HeaderText = "Ngày bán";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.HeaderText = "Mã khách";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 180;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Tổng tiền";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // frmTimKiemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 531);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTimKiemHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiếm hoá đơn";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrTongTien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimLai;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMaKhachHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.ComboBox cboMaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.NumericUpDown nmrTongTien;
        private System.Windows.Forms.Label label10;
    }
}