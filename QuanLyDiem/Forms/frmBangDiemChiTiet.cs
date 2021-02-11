using Microsoft.Office.Interop.Excel;
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

            var table = new System.Data.DataTable();
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

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            //excell -> workbook -> sheet
            _Application app = new Microsoft.Office.Interop.Excel.Application();
            _Workbook workbook = app.Workbooks.Add();
            _Worksheet workSheet = workbook.Sheets["Sheet1"];
            workSheet = workbook.ActiveSheet;

            //do du vao sheet
            workSheet.Cells[1, 1] = "BẢNG TỔNG HỢP BẢNG ĐIỂM CHI TIẾT SINH VIÊN";
            workSheet.Cells[3, 2] = "Mã SV:" + txtMaSV.Text;
            workSheet.Cells[4, 2] = "Họ tên:" + txtHoten.Text;
            workSheet.Cells[5, 2] = "Giới tính:" + txtGioiTinh.Text;
            workSheet.Cells[6, 2] = "Dân tộc:" + txtDanToc.Text;
            workSheet.Cells[7, 2] = "Nơi sinh:" + txtNoiSinh.Text;

            //render bang
            workSheet.Cells[9, 1] = "STT";
            workSheet.Cells[9, 2] = "Mã môn";
            workSheet.Cells[9, 3] = "Tên môn";
            workSheet.Cells[9, 4] = "Số tín chỉ";
            workSheet.Cells[9, 5] = "Điểm HP";
            workSheet.Cells[9, 6] = "Điểm số";
            workSheet.Cells[9, 7] = "Điểm chữ";

            for (int i = 0; i < dgvBangDiemChiTiet.RowCount; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    workSheet.Cells[i + 10, 1] = i + 1;
                    workSheet.Cells[i + 10, j + 2] = dgvBangDiemChiTiet[j, i].Value.ToString();
                }
            }

            int mon = dgvBangDiemChiTiet.RowCount;
            workSheet.Cells[mon + 11, 1] = "Trung bình toàn khoá: " + txtXLTB.Text;
            workSheet.Cells[mon + 12, 1] = "Xếp loại toàn khoá: " + txtXLTK.Text;

            //dinh dang excel: dinh dang trong excel truoc
            workSheet.PageSetup.Orientation = XlPageOrientation.xlPortrait;
            workSheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
            workSheet.PageSetup.TopMargin = 0;
            workSheet.PageSetup.BottomMargin = 0;
            workSheet.PageSetup.LeftMargin = 0;
            workSheet.PageSetup.RightMargin = 0;

            workSheet.Range["A1"].ColumnWidth = 8.25;
            workSheet.Range["B1"].ColumnWidth = 11.5;
            workSheet.Range["C1"].ColumnWidth = 40;
            workSheet.Range["D1"].ColumnWidth = 11;
            workSheet.Range["E1"].ColumnWidth = 11;
            workSheet.Range["F1"].ColumnWidth = 11;
            workSheet.Range["G1"].ColumnWidth = 11;

            workSheet.Range["A1", "G100"].Font.Name = "Times New Roman";
            workSheet.Range["A1", "G100"].Font.Size = 14;
            workSheet.Range["A1", "G1"].MergeCells = true;
            workSheet.Range["A1", "G1"].Font.Bold = true;
            workSheet.Range["A1", "G1"].HorizontalAlignment = XlHAlign.xlHAlignCenter;

            workSheet.Range["A9", "G9"].Font.Bold = true;
            workSheet.Range["A9", "G9"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            workSheet.Range["A9", "G" + (mon + 9).ToString()].Borders.LineStyle = XlLineStyle.xlContinuous;
            workSheet.Range["A10", "A" + (mon + 9)].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            workSheet.Range["B10", "B" + (mon + 9)].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            workSheet.Range["D10", "D" + (mon + 9)].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            workSheet.Range["E10", "E" + (mon + 9)].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            workSheet.Range["F10", "F" + (mon + 9)].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            workSheet.Range["G10", "G" + (mon + 9)].HorizontalAlignment = XlHAlign.xlHAlignCenter;

            app.Visible = true;
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }
    }
}