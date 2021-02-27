using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;

namespace DxPlay
{
    public static class Functions
    {
        public static HttpRequest http;

        public static void Init()
        {
            try
            {
                http = new HttpRequest();
                http.Cookies = new CookieDictionary();
                MainInitHeader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UseCookie(string cookie)
        {
            http.Cookies = new CookieDictionary();
            var items = cookie.Split(';');
            foreach (var item in items)
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

        public static void MainInitHeader()
        {
            http.ClearAllHeaders();
            http.AddHeader("Accept", "*/*");
            http.AddField("Accept-Encoding", "gzip, deflate");
            http.AddHeader("Accept-Language", "en-US");
            http.AddField("Connection", "keep-alive");
            http.AddField("Host", Properties.Resources.Host);
            http.AddHeader("Referer", Properties.Resources.Referer);
            http.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:86.0) Gecko/20100101 Firefox/86.0");
            http.AddHeader("Upgrade-Insecure-Requests", "1");
        }

        public static void ResetHeader()
        {
            http.ClearAllHeaders();
            http.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:86.0) Gecko/20100101 Firefox/86.0");
        }

        public static async Task<List<Video>> GetVideosFromUrl(string url, int index)
        {
            Func<object, List<Video>> func = (object obj) =>
            {
                dynamic temp = obj;
                MessageBox.Show(temp.url + temp.index);

                List<Video> videos = new List<Video>();
                string html = GetData(temp.url + temp.index);

                string videoHtmlRegex = @"(?<=<div id=""video_).*?(?=</script>)";
                string imageRegex = @"(?<=""><img src=""https://static-l3.xvideos-cdn.com/img/lightbox/lightbox-blank.gif"" data-src="").*?(?="" data-idcdn)";
                string linkRegex = @"(?<=""><div class=""thumb-inside""><div class=""thumb""><a href=""/).*?(?=""><img)";
                string titleRegex = @"(?<="" title="").*?(?="")";

                var htmlVideos = Regex.Matches(html, videoHtmlRegex);

                foreach (var htmlVideo in htmlVideos)
                {
                    string image = Regex.Match(htmlVideo.ToString(), imageRegex).ToString();
                    string link = Regex.Match(htmlVideo.ToString(), linkRegex).ToString();
                    string title = Regex.Matches(htmlVideo.ToString(), titleRegex)[1].ToString();
                    Video video = new Video()
                    {
                        ImageURL = image,
                        DownloadLink = link,
                        Title = title
                    };
                    videos.Add(video);
                }
                return videos;
            };

            Task<List<Video>> task = new Task<List<Video>>(func, new { url = url, index = index });
            task.Start();
            await task;

            var result = task.Result;
            //Them video to datagrid view
            return result;
        }

       

        public static int GetVideoCount(string html)
        {
            var regex = @"(?<=class=""last-page"">).*?(?=</a></li><li><a href=""#1"" class=""no-page next-page"">)";
            string number = Regex.Match(html, regex).ToString();
            return int.Parse(number);
        }

        public static int GetHistoryCount()
        {
            var url = Properties.Resources.HistoryUrl + "0";
            var html = GetData(url);
            return GetVideoCount(html);
        }

        public static void UseProxy(string host, string port)
        {
            http.Proxy = HttpProxyClient.Parse(host + ":" + port);
            ResetHeader();
            var html = GetData(Properties.Resources.HomeUrl);
            if (string.IsNullOrEmpty(html)) return;
            MessageBox.Show("Ket noi thanh cong");
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
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public string DownloadLink { get; set; }
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