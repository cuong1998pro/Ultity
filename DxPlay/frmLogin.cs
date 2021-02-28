using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
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

        private async void btnTestConnection_Click(object sender, EventArgs e)
        {
            var host = txtHostAddress.Text;
            var port = txtPort.Text;
            var proxyPath = Properties.Resources.ProxyFile;
            if (File.Exists(proxyPath))
            {
                List<string> proxy = File.ReadLines(proxyPath).ToList();
                if (proxy.Count == 3)
                {
                    var dateUpdate = DateTime.Parse(proxy[0]);
                    if (DateTime.Now.Subtract(dateUpdate).Hours <= 5)
                    {
                        return;
                    }
                }
            }
            StreamWriter sw = new StreamWriter(proxyPath, false);
            sw.WriteLine(DateTime.Now);
            sw.WriteLine(host);
            sw.WriteLine(port);
            sw.Close();
            Functions.UseProxy(host, port);
            var result = Functions.GetData("https://google.com");
            MessageBox.Show(result);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //var proxyFile = Properties.Resources.ProxyFile;
            //if (File.Exists(proxyFile))
            //{
            //    List<string> proxy = File.ReadLines(proxyFile).ToList();
            //    if (proxy.Count == 3)
            //    {
            //        var dateTime = DateTime.Parse(proxy[0].ToString());
            //        if (DateTime.Now.Subtract(dateTime).Hours <= 5)
            //        {
            //            txtHostAddress.Text = proxy[1].ToString();
            //            txtPort.Text = proxy[2].ToString();
            //            btnUseCookie_Click(null, null);
            //            return;
            //        }
            //    }
            //}
            //Process.Start("http://www.freeproxylists.net/");
            //this.WindowState = FormWindowState.Minimized;

            btnUseCookie_Click(null, null);
        }

        private void btnUseCookie_Click(object sender, EventArgs e)
        {
            var cookieFilePath = Properties.Resources.CookieFile;
            string cookie = string.Empty;
            if (File.Exists(cookieFilePath))
            {
                if (File.GetLastWriteTime(cookieFilePath).Subtract(DateTime.Now).Days < 3)
                {
                    cookie = File.ReadAllText(cookieFilePath);
                    Functions.UseCookie(cookie);
                    MessageBox.Show("Dung cookie thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            Process.Start(Properties.Resources.HomeUrl);
            this.WindowState = FormWindowState.Minimized;
            cookie = Interaction.InputBox("Nhập cookie");
            File.WriteAllText(cookieFilePath, cookie);
            Functions.UseCookie(cookie);
            MessageBox.Show("Dung cookie thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            WindowState = FormWindowState.Normal;
        }

        private async void btnGetVideo_Click(object sender, EventArgs e)
        {
          var task =  GetVideoURL(Functions.playlist, Properties.Resources.PlaylistUrl);
            MessageBox.Show("Lam gi sau");
        }

        private async void btnHistory_Click(object sender, EventArgs e)
        {
           var task = GetVideoURL(Functions.history, Properties.Resources.HistoryUrl);
          
        }

        private async Task GetVideoURL(List<Video> videos, string url)
        {
            int count = Functions.GetPageCount(url);
            progressBar1.Maximum = count;
            List<Task> totalTask = new List<Task>();
            for (int i = 0; i < count; i += 10)
            {
                List<Task> tasks = new List<Task>();
                for (int j = i; j < i + 10; j++)
                {
                    if (j >= count) break;
                    var task = GetVideosFromUrl(videos, url, j);
                    tasks.Add(task);
                    totalTask.Add(task);
                }
                await Task.WhenAll(tasks);
            }
            await Task.WhenAll(totalTask);
            MessageBox.Show("Lay DL thanh cong. " + dgvVideo.Rows.Count + " ban ghi");
        }

        public async Task GetVideosFromUrl(List<Video> videos, string url, int index)
        {
            Action<object> action = (object obj) =>
            {
                dynamic temp = obj;
                //MessageBox.Show(temp.url + temp.index);
                string html = Functions.GetData(temp.url + temp.index);

                string videoHtmlRegex = @"(?<=<div id=""video_).*?(?=</script>)";
                string imageRegex = @"(?<=""><img src=""https://static-l3.xvideos-cdn.com/img/lightbox/lightbox-blank.gif"" data-src="").*?(?="" data-idcdn)";
                string linkRegex = @"(?<=""><div class=""thumb-inside""><div class=""thumb""><a href=""/).*?(?=""><img)";
                string titleRegex = @"(?<="" title="").*?(?="")";

                var htmlVideos = Regex.Matches(html, videoHtmlRegex);

                foreach (var htmlVideo in htmlVideos)
                {
                    string image = Regex.Match(htmlVideo.ToString(), imageRegex).ToString();
                    string link = Regex.Match(htmlVideo.ToString(), linkRegex).ToString();
                    var matches = Regex.Matches(htmlVideo.ToString(), titleRegex);
                    string title = matches[matches.Count - 1].ToString();

                    System.Net.WebRequest request = System.Net.WebRequest.Create(image);
                    System.Net.WebResponse resp = request.GetResponse();
                    System.IO.Stream respStream = resp.GetResponseStream();
                    Bitmap bmp = new Bitmap(respStream);
                    respStream.Dispose();
                    Video video = new Video()
                    {
                        Image = bmp,
                        Download = link,
                        Title = title,
                        PageIndex = temp.index + ""
                    };
                    videos.Add(video);
                }
            };

            Task task = new Task(action, new { url = url, index = index });
            task.Start();
            await task;
            AddVideoToDatagrid(videos);
            progressBar1.Value += 1;
        }

        private void AddVideoToDatagrid(List<Video> videos)
        {
            dgvVideo.Invoke(new Action(() =>
            {
                try
                {
                    dgvVideo.DataSource = videos;
                }
                catch { }
            }));
        }

      
    }
}