
namespace DocMaHTML
{
    partial class frmMain
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
            this.btnThucHien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHinhAnh = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flThuVienAnh = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoadAnh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(500, 23);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(96, 23);
            this.btnThucHien.TabIndex = 0;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(102, 24);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(381, 20);
            this.txtURL.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nội dung:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(102, 58);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(381, 58);
            this.txtNoiDung.TabIndex = 4;
            this.txtNoiDung.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hình ảnh";
            // 
            // lbHinhAnh
            // 
            this.lbHinhAnh.FormattingEnabled = true;
            this.lbHinhAnh.Location = new System.Drawing.Point(35, 167);
            this.lbHinhAnh.Name = "lbHinhAnh";
            this.lbHinhAnh.Size = new System.Drawing.Size(183, 290);
            this.lbHinhAnh.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thư viện ảnh:";
            // 
            // flThuVienAnh
            // 
            this.flThuVienAnh.Location = new System.Drawing.Point(231, 166);
            this.flThuVienAnh.Name = "flThuVienAnh";
            this.flThuVienAnh.Size = new System.Drawing.Size(364, 290);
            this.flThuVienAnh.TabIndex = 8;
            // 
            // btnLoadAnh
            // 
            this.btnLoadAnh.Location = new System.Drawing.Point(143, 136);
            this.btnLoadAnh.Name = "btnLoadAnh";
            this.btnLoadAnh.Size = new System.Drawing.Size(75, 23);
            this.btnLoadAnh.TabIndex = 9;
            this.btnLoadAnh.Text = "Load ảnh";
            this.btnLoadAnh.UseVisualStyleBackColor = true;
            this.btnLoadAnh.Click += new System.EventHandler(this.btnLoadAnh_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 467);
            this.Controls.Add(this.btnLoadAnh);
            this.Controls.Add(this.flThuVienAnh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbHinhAnh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThucHien);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtNoiDung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbHinhAnh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flThuVienAnh;
        private System.Windows.Forms.Button btnLoadAnh;
    }
}

