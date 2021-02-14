using AE.Net.Mail;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using xNet;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace CrawData
{
    public static class Mail
    {
        public static void Verify(string email, string pass, string ipmap = "imap.gmail.com", int port = 993)
        {
            string url = string.Empty;
            using (ImapClient ic = new ImapClient())
            {
                ic.Connect(ipmap, port, true, false);
                ic.Login(email, pass);
                ic.SelectMailbox("INBOX");
                int mailcount = ic.GetMessageCount();
                MailMessage[] mails = ic.GetMessages(mailcount - 5, mailcount - 1, false, false);

                foreach (var mm in mails.Reverse())
                {
                    bool flag = mm.Subject.Contains("Xác nhận") || mm.Subject.Contains("xác nhận");
                    if (flag)
                    {
                        string sbody = mm.Body;
                        string regexString = "(?<=<a href=\").*?(?=\">)";
                        url = Regex.Match(sbody, regexString).ToString();
                        break;
                    }
                }

                ic.Dispose();
            }
            HttpRequest rq = new HttpRequest();
            rq.Cookies = new CookieDictionary();
            rq.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.92 Safari/537.36";

            if (url == string.Empty)
            {
                MessageBox.Show("Không tìm thấy email nào");
                return;
            }

            try
            {
                var result = rq.Get(url).ToString();
                WriteHtmlFile(result, "verify_mail.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private static void Delay(int time)
        {
            for (int i = 0; i < time; i++)
            {
                Thread.Sleep(time);
            }
        }

        private static void WriteHtmlFile(string content, string outputFilename)
        {
            StreamWriter sw = new StreamWriter(outputFilename);
            sw.Write(content);
            sw.Close();
            MessageBox.Show("craw thanh cong");
            Process.Start(outputFilename);
        }
    }
}