using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            Process.Start(Properties.Resources.HomeUrl);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            dgvVideo.AutoGenerateColumns = false;
            Functions.downloaded = ReadFile("download.txt");
            Functions.blocked = ReadFile("blocked.txt");
            if (!Directory.Exists(downloadFolder))
            {
                Directory.CreateDirectory(downloadFolder);
            }
            btnUseCookie_Click(null, null);
        }

        public string ReadFile(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            return string.Empty;
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
        }

        private async void btnHistory_Click(object sender, EventArgs e)
        {
            try
            {
                var task = GetVideoURL(Functions.history, Properties.Resources.HistoryUrl);
                await task;
            }
            catch
            {
                MessageBox.Show("Khong co lich su");
            }
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
                string imageRegex = @"(?<=<img src=""https://www.xvideos3.com/static-files/img/lightbox/lightbox-blank.giff"" data-src="").*?(?="" data-idcdn)";
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
                        if (!Functions.downloaded.Contains(video.VideoID) && !Functions.blocked.Contains(video.VideoID))
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
                    try
                    {
                        Video obj = (Video)param;
                        var url = Properties.Resources.DownloadUrl + obj.VideoID;
                        string res = Functions.GetData(url);
                        DownloadVideo download = JsonConvert.DeserializeObject<DownloadVideo>(res);
                        string downloadURL = download.URL;
                        string fileName = selectedPath + "\\video" + obj.VideoID + ".mp4";
                        if (!string.IsNullOrEmpty(downloadURL))
                        {
                            WebRequest request = WebRequest.Create(downloadURL);
                            request.Timeout = int.MaxValue;
                            WebResponse response = request.GetResponse();
                            using (Stream responseStream = response.GetResponseStream())
                            {
                                using (Stream fileStream = File.OpenWrite(fileName))
                                {
                                    try
                                    {
                                        byte[] buffer = new byte[4096];
                                        int bytesRead = responseStream.Read(buffer, 0, 4096);
                                        while (bytesRead > 0)
                                        {
                                            fileStream.Write(buffer, 0, bytesRead);
                                            bytesRead = responseStream.Read(buffer, 0, 4096);
                                        }
                                    }
                                    catch { }
                                }
                            }
                        }
                    }
                    catch { }
                };
                try
                {
                    Task task = new Task(action, videoBefore);
                    task.Start();
                    await task;
                }
                catch { }
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
            for (int i = 0; i < dgvVideo.Rows.Count; i += 15)
            {
                List<Task> tasks = new List<Task>();
                for (int j = i; j < i + 15; j++)
                {
                    try
                    {
                        if (j >= dgvVideo.Rows.Count) { break; }
                        Video selected = (Video)(dgvVideo.Rows[j].DataBoundItem);
                        await Task.Delay(new TimeSpan(2000));
                        var task = DownloadVideo(selected, downloadFolder);
                        tasks.Add(task);
                        totalTasks.Add(task);
                    }
                    catch { }
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
                Video video = dgvVideo.Rows[e.RowIndex].DataBoundItem as Video;
                dgvVideo.Rows.RemoveAt(e.RowIndex);
                StreamWriter dw = new StreamWriter("blocked.txt", true);
                dw.WriteLine(video.VideoID);
                dw.Close();
                lock (Functions.downloaded)
                {
                    Functions.downloaded += (video.VideoID + "\n");
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                dgvVideo.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}