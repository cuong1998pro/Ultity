using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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

        private string downloadFolder = File.ReadAllText("download_folder.txt");

        private void btnTestConnection_Click(object sender, EventArgs e)
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
            dgvVideo.AutoGenerateColumns = false;
            if (File.Exists("download.txt"))
            {
                Functions.downloaded = File.ReadAllText("download.txt");
            }
            else
            {
                Functions.downloaded = string.Empty;
            }
            if (!Directory.Exists(downloadFolder))
            {
                Directory.CreateDirectory(downloadFolder);
            }
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
            var task = GetVideoURL(Functions.playlist, Properties.Resources.PlaylistUrl);
            await task;
            //MessageBox.Show("Lam sau");
        }

        private async void btnHistory_Click(object sender, EventArgs e)
        {
            var task = GetVideoURL(Functions.history, Properties.Resources.HistoryUrl);
            await task;
        }

        private async Task GetVideoURL(List<Video> videos, string url)
        {
            int count = Functions.GetPageCount(url);
            dgvVideo.DataSource = null;
            videos = new List<Video>();
            progressBar1.Maximum = count;
            progressBar1.Value = 0;
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
            MessageBox.Show("Lay DL thanh cong. " + videos.Count + " ban ghi");

            AddVideoToDatagrid(videos);
        }

        public async Task GetVideosFromUrl(List<Video> videos, string url, int index)
        {
            Action<object> action = (object obj) =>
            {
                dynamic temp = obj;
                string html = Functions.GetData(temp.url + temp.index);

                string videoHtmlRegex = @"(?<=<div id=""video).*?(?=</script>)";
                string imageRegex = @"(?<=""><img src=""https://static-l3.xvideos-cdn.com/img/lightbox/lightbox-blank.gif"" data-src="").*?(?="" data-idcdn)";
                string linkRegex = @"(?<=""><div class=""thumb-inside""><div class=""thumb""><a href=""/).*?(?=""><img)";
                string titleRegex = @"(?<="" title="").*?(?="")";

                var htmlVideos = Regex.Matches(html, videoHtmlRegex, RegexOptions.Singleline);
                foreach (var htmlVideo in htmlVideos)
                {
                    string image = Regex.Match(htmlVideo.ToString(), imageRegex, RegexOptions.Singleline).ToString();
                    string link = Regex.Match(htmlVideo.ToString(), linkRegex, RegexOptions.Singleline).ToString();
                    var matches = Regex.Matches(htmlVideo.ToString(), titleRegex, RegexOptions.Singleline);
                    string title = matches[matches.Count - 1].ToString();
                    var videoUrl = link;
                    string videoID = videoUrl.Substring(5, videoUrl.IndexOf("/") - 5);
                    Bitmap bmp;
                    try
                    {
                        WebRequest request = WebRequest.Create(image);
                        WebResponse resp = request.GetResponse();
                        Stream respStream = resp.GetResponseStream();
                        bmp = new Bitmap(respStream);
                        respStream.Dispose();
                    }
                    catch
                    {
                        bmp = new Bitmap("index.jpg");
                    }

                    Video video = new Video()
                    {
                        Image = bmp,
                        URL = link,
                        Title = title,
                        PageIndex = temp.index + "",
                        VideoID = videoID
                    };
                    lock (videos)
                    {
                        if (!Functions.downloaded.Contains(video.VideoID))
                            videos.Add(video);
                    }
                }
            };

            Task task = new Task(action, new { url = url, index = index });
            task.Start();
            await task;
            progressBar1.Value += 1;
        }

        private void AddVideoToDatagrid(List<Video> videos)
        {
            dgvVideo.Invoke(new Action(() =>
            {
                dgvVideo.DataSource = new BindingList<Video>(videos);
            }));
        }

        public async Task DownloadVideo(Video videoBefore, string selectedPath)
        {
            if (!Functions.downloaded.Contains(videoBefore.VideoID))
            {
                Action<object> action = (object param) =>
                {
                    Video obj = (Video)param;
                    var url = Properties.Resources.DownloadUrl + obj.VideoID;
                    string res = Functions.GetData(url);
                    DownloadVideo download = JsonConvert.DeserializeObject<DownloadVideo>(res);
                    string downloadURL = download.URL;
                    string fileName = selectedPath + "\\video" + obj.VideoID + ".mp4";
                    if (!string.IsNullOrEmpty(downloadURL))
                    {
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileAsync(new Uri(downloadURL), fileName);
                    }
                    else
                    {
                        MessageBox.Show("loi tai url");
                    }
                    //download video
                   
                };

                Task task = new Task(action, videoBefore);
                task.Start();
                await task;
                StreamWriter dw = new StreamWriter("download.txt", true);
                dw.WriteLine(videoBefore.VideoID);
                dw.Close();
                lock (Functions.downloaded)
                {
                    Functions.downloaded += (videoBefore.VideoID + "\n");
                }
                progressBar2.Value += 1;
            }
            else
            {
                progressBar2.Value += 1;
            }
        }

        private async void dgvVideo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                List<Task> tasks = new List<Task>();
                progressBar2.Maximum = 1;
                progressBar2.Value = 0;
                Video selected = (Video)(dgvVideo.Rows[e.RowIndex].DataBoundItem);
                tasks.Add(DownloadVideo(selected, downloadFolder));
                await Task.WhenAll(tasks);
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            await DonwloadAll();
        }

        public async Task DonwloadAll()
        {
            List<Task> totalTasks = new List<Task>();
            progressBar2.Maximum = dgvVideo.Rows.Count;
            progressBar2.Value = 0;
            for (int i = 0; i < dgvVideo.Rows.Count; i += 5)
            {
                List<Task> tasks = new List<Task>();
                for (int j = i; j < i + 5; j++)
                {
                    if (j >= dgvVideo.Rows.Count) { break; }
                    Video selected = (Video)(dgvVideo.Rows[j].DataBoundItem);
                    var task = DownloadVideo(selected, downloadFolder);
                    tasks.Add(task);
                    totalTasks.Add(task);
                }
                await Task.WhenAll(tasks);
            }
            await Task.WhenAll(totalTasks);
            MessageBox.Show("Donwload thanh cong");
        }

        private void dgvVideo_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvVideo.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}