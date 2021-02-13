using AutoIt;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Selenium
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private FirefoxDriver fd = null;

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            var profilePath = "Profile";
            FirefoxProfile profile = new FirefoxProfile(profilePath);
            FirefoxOptions option = new FirefoxOptions();
            option.Profile = profile;
            fd = new FirefoxDriver(option);
        }

        private void GetElement()
        {
            fd.FindElement(By.Id("html id"));
            fd.FindElement(By.CssSelector(".css"));
            fd.FindElement(By.ClassName("classname1"));
            fd.FindElement(By.LinkText("text button"));
            fd.FindElement(By.Name("name"));
            fd.FindElement(By.PartialLinkText("pText"));
            fd.FindElement(By.TagName("div"));

            var element = fd.FindElement(By.Id("html id"));
            element.SendKeys("Selenium Kteam");
            element.Click();

            //xpath: chon element theo trat tu
            //chuot phai firefox co xpath :
            var h5 = fd.FindElementByXPath("/html/body/div[1]/main/div[3]/div/h5[1]");

            //cssSelector: chuot phai co css
            var elementByCss = fd.FindElementByCssSelector("div.bg-white:nth-child(3) > div:nth-child(1) > h5:nth-child(1)");

            //cach thuoc tinh va phuong thuc void web
            element.Clear();                                        //xoa nd
            element.Click();                                        //khong co mouse hover
            bool isDisplay = element.Displayed;                     //kiem tra co hien thi chua
            element.Equals("object");                               //kiem tra element bang nhau
            element.FindElement(By.Id("id"));
            element.FindElements(By.Id("id"));
            element.GetAttribute("src");                            //tra ra attribute html
            element.GetCssValue("css prop");                        //tra ra gia tri css
            System.Drawing.Point location = element.Location;
            bool isSeleted = element.Selected;                      //element co duoc chon
            element.SendKeys("abc");
            var size = element.Size;
            element.Submit();                                       //submit
            var tagName = element.TagName;                          //tag
            var text = element.Text;
        }

        private void CacHamCoBan()
        {
            //vao mot url: fd.Navigate().GoToUrl("www.google.com");
            fd.Url = "https://www.google.com";
            fd.Navigate();

            //lay pageSoure
            var pageSource = fd.PageSource;
            var currentUrl = fd.Url;

            //di chuyen ve trang truoc
            fd.Navigate().Back();
            fd.Navigate().Forward();
            fd.Navigate().Refresh();

            //handle alert
            IAlert alert = fd.SwitchTo().Alert();
            alert.Accept();
            alert.Dismiss();

            //chuyen doi giua cac cua so, cac tab
            ReadOnlyCollection<string> windowHandles = fd.WindowHandles;
            string firstTab = windowHandles.First();
            string lastTab = windowHandles.Last();
            fd.SwitchTo().Window(lastTab);

            //maxium window
            fd.Manage().Window.Maximize();

            //add cookie
            Cookie newCookie = new Cookie("key", "value");
            fd.Manage().Cookies.AddCookie(newCookie);

            //get all cookie
            var cookies = fd.Manage().Cookies.AllCookies;

            //delete cookie
            fd.Manage().Cookies.DeleteCookieNamed("name");
            fd.Manage().Cookies.DeleteAllCookies();

            //chup man hinh
            Screenshot screenshot = ((ITakesScreenshot)fd).GetScreenshot();
            screenshot.SaveAsFile(@"path", ScreenshotImageFormat.Png);

            //doi website load xong: hen xui
            WebDriverWait wait = new WebDriverWait(fd, TimeSpan.FromSeconds(30));
            wait.Until(
                (x) =>
                {
                    return ((IJavaScriptExecutor)fd).ExecuteScript("return document.readyState").Equals("complete");
                }
                );

            //chuyen doi giua ca frames
            fd.SwitchTo().Frame(1);
            fd.SwitchTo().Frame("frameName");
            IWebElement element = fd.FindElement(By.Id("id"));
            fd.SwitchTo().Frame(element);

            //chuyen toi document mac dinh
            fd.SwitchTo().DefaultContent();

            //scroll to element
            IJavaScriptExecutor js = fd as IJavaScriptExecutor;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            Thread.Sleep(TimeSpan.FromSeconds(3));
        }

        private void ExecuteJavaScript()
        {
            fd.Url = "http://www.howkteam.com/";
            fd.Navigate();
            fd.ExecuteScript("javascript code");

            //lay ket qua
            IJavaScriptExecutor js = fd as IJavaScriptExecutor;
            var dataFromJS = js.ExecuteScript("var content = document.getElementsByClass.....").ToString();
        }

        private void Profile()
        {
            //duong dan: C:\Users\private\AppData\Roaming\Mozilla\Firefox\Profiles
            //Luu lich su cai dat, thong tin trinh duyet web, ...

            //dung profile da co
            FirefoxProfile profile = new FirefoxProfile(@"C:\Users\private\AppData\Roaming\Mozilla\Firefox\Profiles\g1vb3hmd.dev-edition-default-1609216718709");
            FirefoxOptions option = new FirefoxOptions();
            option.Profile = profile;
            fd = new FirefoxDriver(option);

            //profile selenium tu tao: C:\Users\private\AppData\Local\Temp\rust_mozprofilelpXhN3
        }

        private void Proxy()
        {
            //http://www.freeproxylists.net/
            //whoer.net
            var ip = "134.122.34.39";
            var port = 8080;
            FirefoxProfile profile = new FirefoxProfile();
            profile.SetPreference("network.proxy.type", 1);
            profile.SetPreference("network.proxy.http", ip);
            profile.SetPreference("network.proxy.http_port", port);
            profile.SetPreference("network.proxy.ssl", ip);
            profile.SetPreference("network.proxy.ssl_port", port);
            profile.SetPreference("media.peerconnection.enabled", false);
            FirefoxOptions option = new FirefoxOptions();
            option.Profile = profile;
            fd = new FirefoxDriver(option);
            fd.Url = "https://whoer.net/";
            fd.Navigate();
        }

        private void ChangeIframe()
        {
            fd = new FirefoxDriver();
            fd.Url = "https://www.google.com";
            fd.Navigate();

            var youtubePlayer = fd.FindElementById("id");
            youtubePlayer.Click();

            //chuyen sang iframe
            fd.SwitchTo().Frame(youtubePlayer);
            var button = fd.FindElementById("idbutton");

            button.Click();
        }

        private void WaitLoad(FirefoxDriver fds)
        {
            WebDriverWait wait = new WebDriverWait(fds, TimeSpan.FromSeconds(30));
            wait.Until(
                (x) =>
                {
                    return ((IJavaScriptExecutor)fds).ExecuteScript("return document.readyState").Equals("complete");
                }
                );
            Thread.Sleep(1000);
        }

        private void UploadFile()
        {
            //secufiles.com
            fd = new FirefoxDriver();
            fd.Url = "https://neilpatel.com/blog/speed-is-a-killer/";
            fd.Navigate();

            WaitLoad(fd);

            var upload = fd.FindElementByCssSelector(".slider-btn");
            upload.Click();
            var upload2 = fd.FindElementByXPath("/html/body/div[2]/div/div/div[2]/div/div[1]/div/div[1]/div/div/form/div[2]/label/div/div[1]/div/div");
            upload2.Click();

            AutoItX.WinActivate("Tải lên một tập tin");
            AutoItX.Send(AppDomain.CurrentDomain.BaseDirectory + "uploadfile.txt");

            Thread.Sleep(TimeSpan.FromSeconds(1));

            AutoItX.Send("{ENTER}");

            Thread.Sleep(TimeSpan.FromSeconds(3));
            var uploadButton = fd.FindElementByXPath("/html/body/div[2]/div/div/div[2]/div/div[1]/div/div[1]/div/div/form/div[2]/div/div[2]/div[1]/button");
            uploadButton.Click();
        }
    }
}