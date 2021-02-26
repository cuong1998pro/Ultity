using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using xNet;

namespace DxPlay
{
    public static class Functions
    {
        public static HttpRequest http;
        public static List<Proxy> proxies;

        private const string regexString = "(?<=<td style=\"text-align:center\" class=\"left\">).*?(?=</tr>)";
        private const string regexHost = "(?<=Base64.decode\\(\").*?(?=\"\\)\\))";
        private const string regexPort = "(?<=<span class=\"fport\" style=''>).*?(?=</span></td>)";
        private const string regexSpeed = "(?<=<td> <small>).*?(?=kB/s</small>)";
        private const string regexResponse = "(?<=<div style=\"padding-left:5px\"><small>).*?(?= ms</small>)";
        private const string regexLastUpdate = @"(?<=;;""></div></div></div></td><td><small>).*?(?=ago</small>)";
        private const string regexUptime = @"(?<=;""></div></div></td><td><small>).*?(?=%</small>)";
        private const string regexProtocol = @"(?<=</span></td><td><small>).*?(?=</small></td><td class=""left""><div style=""padding-left:2px""><)";

        public static void Init()
        {
            try
            {
                http = new HttpRequest();
                http.Cookies = new CookieDictionary();
                InitProxy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void GetProxyInitHeader()
        {
            http.ClearAllHeaders();
            http.AddHeader("Accept", "*/*");
            http.AddField("Accept-Encoding", "gzip, deflate");
            http.AddHeader("Accept-Language", "en-US");
            http.AddField("Connection", "keep-alive");
            http.AddField("Host", "free-proxy.cz");
            http.AddHeader("Referer", "http://free-proxy.cz/en/");
            http.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:86.0) Gecko/20100101 Firefox/86.0");
            http.AddHeader("X-Moz", "prefetch");
        }

        public static void ResetHeader()
        {
            http.ClearAllHeaders();
            http.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:86.0) Gecko/20100101 Firefox/86.0");
        }

        public static void InitProxy()
        {
            GetProxyInitHeader();
            proxies = new List<Proxy>();

            for (int i = 1; i <= 1; i++)
            {
                GetProxy(i);

                //var tasks = new int[] { 1, 2 }
                //    .Select(data => Task.Factory.StartNew(arg => GetProxy(data), TaskContinuationOptions.LongRunning | TaskContinuationOptions.PreferFairness))
                //    .ToArray();

                //var timeout = TimeSpan.FromMinutes(1);
                //Task.WaitAll(tasks, timeout);
            }
        }

        private static void GetProxy(int i)
        {
            var url = "http://free-proxy.cz/en/proxylist/main/" + i;
            var html = GetData(url);
            var proxyArrayHtml = Regex.Matches(html, regexString, RegexOptions.Singleline);
            foreach (var item in proxyArrayHtml)
            {
                try
                {
                    string proxyHtml = item.ToString();
                    Proxy proxy = new Proxy();
                    string protocol = Regex.Match(proxyHtml, regexProtocol, RegexOptions.Singleline).ToString();
                    if (!protocol.Equals("HTTPS")) continue;
                    proxy.Protocol = protocol;
                    string host = Regex.Match(proxyHtml, regexHost, RegexOptions.Singleline).ToString();
                    if (string.IsNullOrEmpty(host)) continue;
                    proxy.HostIP = DecodeBase64(host);
                    proxy.Port = Regex.Match(proxyHtml, regexPort, RegexOptions.Singleline).ToString();
                    proxy.Speed = int.Parse(Regex.Match(proxyHtml, regexSpeed, RegexOptions.Singleline).ToString());
                    var response = Regex.Match(proxyHtml, regexResponse, RegexOptions.Singleline).ToString();
                    proxy.Response = int.Parse(response);
                    proxy.LastUpdate = Regex.Match(proxyHtml, regexLastUpdate, RegexOptions.Singleline).ToString();
                    var upTime = Regex.Match(proxyHtml, regexUptime, RegexOptions.Singleline).ToString();
                    proxy.Uptime = int.Parse(upTime);
                    proxies.Add(proxy);
                }
                catch (Exception ex)
                {
                    continue;
                }
            }
        }

        public static Proxy GetProxy()
        {
            if (proxies == null) return null;
            var proxy = proxies.FirstOrDefault();
            proxies.Remove(proxy);
            return proxy;
        }

        public static void UseProxy(string host, string port, string protocol)
        {
            http.Proxy = HttpProxyClient.Parse(host + ":" + port);
            ResetHeader();
            var html = GetData("https://google.com");
            if (string.IsNullOrEmpty(html)) return;
            WriteDataToHtml(html, "howkteam.html");
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
            try
            {
                var html = WebUtility.HtmlDecode(http.Get(url).ToString());
                return html;
            }
            catch (Exception ex)
            {
                MessageBox.Show(url + "\n" + ex.ToString(), "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        public static string PostData(string url, string data, string contentType)
        {
            try
            {
                var html = WebUtility.HtmlDecode(http.Post(url, data, contentType).ToString());
                return html;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        public static void WriteDataToHtml(string content, string outputFilename)
        {
            StreamWriter sw = new StreamWriter(outputFilename);
            sw.Write(content);
            sw.Close();
            Process.Start(outputFilename);
        }
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