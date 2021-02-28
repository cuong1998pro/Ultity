using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DxPlay
{
    public static class Functions
    {
        public static HttpClient http;
        public static WebProxy proxy;

        public static List<Video> history = new List<Video>();
        public static List<Video> playlist = new List<Video>();
        public static List<Video> blocked = new List<Video>();
        public static List<Video> downloadList = new List<Video>();
        public static List<Video> downloaded = new List<Video>();

        public static void Init()
        {
            try
            {
                var handler = new HttpClientHandler();
                handler.UseCookies = false;
                handler.ClientCertificateOptions = ClientCertificateOption.Automatic;
                handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                handler.AllowAutoRedirect = true;
                handler.UseDefaultCredentials = false;
                http = new HttpClient(handler);
                http.BaseAddress = new Uri(Properties.Resources.HomeUrl);
                MainInitHeader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UseCookie(string cookieString)
        {
            http.DefaultRequestHeaders.Add("Cookie", cookieString);
        }

        public static void MainInitHeader()
        {
            http.DefaultRequestHeaders.Clear();
            http.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "*/*");
            http.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate");
            http.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "en-US");
            http.DefaultRequestHeaders.TryAddWithoutValidation("Connection", "keep-alive");
            http.DefaultRequestHeaders.TryAddWithoutValidation("Host", Properties.Resources.Host);
            http.DefaultRequestHeaders.TryAddWithoutValidation("Referer", Properties.Resources.Referer);
            http.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:86.0) Gecko/20100101 Firefox/86.0");
            http.DefaultRequestHeaders.TryAddWithoutValidation("Upgrade-Insecure-Requests", "1");
        }

        public static void ResetHeader()
        {
            http.DefaultRequestHeaders.Clear();
            http.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:86.0) Gecko/20100101 Firefox/86.0");
        }

       
        public static int GetPageCount(string url)
        {
            var html = GetData(url+0);
            var regex = @"(?<=last-page"">).*?(?=</a></li>)";
            string number = Regex.Match(html, regex).ToString();
            return int.Parse(number);
        }

        public static void UseProxy(string host, string port)
        {
            proxy = new WebProxy(string.Format("{0}:{1}", host, port), false);
            MessageBox.Show("dung proxy thanh cong");
        }

        private static string EncodeBase64(string input)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
        }

        private static string DecodeBase64(string input)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(input));
        }

        public static string GetData(string url)
        {
            var result = WebUtility.HtmlDecode(http.GetStringAsync(url).Result);
            return result;
        }

        public static void WriteDataToHtml(string content, string outputFilename)
        {
            StreamWriter sw = new StreamWriter(outputFilename);
            sw.Write(content);
            sw.Close();
            Process.Start(outputFilename);
        }

        #region old code

        //public static void ProxyInitHeader()
        //{
        //    http.ClearAllHeaders();
        //    http.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,*/*;q=0.8");
        //    http.AddField("Accept-Encoding", "gzip, deflate");
        //    http.AddHeader("Accept-Language", "en-US");
        //    http.AddField("Connection", "keep-alive");
        //    http.AddField("Host", "www.freeproxylists.net");
        //    http.AddHeader("Referer", "http://www.freeproxylists.net/");
        //    http.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:86.0) Gecko/20100101 Firefox/86.0");
        //    http.AddHeader("Upgrade-Insecure-Requests", "1");
        //}
        //private const string regexString = "(?<=<td style=\"text-align:center\" class=\"left\">).*?(?=</tr>)";
        //private const string regexHost = "(?<=Base64.decode\\(\").*?(?=\"\\)\\))";
        //private const string regexPort = "(?<=<span class=\"fport\" style=''>).*?(?=</span></td>)";
        //private const string regexSpeed = "(?<=<td> <small>).*?(?=kB/s</small>)";
        //private const string regexResponse = "(?<=<div style=\"padding-left:5px\"><small>).*?(?= ms</small>)";
        //private const string regexLastUpdate = @"(?<=;;""></div></div></div></td><td><small>).*?(?=ago</small>)";
        //private const string regexUptime = @"(?<=;""></div></div></td><td><small>).*?(?=%</small>)";
        //private const string regexProtocol = @"(?<=</span></td><td><small>).*?(?=</small></td><td class=""left""><div style=""padding-left:2px""><)";

        //public static void InitProxy()
        //{
        //    ProxyInitHeader();
        //    proxies = new List<Proxy>();

        //    for (int i = 1; i <= 1; i++)
        //    {
        //        GetProxy(i);

        //        //var tasks = new int[] { 1, 2 }
        //        //    .Select(data => Task.Factory.StartNew(arg => GetProxy(data), TaskContinuationOptions.LongRunning | TaskContinuationOptions.PreferFairness))
        //        //    .ToArray();

        //        //var timeout = TimeSpan.FromMinutes(1);
        //        //Task.WaitAll(tasks, timeout);
        //    }
        //}

        //private static void GetProxy(int i)
        //{
        //    var url = "http://www.freeproxylists.net/?page=" + i;
        //    var html = GetData(url);
        //    var proxyArrayHtml = Regex.Matches(html, regexString, RegexOptions.Singleline);
        //    foreach (var item in proxyArrayHtml)
        //    {
        //        try
        //        {
        //            string proxyHtml = item.ToString();
        //            Proxy proxy = new Proxy();
        //            string protocol = Regex.Match(proxyHtml, regexProtocol, RegexOptions.Singleline).ToString();
        //            if (!protocol.Equals("HTTPS")) continue;
        //            proxy.Protocol = protocol;
        //            string host = Regex.Match(proxyHtml, regexHost, RegexOptions.Singleline).ToString();
        //            if (string.IsNullOrEmpty(host)) continue;
        //            proxy.HostIP = DecodeBase64(host);
        //            proxy.Port = Regex.Match(proxyHtml, regexPort, RegexOptions.Singleline).ToString();
        //            proxy.Speed = int.Parse(Regex.Match(proxyHtml, regexSpeed, RegexOptions.Singleline).ToString());
        //            var response = Regex.Match(proxyHtml, regexResponse, RegexOptions.Singleline).ToString();
        //            proxy.Response = int.Parse(response);
        //            proxy.LastUpdate = Regex.Match(proxyHtml, regexLastUpdate, RegexOptions.Singleline).ToString();
        //            var upTime = Regex.Match(proxyHtml, regexUptime, RegexOptions.Singleline).ToString();
        //            proxy.Uptime = int.Parse(upTime);
        //            proxies.Add(proxy);
        //        }
        //        catch (Exception ex)
        //        {
        //            continue;
        //        }
        //    }
        //}

        //public static Proxy GetProxy()
        //{
        //    if (proxies == null) return null;
        //    var proxy = proxies.FirstOrDefault();
        //    proxies.Remove(proxy);
        //    return proxy;
        //}

        #endregion old code
    }

    public class Video
    {
        public Bitmap Image { get; set; }
        public string Title { get; set; }
        public string Download { get; set; }
        public string PageIndex { get; set; }
    }

    public class Proxy
    {
        public string HostIP { get; set; }
        public string Port { get; set; }
        public int Speed { get; set; }
        public string LastUpdate { get; set; }
        public int Response { get; set; }
        public int Uptime { get; set; }
        public string Protocol { get; set; }
    }
}