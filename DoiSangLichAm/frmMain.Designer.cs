
namespace DoiSangLichAm
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
            this.btnDoiSangAmLich = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dpkNgayDuongLich = new System.Windows.Forms.DateTimePicker();
            this.dpkNgayAmLich = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDoiSangAmLich
            // 
            this.btnDoiSangAmLich.Location = new System.Drawing.Point(21, 88);
            this.btnDoiSangAmLich.Name = "btnDoiSangAmLich";
            this.btnDoiSangAmLich.Size = new System.Drawing.Size(102, 26);
            this.btnDoiSangAmLich.TabIndex = 0;
            this.btnDoiSangAmLich.Text = "Đổi sang âm lịch";
            this.btnDoiSangAmLich.UseVisualStyleBackColor = true;
            this.btnDoiSangAmLich.Click += new System.EventHandler(this.btnDoiSangAmLich_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày dương lịch:";
            // 
            // dpkNgayDuongLich
            // 
            this.dpkNgayDuongLich.CustomFormat = "dd/MM/yyyy";
            this.dpkNgayDuongLich.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkNgayDuongLich.Location = new System.Drawing.Point(129, 25);
            this.dpkNgayDuongLich.Name = "dpkNgayDuongLich";
            this.dpkNgayDuongLich.Size = new System.Drawing.Size(158, 20);
            this.dpkNgayDuongLich.TabIndex = 2;
            // 
            // dpkNgayAmLich
            // 
            this.dpkNgayAmLich.CustomFormat = "dd/MM/yyyy";
            this.dpkNgayAmLich.Enabled = false;
            this.dpkNgayAmLich.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkNgayAmLich.Location = new System.Drawing.Point(129, 53);
            this.dpkNgayAmLich.Name = "dpkNgayAmLich";
            this.dpkNgayAmLich.Size = new System.Drawing.Size(158, 20);
            this.dpkNgayAmLich.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày âm lịch:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 136);
            this.Controls.Add(this.dpkNgayAmLich);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dpkNgayDuongLich);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoiSangAmLich);
            this.Name = "frmMain";
            this.Text = "Đổi sang lịch âm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoiSangAmLich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpkNgayDuongLich;
        private System.Windows.Forms.DateTimePicker dpkNgayAmLich;
        private System.Windows.Forms.Label label2;
    }
}

