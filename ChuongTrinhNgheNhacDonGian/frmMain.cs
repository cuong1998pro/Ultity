using System;
using System.Windows.Forms;

namespace ChuongTrinhNgheNhacDonGian
{
    public partial class frmMain : Form
    {
        private string[] fileNames, filePaths;

        public frmMain()
        {
            InitializeComponent();
        }

        private void lbBaiHat_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbBaiHat.SelectedIndex;
            player.URL = filePaths[index];
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNames = openFileDialog1.SafeFileNames;
                filePaths = openFileDialog1.FileNames;
                foreach (string fileName in fileNames)
                {
                    lbBaiHat.Items.Add(fileName);
                }
            }
        }
    }
}