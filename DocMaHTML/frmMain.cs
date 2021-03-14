using mshtml;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace DocMaHTML
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void LoadHTML(string url)
        {
            WebClient client = new WebClient();
            Stream data = client.OpenRead(new Uri(url));
            StreamReader reader = new StreamReader(data);
            string htmlContent = reader.ReadToEnd();
            txtNoiDung.Text = htmlContent;
            ProcessHTML(htmlContent);
            data.Close();
            reader.Close();
        }

        private void ProcessHTML(string htmlContent)
        {
            IHTMLDocument2 document = (IHTMLDocument2)new mshtml.HTMLDocument();
            document.write(htmlContent);
            IHTMLElementCollection imgElements = document.images;

            lbHinhAnh.Items.Clear();
            foreach (IHTMLImgElement item in imgElements)
            {
                lbHinhAnh.Items.Add(item.src);
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            LoadHTML(txtURL.Text);
        }

        private void btnLoadAnh_Click(object sender, EventArgs e)
        {
            flThuVienAnh.Controls.Clear();
            foreach (string imageURL in lbHinhAnh.Items)
            {
                PictureBox pic = new PictureBox();
                pic.Width = 100;
                pic.Height = 100;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.ImageLocation = imageURL;
                flThuVienAnh.Controls.Add(pic);
            }
        }
    }
}