using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_Winform_Basic
{
    public partial class frmNhapXuatTon : Form
    {
        public frmNhapXuatTon()
        {
            InitializeComponent();
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSHoaDon.V_NhapXuat' table. You can move, or remove it, as needed.
            this.V_NhapXuatTableAdapter.Fill(this.DSHoaDon.V_NhapXuat);
            this.reportViewer1.RefreshReport();
        }
    }
}