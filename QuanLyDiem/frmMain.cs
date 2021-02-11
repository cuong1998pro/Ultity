using QuanLyDiem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            frmLopSinhVien frm = new frmLopSinhVien();
            frm.ShowDialog();
        }

        private void btnQuanLyDiem_Click(object sender, EventArgs e)
        {
            frmMonDiemHP frm = new frmMonDiemHP();
            frm.ShowDialog();
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            frmThongTinHeThong frm = new frmThongTinHeThong();
            frm.ShowDialog();
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            frmBangDiemChiTiet frm = new frmBangDiemChiTiet();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToString("dddd dd/MM/yyyy \r\nhh:mm:ss");
            lblTime.Text = time;
        }

        private void btnThongKeSinhVien_Click(object sender, EventArgs e)
        {
            frmThongKeSinhVienTheoLop frm = new frmThongKeSinhVienTheoLop();
            frm.ShowDialog();
        }
    }
}