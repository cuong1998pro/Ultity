using DevExpress.Skins;
using DevExpress.XtraBars.Helpers;
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
    public partial class frmSkin : DevExpress.XtraEditors.XtraForm
    {
        public frmSkin()
        {
            InitializeComponent();
        }

        private void frmSkin_Load(object sender, EventArgs e)
        {
            SkinHelper.InitSkinPopupMenu(SkinLink);
            foreach (SkinContainer skin in SkinManager.Default.Skins)
            {
                cboSkinSelect.Properties.Items.Add(skin.SkinName);
            }
        }

        private void cboSkinSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var skinName = cboSkinSelect.Text;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinName);
        }
    }
}