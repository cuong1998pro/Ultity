using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawData
{
    public partial class frmEnterCapcha : Form
    {
        public frmEnterCapcha(byte[] image)
        {
            InitializeComponent();
            var ms = new MemoryStream(image);
            pictureBox1.Image = Image.FromStream(ms);
            Captcha = "";
        }

        public string Captcha { get; set; }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Captcha = txtCapcha.Text;
            this.Close();
        }
    }
}