using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress
{
    public partial class frmComboBoxImage : DevExpress.XtraEditors.XtraForm
    {
        public frmComboBoxImage()
        {
            InitializeComponent();
        }

        private void imageComboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cboText = cboGioiTinh.Text;
            var value = cboGioiTinh.EditValue;
            XtraMessageBox.Show(cboText + "\n" + value, "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}