using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZingMp3CrawData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged

    {
        #region prop

        private bool isCheckVietNam;
        private bool isCheckAuMy;
        private bool isCheckHanQuoc;

        public bool IsCheckVietNam
        {
            get => isCheckVietNam; set
            {
                isCheckVietNam = value;
                isCheckAuMy = false;
                isCheckHanQuoc = false;
                lsbTopSong.ItemsSource = listVN;
                OnPropertyChanged("IsCheckVietNam");
                OnPropertyChanged("IsCheckAuMy");
                OnPropertyChanged("IsCheckHanQuoc");
            }
        }

        public bool IsCheckAuMy
        {
            get => isCheckAuMy; set
            {
                isCheckVietNam = false;
                isCheckAuMy = value;
                isCheckHanQuoc = false;
                lsbTopSong.ItemsSource = listEU;
                OnPropertyChanged("IsCheckVietNam");
                OnPropertyChanged("IsCheckAuMy");
                OnPropertyChanged("IsCheckHanQuoc");
            }
        }

        public bool IsCheckHanQuoc
        {
            get => isCheckHanQuoc; set
            {
                isCheckVietNam = false;
                isCheckAuMy = false;
                isCheckHanQuoc = value;
                lsbTopSong.ItemsSource = listKorean;
                OnPropertyChanged("IsCheckVietNam");
                OnPropertyChanged("IsCheckAuMy");
                OnPropertyChanged("IsCheckHanQuoc");
            }
        }

        #endregion prop

        private HttpClient http;

        private Uri baseUrl = new Uri("https://zingmp3.vn/");

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            InitHttpClient();
            CrawData(); IsCheckVietNam = true;

            //ChonBXH(btnVietNam);
        }

        private ObservableCollection<Item> listVN;
        private ObservableCollection<Item> listEU;
        private ObservableCollection<Item> listKorean;

        private void InitHttpClient()
        {
            HttpClientHandler handler = new HttpClientHandler();

            CookieContainer cookie = new CookieContainer();
            handler.CookieContainer = cookie;

            handler.ClientCertificateOptions = ClientCertificateOption.Automatic;
            handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            handler.AllowAutoRedirect = true;
            handler.UseDefaultCredentials = false;

            http = new HttpClient(handler);
            http.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:86.0) Gecko/20100101 Firefox/86.0");
            http.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "*/*");
            http.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate, br");
            http.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "en-US");
            http.DefaultRequestHeaders.TryAddWithoutValidation("Host", "zingmp3.vn");
            http.BaseAddress = baseUrl;

            //string cookieString = "zpsid=eMqpTcwdFagwSouHAhqaNBit8WujlofQlYib2pB8RYtq0HmR88bEEyr-0WutYKGCr4eLBJUbQ7_nI1nmPA9jQhnr2cPskLfoade2HqUCPMgXQMXSTU4wV0; zpsidleg=eMqpTcwdFagwSouHAhqaNBit8WujlofQlYib2pB8RYtq0HmR88bEEyr-0WutYKGCr4eLBJUbQ7_nI1nmPA9jQhnr2cPskLfoade2HqUCPMgXQMXSTU4wV0; __zi=3000.SSZzejyD0jSbZUgxWaGPoJIFlgNCIW6AQ9sqkju84vnyakgps4rUctwSxBQMIb-RCvlkiPzBKviqDG.1; _zlang=vn; zmp3_app_version.1=1022; zmp3_rqid=MHwxNC4yMzUdUngMjA4LjM5fHYxLjAdUngMjJ8MTYxMzM5MDExOTk5NA; zmp3_sid=mVkC9An3SndU_8uggaPl7jlZ-MxT34Kdo_6uJiirEZdUvhX4_2mEBltcb6YF2GmdeBMJRPf4CJ6sfuXQWce-EPUMlMMQMIrJZAJGEem1PLA_kVKaQMG; _ga=GA1.2.2139146386.1613375782; _gid=GA1.2.2084430700.1613375782; _fbp=fb.1.1613375781772.130300411; fpsend=149387";
            //AddCookie(cookie, cookieString);
        }

        public int GetWeekNumber(DateTime date)
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }

        private string GetStringFromURL(string url)
        {
            return WebUtility.HtmlDecode(http.GetStringAsync(url).Result);
        }

        private void AddCookie(CookieContainer cookieContainer, string cookies)
        {
            var cookieArray = cookies.Split(';');
            foreach (var cookie in cookieArray)
            {
                var result = cookie.Split('=');
                if (result.Count() == 2)
                {
                    string key = result[0].ToString().Trim();
                    string value = result[1].ToString().Trim();
                    cookieContainer.Add(baseUrl, new Cookie(key, value));
                }
            }
        }

        private void CrawData()
        {
            var week = GetWeekNumber(DateTime.Now) - 2;
            var year = DateTime.Now.Year;

            http.GetStringAsync("https://zingmp3.vn/zing-chart-tuan/bai-hat-Kpop/IWZ9Z0BO.html");

            //var tick = DateTime.Now.Subtract(
            //    new DateTime(1970, 1, 1)
            //    ).TotalSeconds;

            var urlBXHViet = $"https://zingmp3.vn/api/v2/chart/getWeekChart?id=IWZ9Z08I&week={week}&year={year}&ctime=1613376233&version=1.0.22&sig=d83daaaa21bf6b8f95b880abee644e901c5f4e53264b03fc789402d426b51f14a9d965fbeb9249c861bd55e165d183ca23a8e1f2d6c7e5e95d6e7c62e5796a6a&apiKey=kI44ARvPwaqL7v0KuDSM0rGORtdY1nnw";
            var urlBXHAuMy = $"https://zingmp3.vn/api/v2/chart/getWeekChart?id=IWZ9Z0BW&week={week}&year={year}&ctime=1613376338&version=1.0.22&sig=556d327b701f0290f1515915310baec9e3b790e951c420b20ef2eb39a6ead25215688f12ea328a911e6f0d074688392d8639e142b091d0d72e21ea133fb8908d&apiKey=kI44ARvPwaqL7v0KuDSM0rGORtdY1nnw";
            var urlBXHHanQuoc = $"https://zingmp3.vn/api/v2/chart/getWeekChart?id=IWZ9Z0BO&week={week}&year={year}&ctime=1613376340&version=1.0.22&sig=f500e034cf46b696eb62e84afaa6c4fea242ab971bff4fc0cbe06c4ce54f31e8d04f48166e308100cd8cf28a761a5ea86e36e5421732c434b6749c8e71b90559&apiKey=kI44ARvPwaqL7v0KuDSM0rGORtdY1nnw";

            var str = GetStringFromURL(urlBXHViet);
            listVN = new ObservableCollection<Item>(JsonConvert.DeserializeObject<Rootobject>(GetStringFromURL(urlBXHViet)).data.items);
            listEU = new ObservableCollection<Item>(JsonConvert.DeserializeObject<Rootobject>(GetStringFromURL(urlBXHAuMy)).data.items);
            listKorean = new ObservableCollection<Item>(JsonConvert.DeserializeObject<Rootobject>(GetStringFromURL(urlBXHHanQuoc)).data.items);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

        private void MainBrowser_LoadCompleted(object sender, NavigationEventArgs e)
        {
            var wbMain = sender as WebBrowser;

            SetSilent(wbMain, true); // make it silent
        }

        private void SetSilent(WebBrowser browser, bool silent)
        {
            if (browser == null)
                throw new ArgumentNullException("browser");

            // get an IWebBrowser2 from the document
            IOleServiceProvider sp = browser.Document as IOleServiceProvider;
            if (sp != null)
            {
                Guid IID_IWebBrowserApp = new Guid("0002DF05-0000-0000-C000-000000000046");
                Guid IID_IWebBrowser2 = new Guid("D30C1661-CDAF-11d0-8A3E-00C04FC9E26E");

                object webBrowser;
                sp.QueryService(ref IID_IWebBrowserApp, ref IID_IWebBrowser2, out webBrowser);
                if (webBrowser != null)
                {
                    webBrowser.GetType().InvokeMember("Silent", BindingFlags.Instance | BindingFlags.Public | BindingFlags.PutDispProperty, null, webBrowser, new object[] { silent });
                }
            }
        }

        [ComImport, Guid("6D5140C1-7436-11CE-8034-00AA006009FA"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface IOleServiceProvider
        {
            [PreserveSig]
            int QueryService([In] ref Guid guidService, [In] ref Guid riid, [MarshalAs(UnmanagedType.IDispatch)] out object ppvObject);
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var data = (Item)(sender as Border).DataContext;
            var baiHatUrl = data.link;
            var url = "https://zingmp3.vn" + baiHatUrl;
            wbMain.Source = new Uri(url);
        }
    }
}