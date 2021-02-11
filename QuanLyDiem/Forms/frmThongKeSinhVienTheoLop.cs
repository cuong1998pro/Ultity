using QuanLyDiem.DSSinhVienTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem.Forms
{
    public partial class frmThongKeSinhVienTheoLop : Form
    {
        public frmThongKeSinhVienTheoLop()
        {
            InitializeComponent();
        }

        private QuanLyDiemDataContext dt = new QuanLyDiemDataContext();

        private void frmThongKeSinhVienTheoLop_Load(object sender, EventArgs e)
        {
            cboLop.DataSource = dt.Lop_SelectAll();
            cboLop.DisplayMember = "MaLop";
            cboLop.ValueMember = "MaLop";
        }

        private void LoadReport()
        {
            SinhVien_SelectMaLopTableAdapter da = new SinhVien_SelectMaLopTableAdapter();
            da.Fill(dSSinhVien.SinhVien_SelectMaLop, cboLop.Text);
            this.reportViewer1.RefreshReport();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReport();
        }
    }
}