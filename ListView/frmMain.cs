using System;
using System.Windows.Forms;

namespace ListView
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maSv = txtMaSV.Text;
            string hoTen = txtHoten.Text;
            string soDienThoai = txtDienThoai.Text;
            ListViewItem item = new ListViewItem(new string[] { maSv, hoTen, soDienThoai });
            lsvSinhVien.Items.Add(item);
            XoaText();
        }

        private void XoaText()
        {
        }

        private void lsvSinhVien_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = e.Item;
            txtMaSV.Text = item.Text;
            txtHoten.Text = item.SubItems[1].Text;
            txtDienThoai.Text = item.SubItems[2].Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string masv = txtMaSV.Text;
            if (string.IsNullOrEmpty(masv))
            {
                MessageBox.Show("Chua nhap ma sinh vien.");
                return;
            }
            foreach (ListViewItem item in lsvSinhVien.Items)
            {
                if (item.Text == masv)
                {
                    item.Remove();
                    MessageBox.Show("Xoa thanh cong");
                    return;
                }
            }
            MessageBox.Show("khong ton tai du lieu can xoa");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lsvSinhVien.Items)
            {
                if (item.Text == txtMaSV.Text)
                {
                    item.SubItems[1].Text = txtHoten.Text;
                    item.SubItems[2].Text = txtDienThoai.Text;
                    MessageBox.Show("Cap nhat thanh cong");
                    return;
                }
            }
        }
    }
}