
namespace QuanLyDiem.Forms
{
    partial class frmThongKeSinhVienTheoLop
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cboLop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSSinhVien = new QuanLyDiem.DSSinhVien();
            this.dSSinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SinhVien_SelectMaLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVien_SelectMaLopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboLop
            // 
            this.cboLop.DisplayMember = "Text";
            this.cboLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.ItemHeight = 17;
            this.cboLop.Location = new System.Drawing.Point(24, 12);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(144, 23);
            this.cboLop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboLop.TabIndex = 1;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.reportViewer1);
            this.panelEx1.Controls.Add(this.cboLop);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(934, 536);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.DocumentMapWidth = 42;
            reportDataSource1.Name = "DSSinhVien";
            reportDataSource1.Value = this.SinhVien_SelectMaLopBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyDiem.Forms.ReportThongKeSinhVien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(934, 492);
            this.reportViewer1.TabIndex = 2;
            // 
            // dSSinhVien
            // 
            this.dSSinhVien.DataSetName = "DSSinhVien";
            this.dSSinhVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSSinhVienBindingSource
            // 
            this.dSSinhVienBindingSource.DataSource = this.dSSinhVien;
            this.dSSinhVienBindingSource.Position = 0;
            // 
            // SinhVien_SelectMaLopBindingSource
            // 
            this.SinhVien_SelectMaLopBindingSource.DataMember = "SinhVien_SelectMaLop";
            this.SinhVien_SelectMaLopBindingSource.DataSource = this.dSSinhVien;
            // 
            // frmThongKeSinhVienTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 536);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmThongKeSinhVienTheoLop";
            this.Text = "Báo cáo thống kê sinh viên theo lớp";
            this.Load += new System.EventHandler(this.frmThongKeSinhVienTheoLop_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dSSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVien_SelectMaLopBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboLop;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dSSinhVienBindingSource;
        private DSSinhVien dSSinhVien;
        private System.Windows.Forms.BindingSource SinhVien_SelectMaLopBindingSource;
    }
}