using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using xNet;

namespace CrawData
{
    public partial class Form1 : Form
    {
        public Form1()
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

            AddCookie(http, txtURL.Text.Trim(), cookie);

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

        private void AddCookie(HttpRequest http, string url, string cookie = null)
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
    }
}