using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaHoaMD5
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGetMD5_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = GetMD5(txtChuoiNguon.Text);
        }

        public string GetMD5(string text)
        {
            string result = string.Empty;
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(text);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (byte b in buffer)
            {
                result += b.ToString("X2");
            }
            return result;
        }
    }
}