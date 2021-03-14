using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace ChupHinhControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChup_Click(object sender, EventArgs e)
        {
            string name = cboDoiTuong.Text;
            Control control = this.Controls.Find(name, true).FirstOrDefault();
            ControlToBitmap(control);
        }

        private void ControlToBitmap(Control control)
        {
            Size ctrlSize = control.Size;
            Rectangle rect = new Rectangle(new Point(0, 0), ctrlSize);
            Bitmap bitmap = new Bitmap(ctrlSize.Width, ctrlSize.Height);
            control.DrawToBitmap(bitmap, rect);
            Bitmap result = new Bitmap(ctrlSize.Width, ctrlSize.Height);
            Graphics g = Graphics.FromImage(result);
            rect.Size = ctrlSize;
            g.DrawImage(bitmap, rect);
            picKetQua.Image = result;
        }
    }
}