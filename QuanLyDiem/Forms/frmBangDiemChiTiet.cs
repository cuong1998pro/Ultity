using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyDiem.Forms
{
    public partial class frmBangDiemChiTiet : Form
    {
        public frmBangDiemChiTiet()
        {
            InitializeComponent();
        }

        private QuanLyDiemDataContext dt = new QuanLyDiemDataContext();

        private void frmBangDiemChiTiet_Load(object sender, EventArgs e)
        {
            cboChonLop.DataSource = dt.Lop_SelectAll();
            cboChonLop.DisplayMember = "MaLop";
            cboChonLop.ValueMember = "MaLop";
        }

        private void cboChonLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            var maLop = cboChonLop.Text;
            trvSinhVien.Nodes.Clear();
            TreeNode root = new TreeNode();
            root.Text = "---Chọn sinh viên";
            trvSinhVien.Nodes.Add(root);
            foreach (var item in dt.SinhVien_SelectMaLop(maLop))
            {
                TreeNode node = new TreeNode();
                node.Name = item.MaSV;
                node.Text = item.HoTen;
                trvSinhVien.Nodes.Add(node);
            }
            trvSinhVien.ExpandAll();
        }

        private void trvSinhVien_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Index == 0)
            {
                return;
            }
            var maSV = e.Node.Name.ToString();
            var sinhVien = dt.SinhVien_SelectID(maSV).First();
            Functions.Binding(txtMaSV, "Text", sinhVien, "MaSV");
            Functions.Binding(txtHoten, "Text", sinhVien, "HoTen");
            Functions.Binding(dpkNgaySinh, "Text", sinhVien, "NgaySinh");
            Functions.Binding(txtNoiSinh, "Text", sinhVien, "NoiSinh");
            Functions.Binding(txtGioiTinh, "Text", sinhVien, "GioiTinh");
            Functions.Binding(txtDanToc, "Text", sinhVien, "DanToc");

            var table = new DataTable();
            DataColumnCollection cols = table.Columns;
            cols.Add("MaMon");
            cols.Add("TenMon");
            cols.Add("SoTinChi");
            cols.Add("DiemHP");
            cols.Add("DiemSo");
            cols.Add("DiemChu");

            float tong = 0, tongSoTinChi = 0;
            foreach (var monHP in dt.MonHP_SelectMaSV(maSV))
            {
                var maMon = monHP.MaMon;
                DataRow row = table.NewRow();
                row["MaMon"] = maMon;
                row["TenMon"] = monHP.TenMon;
                row["SoTinChi"] = monHP.SoTinChi;
                var soTinChi = int.Parse(monHP.SoTinChi.ToString());
                tongSoTinChi += soTinChi;
                var diemHP = float.Parse(dt.DiemHP_Search(maMon, maSV).First().Diem.ToString());
                tong += soTinChi * Functions.DiemSo((double)diemHP);
                row["DiemHP"] = diemHP;
                row["DiemChu"] = Functions.DiemChu((double)diemHP);
                row["DiemSo"] = Functions.DiemSo((double)diemHP);
                table.Rows.Add(row);
            }
            dgvBangDiemChiTiet.DataSource = table;
            double t = Math.Round(tong / tongSoTinChi, 2);
            txtXLTB.Text = t.ToString();
            txtXLTK.Text = Functions.XepLoaiToanKhoa(t);
        }
    }
}