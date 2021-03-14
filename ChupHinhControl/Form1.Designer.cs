
namespace ChupHinhControl
{
    partial class Form1
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
            this.btnTest = new System.Windows.Forms.Button();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.lbTest = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDoiTuong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picKetQua = new System.Windows.Forms.PictureBox();
            this.btnChup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(16, 19);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(185, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(16, 48);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(185, 20);
            this.txtTest.TabIndex = 1;
            this.txtTest.Text = "Lập trình VB";
            // 
            // lbTest
            // 
            this.lbTest.FormattingEnabled = true;
            this.lbTest.Location = new System.Drawing.Point(225, 25);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(145, 43);
            this.lbTest.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn đối tượng:";
            // 
            // cboDoiTuong
            // 
            this.cboDoiTuong.FormattingEnabled = true;
            this.cboDoiTuong.Items.AddRange(new object[] {
            "txtTest",
            "btnTest",
            "lbTest"});
            this.cboDoiTuong.Location = new System.Drawing.Point(107, 85);
            this.cboDoiTuong.Name = "cboDoiTuong";
            this.cboDoiTuong.Size = new System.Drawing.Size(159, 21);
            this.cboDoiTuong.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kết quả:";
            // 
            // picKetQua
            // 
            this.picKetQua.Location = new System.Drawing.Point(75, 122);
            this.picKetQua.Name = "picKetQua";
            this.picKetQua.Size = new System.Drawing.Size(295, 147);
            this.picKetQua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKetQua.TabIndex = 6;
            this.picKetQua.TabStop = false;
            // 
            // btnChup
            // 
            this.btnChup.Location = new System.Drawing.Point(272, 84);
            this.btnChup.Name = "btnChup";
            this.btnChup.Size = new System.Drawing.Size(98, 23);
            this.btnChup.TabIndex = 7;
            this.btnChup.Text = "Chụp";
            this.btnChup.UseVisualStyleBackColor = true;
            this.btnChup.Click += new System.EventHandler(this.btnChup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 299);
            this.Controls.Add(this.btnChup);
            this.Controls.Add(this.picKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboDoiTuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTest);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.btnTest);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.ListBox lbTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDoiTuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picKetQua;
        private System.Windows.Forms.Button btnChup;
    }
}

