using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using xNet;

namespace CrawData
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            HttpRequest http = new HttpRequest();
            string html = http.Get(txtURL.Text.Trim()).ToString();
            WriteHtmlFile(html, "craw.html");
        }

        private void btnGetDataCookie_Click(object sender, EventArgs e)
        {
            HttpRequest http = new HttpRequest();
            string cookie = txtCookie.Text;

            AddCookie(http, cookie);

            string html = http.Get(txtURL.Text.Trim()).ToString();
            WriteHtmlFile(html, "craw.html");
        }

        private void WriteHtmlFile(string content, string outputFilename)
        {
            StreamWriter sw = new StreamWriter(outputFilename);
            sw.Write(content);
            sw.Close();
            MessageBox.Show("craw thanh cong");
            Process.Start(outputFilename);
        }

        private void AddCookie(HttpRequest http, string cookie = null)
        {
            http.Cookies = http.Cookies = new CookieDictionary();
            var temp = cookie.Split(';');
            foreach (var item in temp)
            {
                var temp2 = item.Split('=');
                if (temp2.Count() > 1)
                {
                    var field = temp2[0];
                    var value = temp2[1];
                    http.Cookies.Add(field, value);
                }
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            HttpRequest http = new HttpRequest();
            http.Cookies = new CookieDictionary();

            string loginUrl = "https://www.howkteam.vn/account/login?ReturnUrl=%2F";
            var html = http.Get(loginUrl).ToString();

            var regexString = @"(?<=__RequestVerificationToken"" type=""hidden"" value="").*?(?="")";
            var result = Regex.Match(html, regexString, RegexOptions.Singleline);

            var token = result.ToString();

            var username = WebUtility.UrlEncode(txtTendangnhap.Text.Trim());
            var password = WebUtility.UrlEncode(txtPassword.Text);

            string data = "__RequestVerificationToken=" + token + "&Email=" + username + "&Password=" + password + "&RememberMe=true&RememberMe=false";
            string contentType = "application/x-www-form-urlencoded";
            var loginPostUrl = "https://www.howkteam.vn/account/login?returnUrl=https%3A%2F%2Fwww.howkteam.vn%2F";

            http.Post(loginPostUrl, data, contentType).ToString();
            string response = http.Get("https://www.howkteam.vn").ToString();
            WriteHtmlFile(response, "login.html");
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtChonFile.Text = openFileDialog.FileName;
                btnUpload.Enabled = true;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            var filename = txtChonFile.Text;
            HttpRequest http = new HttpRequest();
            http.Cookies = new CookieDictionary();

            var url = @"https://aa.secufiles.com/core/page/ajax/file_upload_handler.ajax.php?r=secufiles.com&p=https&csaKey1=88ff052a06d770d9391c7a2efa5973cedb1fb2c8f7a76d6821f901adf91dcd69&csaKey2=d33b560361e8054272c18c86bbedf9cbaa550b818fd6e0f663e034c50100e7e9";
            MultipartContent data = new MultipartContent() {
                { new StringContent("_sessionid"), "c2k3rgmgf64vdo9bd8pk1mvpun"},
                { new StringContent("cTracker"), "2acfdf91782308a6475f68709682ce28"},
                { new FileContent(filename), "files[]", Path.GetFileName(filename), "application/octet-stream" }
            };

            var html = http.Post(url, data).ToString();
            var root = JsonConvert.DeserializeObject<List<Class1>>(html);
            var result = root[0];
            txtKetQua.Text = result.url;
            MessageBox.Show("upload thanh cong");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Tất cả tập tin|*.*|Ảnh png |*.png";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            HttpRequest http = new HttpRequest();
            http.Cookies = new CookieDictionary();
            http.AddHeader("Accept", "*/*");
            http.AddHeader("Cache-Control", "max-age=0");
            http.AddField("Host", "header.vtcgame.vn");
            http.AddField("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            http.AddHeader("Origin", "https://vtcgame.vn");
            http.AddHeader("Referer", "https://vtcgame.vn/");
            http.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:86.0) Gecko/20100101 Firefox/86.0");

            string cookie = "ASP.NET_SessionId=dvjygvepazikr0byvqzu1umk; _ga=GA1.2.292676208.1613259212; _gid=GA1.2.366696503.1613259212; _fbp=fb.1.1613259212577.1418830481";
            AddCookie(http, cookie);

            var username = EncodeBase64(txtTendangnhap.Text + "1");
            var password = EncodeBase64(txtPassword.Text);

            var getTokenUrl = "https://header.vtcgame.vn/home/commonv2";
            var stringRegex = @"(?<=key"" type=""hidden"" value="").*?(?="")";

            var token = GetToken(http, getTokenUrl, stringRegex);

            var imageByteArray = http.Get("https://header.vtcgame.vn//CaptchaImage.ashx?ss=0.18794111666105817&w=60&h=40").ToMemoryStream().ToArray();
            frmEnterCapcha frm = new frmEnterCapcha(imageByteArray);
            frm.ShowDialog();
            string captcha = frm.Captcha;

            http.AddHeader("Referer", "https://vtcgame.vn/GameServer/GameDetail?GameId=98");
            var contentType = "application/x-www-form-urlencoded; charset=UTF-8";
            var registerUrl = "https://header.vtcgame.vn//Handler/Process.ashx?act=Register";

            var data = $@"conten={username}&value={password}&value2={password}&capt={captcha}&hidverify=&dongy=true&key={token}&ServiceId=&LinkGen=";
            var result = http.Post(registerUrl, data, contentType).ToString();
            WriteHtmlFile(result, "resultregister.html");
        }

        private string GetToken(HttpRequest http, string url, string regex)
        {
            var html = http.Get(url).ToString();
            string token = Regex.Match(html, regex).ToString();
            return token;
        }

        private string EncodeBase64(string input)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
        }

        private string DecodeBase64(string input)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(input));
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            var email = txtTendangnhap.Text;
            var password = txtPassword.Text;

            Mail.Verify(email, password);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            HttpRequest http = new HttpRequest();
            http.ConnectTimeout = int.MaxValue;
            http.KeepAliveTimeout = int.MaxValue;
            http.ReadWriteTimeout = int.MaxValue;

            var url = txtDownloadLink.Text;
            var byteArray = http.Get(url).ToMemoryStream().ToArray();

            var fileName = saveFileDialog1.FileName;

            File.WriteAllBytes(fileName, byteArray);
            MessageBox.Show("Download thanh cong");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var hostname = txtHostname.Text;
            var port = int.Parse(txtPort.Text);

            HttpRequest http = new HttpRequest();
            http.Proxy = HttpProxyClient.Parse(hostname + ":" + port);
            var html = http.Get("https://whoer.net").ToString();
            WriteHtmlFile(html, "ip.html");
        }

        private void btnGetDataThread_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                int val = i;
                Thread t = new Thread(() =>
                {
                    GetData(val);
                });
                t.Start();
            }
        }

        private void GetData(int i)
        {
            var url = "http://google.com";
            HttpRequest http = new HttpRequest();
            var htmlGoogle = http.Get(url).ToString();
            WriteHtmlFile(htmlGoogle, "google_" + i.ToString() + ".html");
        }
    }
}