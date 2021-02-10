
namespace QuanLyBanHang_Winform_Basic
{
    partial class frmNhapXuatTon
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSHoaDon = new QuanLyBanHang_Winform_Basic.DSHoaDon();
            this.V_NhapXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.V_NhapXuatTableAdapter = new QuanLyBanHang_Winform_Basic.DSHoaDonTableAdapters.V_NhapXuatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_NhapXuatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSBaoCaoTon";
            reportDataSource1.Value = this.V_NhapXuatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanHang_Winform_Basic.rptBaoCaoTon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(994, 568);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSHoaDon
            // 
            this.DSHoaDon.DataSetName = "DSHoaDon";
            this.DSHoaDon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // V_NhapXuatBindingSource
            // 
            this.V_NhapXuatBindingSource.DataMember = "V_NhapXuat";
            this.V_NhapXuatBindingSource.DataSource = this.DSHoaDon;
            // 
            // V_NhapXuatTableAdapter
            // 
            this.V_NhapXuatTableAdapter.ClearBeforeFill = true;
            // 
            // frmNhapXuatTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 568);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmNhapXuatTon";
            this.Text = "Báo cáo nhập xuất";
            this.Load += new System.EventHandler(this.frmInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_NhapXuatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource V_NhapXuatBindingSource;
        private DSHoaDon DSHoaDon;
        private DSHoaDonTableAdapters.V_NhapXuatTableAdapter V_NhapXuatTableAdapter;
    }
}