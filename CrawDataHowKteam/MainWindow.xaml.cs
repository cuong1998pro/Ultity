using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace CrawDataHowKteam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HttpClient http;
        private ObservableCollection<MenuTreeItem> TreeItems;

        private string HomePage = "https://www.howkteam.com/";

        public MainWindow()
        {
            InitializeComponent();
            this.InitHttpClient(http);
            TreeItems = new ObservableCollection<MenuTreeItem>();
            trvMain.ItemsSource = TreeItems;
        }

        private void InitHttpClient(HttpClient client)
        {
            HttpClientHandler handler = new HttpClientHandler();
            CookieContainer cookie = new CookieContainer();

            handler.CookieContainer = cookie;
            handler.ClientCertificateOptions = ClientCertificateOption.Automatic;
            handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            handler.AllowAutoRedirect = true;
            handler.UseDefaultCredentials = false;

            http = new HttpClient(handler);
            http.BaseAddress = new Uri(HomePage);

            //origin, host, referer, :scheme, accept, accept-encoding, accept-language, user-agent
            http.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:86.0) Gecko/20100101 Firefox/86.0");
            http.DefaultRequestHeaders.TryAddWithoutValidation("Host", "www.howkteam.vn");
            http.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "Language: en-US");
            http.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate, br");
            http.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,*/*;q=0.8");
        }

        private void AddItemIntoTreeView(ObservableCollection<MenuTreeItem> root, MenuTreeItem child)
        {
            trvMain.Dispatcher.Invoke(new Action(() =>
            {
                root.Add(child);
            }));
        }

        private string GetHtml(string url)
        {
            return WebUtility.HtmlDecode(http.GetStringAsync(url).Result);
        }

        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            Thread t = new Thread(
                () =>
            {
                var url = "Learn";
                var html = GetHtml(url);
                var stringRegex = @"(?<=<div class=""col-md-6 col-xl-3"">).*?(?=<div class=""col-md-6 col-xl-3"">)";

                var coursesHtml = Regex.Matches(html, stringRegex, RegexOptions.Singleline);
                foreach (var item in coursesHtml)
                {
                    string getCourseNameRegex = @"(?<=h4 class=""font-size-default font-w600 mb-10 text-overflow-dot"" title="")(.*?)(?="">)";
                    string getCourseLinkRegex = @"(?<=data-href=""/).*?(?="" data-action)";
                    string courseName = Regex.Match(item.ToString(), getCourseNameRegex).ToString();
                    string courseLink = Regex.Match(item.ToString(), getCourseLinkRegex).ToString();

                    MenuTreeItem menu = new MenuTreeItem();
                    menu.Name = courseName;
                    menu.URL = courseLink;

                    AddItemIntoTreeView(TreeItems, menu);

                    string courseID = courseLink.Substring(courseLink.LastIndexOf('-') + 1);

                    string htmlCourse = GetHtml("https://www.howkteam.vn/learn/lecturelist?courseId=" + courseID);
                    string lectureRegex = @"(?<=<span class=""font-w600"">).*?(?=</a>)";
                    string lectureLinkRegex = @"(?<=href=""/).*?(?="")";
                    var lecturesHtml = Regex.Matches(htmlCourse, lectureRegex, RegexOptions.Singleline);
                    var lectureLinks = Regex.Matches(htmlCourse, lectureLinkRegex, RegexOptions.Singleline);
                    for (int i = 0; i < lecturesHtml.Count; i++)
                    {
                        var lectureName = lecturesHtml[i].ToString().Replace(@"</span>
                    ", "");
                        var lectureLink = lectureLinks[i].ToString().Trim();
                        var lecture = new MenuTreeItem();
                        lecture.Name = lectureName;
                        lecture.URL = lectureLink;
                        AddItemIntoTreeView(menu.Items, lecture);
                    }
                }
            }
                );
            t.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as TextBlock;
            string url = HomePage + "/" + button.Tag.ToString();
            wbMain.Navigate(url);

            //Process.Start(url);
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
    }
}