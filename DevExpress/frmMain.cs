using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //loading data

            Thread.Sleep(100);
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Processing data...");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
            }
            SplashScreenManager.CloseForm();
        }
    }
}