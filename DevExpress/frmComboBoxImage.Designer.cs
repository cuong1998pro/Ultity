
namespace DevExpress
{
    partial class frmComboBoxImage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComboBoxImage));
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboGioiTinh = new DevExpress.XtraEditors.ImageComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGioiTinh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "avatar_portrait_woman_female_redhead_1-32.png");
            this.imageCollection1.Images.SetKeyName(1, "male3-16.png");
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Giới tính:";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Location = new System.Drawing.Point(75, 62);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGioiTinh.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Male", ((short)(1)), 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Femail", ((short)(0)), 0)});
            this.cboGioiTinh.Properties.SmallImages = this.imageCollection1;
            this.cboGioiTinh.Size = new System.Drawing.Size(171, 20);
            this.cboGioiTinh.TabIndex = 2;
            this.cboGioiTinh.SelectedIndexChanged += new System.EventHandler(this.imageComboBoxEdit1_SelectedIndexChanged);
            // 
            // frmComboBoxImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmComboBoxImage";
            this.Text = "frmComboBoxImage";
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGioiTinh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utils.ImageCollection imageCollection1;
        private XtraEditors.LabelControl labelControl1;
        private XtraEditors.ImageComboBoxEdit cboGioiTinh;
    }
}