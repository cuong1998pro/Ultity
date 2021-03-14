
namespace KiemTraMaSoThue
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSoThue = new System.Windows.Forms.TextBox();
            this.btnKiemTraMaSoThue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số thuế";
            // 
            // txtMaSoThue
            // 
            this.txtMaSoThue.Location = new System.Drawing.Point(90, 23);
            this.txtMaSoThue.Name = "txtMaSoThue";
            this.txtMaSoThue.Size = new System.Drawing.Size(131, 20);
            this.txtMaSoThue.TabIndex = 1;
            // 
            // btnKiemTraMaSoThue
            // 
            this.btnKiemTraMaSoThue.Location = new System.Drawing.Point(25, 55);
            this.btnKiemTraMaSoThue.Name = "btnKiemTraMaSoThue";
            this.btnKiemTraMaSoThue.Size = new System.Drawing.Size(132, 23);
            this.btnKiemTraMaSoThue.TabIndex = 2;
            this.btnKiemTraMaSoThue.Text = "Kiểm tra mã số thuế";
            this.btnKiemTraMaSoThue.UseVisualStyleBackColor = true;
            this.btnKiemTraMaSoThue.Click += new System.EventHandler(this.btnKiemTraMaSoThue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 99);
            this.Controls.Add(this.btnKiemTraMaSoThue);
            this.Controls.Add(this.txtMaSoThue);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSoThue;
        private System.Windows.Forms.Button btnKiemTraMaSoThue;
    }
}

