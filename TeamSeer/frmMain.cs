using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamSeer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMoNotePad_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
            //var fileName = AppDomain.CurrentDomain.BaseDirectory + "readme.md";
            //Process.Start(fileName);
        }

        private void btnCmd_Click(object sender, EventArgs e)
        {
            //var cmd = "/C \"" + txtCommand.Text + "\"";
            //p.StartInfo.Arguments = cmd;
            //p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //p.Kill();

            var command = txtCommand.Text;

            Process p = new Process();
            p.StartInfo.FileName = "CMD.exe";

            p.StartInfo.CreateNoWindow = true;

            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();
            p.StandardInput.WriteLine(command);
            p.StandardInput.Flush();
            p.StandardInput.Close();
            p.WaitForExit();

            var result = p.StandardOutput.ReadToEnd();
            MessageBox.Show(result);
        }
    }
}