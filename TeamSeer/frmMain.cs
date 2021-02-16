using KAutoHelper;
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

        private void btnClick_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);
            //var hWnd = Process.GetProcessesByName("Remote Desktop Connection")[0].MainWindowHandle;
            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle(null, txtWindowName.Text);

            //lay toa do tren man hinh cua toa doa ben trong cua so
            var pointToClick = AutoControl.GetGlobalPoint(hWnd, x, y);

            EMouseKey mouseKey = GetMouseKey();

            AutoControl.BringToFront(hWnd);
            AutoControl.MouseClick(pointToClick, mouseKey);
        }

        private void btnClickVaoControl_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = AutoControl.FindWindowHandle(null, txtWindowName.Text);
            AutoControl.BringToFront(hWnd);

            IntPtr childHandler = AutoControl.FindHandle(hWnd, txtControlClassName.Text, txtControlClassName.Text); //same FindWindowExFromParent

            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);

            EMouseKey mouseKey = GetMouseKey();

            var point = AutoControl.GetGlobalPoint(childHandler, x, y);

            AutoControl.MouseClick(point, mouseKey);
        }

        private EMouseKey GetMouseKey()
        {
            if (chkMouseLeft.Checked)
            {
                return EMouseKey.LEFT;
            }
            else if (chkMouseRight.Checked)
            {
                return EMouseKey.RIGHT;
            }
            else if (chkDoubleClick.Checked)
            {
                return EMouseKey.DOUBLE_LEFT;
            }
            else
            {
                return EMouseKey.LEFT;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = AutoControl.FindWindowHandle(null, txtWindowName.Text);
            AutoControl.BringToFront(hWnd);

            AutoControl.SendKeyFocus(KeyCode.ENTER);
        }

        private void btnSendMultikey_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = AutoControl.FindWindowHandle(null, txtWindowName.Text);
            AutoControl.BringToFront(hWnd);

            AutoControl.SendMultiKeysFocus(new KeyCode[] { KeyCode.CONTROL, KeyCode.KEY_V });
        }

        private void btnSetText_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = AutoControl.FindWindowHandle(null, txtWindowName.Text);
            AutoControl.BringToFront(hWnd);

            IntPtr child = AutoControl.FindHandle(hWnd, txtControlClassName.Text, txtControlClassName.Text);
            //***********************
            AutoControl.SendText(hWnd, txtTextSend.Text);
            AutoControl.SendText(child, txtTextSend.Text);
        }

        private void btnSendClickOnControl_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = AutoControl.FindWindowHandle(null, txtWindowName.Text);
            AutoControl.BringToFront(hWnd);

            IntPtr child = AutoControl.FindHandle(hWnd, txtControlClassName.Text, txtControlClassName.Text);

            //******************************************
            AutoControl.SendClickOnControlByHandle(child);
        }

        private void btnClickToaDo_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = AutoControl.FindWindowHandle(null, txtWindowName.Text);
            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);

            var child = AutoControl.FindHandle(hWnd, txtControlClassName.Text, txtControlClassName.Text);
            //khong the click vao cua so
            //khong phai ung dung nao cung click duoc
            //******************************************
            AutoControl.SendClickDownOnPosition(child, x, y);
        }

        private void btnSendKeyNgam_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = AutoControl.FindWindowHandle(null, txtWindowName.Text);
            //***********************************
            AutoControl.SendKeyBoardPress(hWnd, VKeys.VK_RETURN);
        }

        private void btnFindImage_Click(object sender, EventArgs e)
        {
            var screen = CaptureHelper.CaptureScreen();

            //screen = CaptureHelper.CropImage(screen, new Rectangle(184, 207, 50, 100));
            //screen.Save("Capture.png");
            //int x = find(x) + 184;

            var template = ImageScanOpenCV.GetImage("template.PNG");
            var result = ImageScanOpenCV.FindOutPoint((Bitmap)screen, template);

            if (result == null)
            {
                MessageBox.Show("Khong tim thay");
                return;
            }
            MessageBox.Show(result.ToString());
        }
    }
}