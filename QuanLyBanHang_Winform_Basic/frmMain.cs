using QuanLyBanHang_Winform_Basic.Classes;
using System;
using System.Windows.Forms;

namespace QuanLyBanHang_Winform_Basic
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DataAccess.Connect();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataAccess.Disconnect();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhMucChatLieu frmDanhMucChatLieu = new frmDanhMucChatLieu();
            frmDanhMucChatLieu.MdiParent = this;
            frmDanhMucChatLieu.Show();
        }

        private void hàngHoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhMucHangHoa frmDanhMucHangHoa = new frmDanhMucHangHoa();
            frmDanhMucHangHoa.MdiParent = this;
            frmDanhMucHangHoa.Show();
        }

        private void nhânVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhMucNhanVien frmDanhMucNhanVien = new frmDanhMucNhanVien();
            frmDanhMucNhanVien.MdiParent = this;
            frmDanhMucNhanVien.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhMucKhachHang frmDanhMucKhachHang = new frmDanhMucKhachHang();
            frmDanhMucKhachHang.MdiParent = this;
            frmDanhMucKhachHang.Show();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBanHang frmHoaDonBanHang = new frmHoaDonBanHang();
            frmHoaDonBanHang.MdiParent = this;
            frmHoaDonBanHang.Show();
        }

        private void mnuTimKiemHoaDon_Click(object sender, EventArgs e)
        {
            frmTimKiemHoaDon frmTimKiemHoaDon = new frmTimKiemHoaDon();
            frmTimKiemHoaDon.MdiParent = this;
            frmTimKiemHoaDon.Show();
        }

        private void mnuBaoCaoHangTon_Click(object sender, EventArgs e)
        {
            frmNhapXuatTon frm = new frmNhapXuatTon();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}