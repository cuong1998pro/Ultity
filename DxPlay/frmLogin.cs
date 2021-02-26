using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DxPlay
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Functions.Init();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnRenew_Click(null, null);
            txtPassword.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            var proxy = Functions.GetProxy();
            if (proxy == null)
            {
                MessageBox.Show("Het proxy");
                return;
            }
            try
            {
                txtHostAddress.Text = proxy.HostIP.Trim();
                txtPort.Text = proxy.Port.Trim();
                cboProtocol.Text = proxy.Protocol.Trim();
                txtSpeed.Text = proxy.Speed.ToString("N0") + " kb/s";
                txtResponse.Text = proxy.Response.ToString("N0") + " ms";
                pgUptime.Value = proxy.Uptime;
                txtLastCheck.Text = proxy.LastUpdate + "ago";
            }
            catch (System.NullReferenceException ex)
            {
                btnRenew_Click(null, null);
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            var host = txtHostAddress.Text;
            var port = txtPort.Text;
            var protocol = cboProtocol.Text;
            Functions.UseProxy(host, port, protocol);
        }
    }
}