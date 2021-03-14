
namespace LayTyGiaNgoaiTeXML
{
    partial class frmTyGia
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
            this.dgvTyGia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTyGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTyGia
            // 
            this.dgvTyGia.BackgroundColor = System.Drawing.Color.White;
            this.dgvTyGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTyGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTyGia.Location = new System.Drawing.Point(0, 0);
            this.dgvTyGia.Name = "dgvTyGia";
            this.dgvTyGia.Size = new System.Drawing.Size(800, 450);
            this.dgvTyGia.TabIndex = 0;
            // 
            // frmTyGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTyGia);
            this.Name = "frmTyGia";
            this.Text = "LayTyGiaNgoaiTe";
            this.Load += new System.EventHandler(this.frmTyGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTyGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTyGia;
    }
}

