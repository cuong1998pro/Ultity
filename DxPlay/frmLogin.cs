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
            //var host = txtHostAddress.Text;
            //var port = txtPort.Text;
            //var proxyPath = Properties.Resources.ProxyFile;
            //if (File.Exists(proxyPath))
            //{
            //    List<string> proxy = File.ReadLines(proxyPath).ToList();
            //    if (proxy.Count == 3)
            //    {
            //        var dateUpdate = DateTime.Parse(proxy[0]);
            //        if (DateTime.Now.Subtract(dateUpdate).Hours <= 5)
            //        {
            //            return;
            //        }
            //    }
            //}
            //StreamWriter sw = new StreamWriter(proxyPath, false);
            //sw.WriteLine(DateTime.Now);
            //sw.WriteLine(host);
            //sw.WriteLine(port);
            //sw.Close();
            //Functions.UseProxy(host, port);
            var result = Functions.GetData("https://google.com");
            MessageBox.Show(result);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            var proxyFile = Properties.Resources.ProxyFile;
            if (File.Exists(proxyFile))
            {
                List<string> proxy = File.ReadLines(proxyFile).ToList();
                if (proxy.Count == 3)
                {
                    var dateTime = DateTime.Parse(proxy[0].ToString());
                    if (DateTime.Now.Subtract(dateTime).Hours <= 5)
                    {
                        txtHostAddress.Text = proxy[1].ToString();
                        txtPort.Text = proxy[2].ToString();
                        btnUseCookie_Click(null, null);
                        return;
                    }
                }
            }
            Process.Start("http://www.freeproxylists.net/");
            this.WindowState = FormWindowState.Minimized;

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

        private void btnGetVideo_Click(object sender, EventArgs e)
        {
            //string url = Interaction.InputBox("Videos url:");
        }

        private async void btnHistory_Click(object sender, EventArgs e)
        {
            await GetHistory();
            MessageBox.Show("Download thanh cong");
        }

        private async Task GetHistory()
        {
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < 5; i++)
            {
                tasks.Add(GetVideosFromUrl(Properties.Resources.HistoryUrl, i));
            }
            await Task.WhenAll(tasks);
        }

        public async Task GetVideosFromUrl(string url, int index)
        {
            Action<object> action = (object obj) =>
            {
                dynamic temp = obj;

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
                    string title = Regex.Matches(htmlVideo.ToString(), titleRegex)[1].ToString();
                    Video video = new Video()
                    {
                        ImageURL = image,
                        DownloadLink = link,
                        Title = title
                    };
                    AddVideoToDatagrid(video);
                }
            };

            Task task = new Task(action, new { url = url, index = index });
            task.Start();
            await task;
        }

        private void AddVideoToDatagrid(Video video)
        {
            dgvVideo.Invoke(new Action(() =>
            {
                try
                {
                    var img = video.ImageURL;
                    System.Net.WebRequest request = System.Net.WebRequest.Create(img);
                    System.Net.WebResponse resp = request.GetResponse();
                    System.IO.Stream respStream = resp.GetResponseStream();
                    Bitmap bmp = new Bitmap(respStream);
                    respStream.Dispose();
                    imageList.Images.Add(bmp);
                    int index = dgvVideo.Rows.Add();
                    dgvVideo.Rows[index].Cells[0].Value = bmp;
                    dgvVideo.Rows[index].Cells[1].Value = video.Title;
                    dgvVideo.Rows[index].Cells[2].Value = Properties.Resources.HomeUrl + "/" + video.DownloadLink;
                }
                catch { }
            }));
        }
    }
}