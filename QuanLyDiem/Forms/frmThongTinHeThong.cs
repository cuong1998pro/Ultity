using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem.Forms
{
    public partial class frmThongTinHeThong : Form
    {
        public frmThongTinHeThong()
        {
            InitializeComponent();
        }

        private QuanLyDiemDataContext dt = new QuanLyDiemDataContext();

        private void frmThongTinHeThong_Load(object sender, EventArgs e)
        {
            var thongTin = dt.ThongTin_SelectAll();
            Functions.Binding(txtTenTinh, "Text", thongTin, "Tinh");
            Functions.Binding(txtDonViChuQuan, "Text", thongTin, "DonViChuQuan");
            Functions.Binding(txtTenTruong, "Text", thongTin, "TenTruong");
            Functions.Binding(txtKhoaHoc, "Text", thongTin, "KhoaHoc");
            Functions.Binding(txtNganhHoc, "Text", thongTin, "NganhHoc");
            Functions.Binding(txtChuyenNganh, "Text", thongTin, "ChuyenNganh");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var tenTinh = txtTenTinh.Text.Trim();
            var donViChuQuan = txtDonViChuQuan.Text.Trim();
            var tenTruong = txtTenTruong.Text.Trim();
            var khoaHoc = txtKhoaHoc.Text.Trim();
            var nganhHoc = txtNganhHoc.Text.Trim();
            var chuyenNganh = txtChuyenNganh.Text.Trim();
            dt.ThongTin_Update(tenTinh, donViChuQuan, tenTruong, khoaHoc, nganhHoc, chuyenNganh);
            frmThongTinHeThong_Load(null, null);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}