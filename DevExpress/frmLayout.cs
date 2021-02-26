using System;
using System.IO;
using System.Windows.Forms;

namespace DevExpress
{
    public partial class frmLayout : DevExpress.XtraEditors.XtraForm
    {
        public frmLayout()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string fileName = string.Format("{0}/{1}.xml", Application.StartupPath, this.Name);
            if (File.Exists(fileName))
            {
                layoutControl1.RestoreLayoutFromXml(fileName);
            }
        }

        private void btnSaveLayout_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = string.Format("{0}/{1}.xml", Application.StartupPath, this.Name);
                layoutControl1.SaveLayoutToXml(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}