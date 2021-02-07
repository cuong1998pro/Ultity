using QuanLyBanHang_Winform_Basic.Classes;
using QuanLyBanHang_Winform_Basic.Classes.BLL;
using QuanLyBanHang_Winform_Basic.Classes.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;
using ComExcel = Microsoft.Office.Interop.Excel;

namespace QuanLyBanHang_Winform_Basic
{
    public partial class frmHoaDonBanHang : Form
    {
        public frmHoaDonBanHang()
        {
            InitializeComponent();
        }

        private void frmHoaDonBanHang_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnHuyHoaDon.Enabled = btnLuuHoaDon.Enabled = btnInHoaDon.Enabled = true;
            LoadComboBox();
            if (txtMaHoaDon.Text != string.Empty)
            {
                LoadHoaDon(txtMaHoaDon.Text);
            }
        }

        private void LoadHoaDon(string maHD)
        {
            txtMaHoaDon.Text = maHD;
            var hd = BHoaDon.LayHoaDon(maHD);
            dpkNgayBan.Value = hd.NgayBan;
            cboMaNhanVien.SelectedValue = hd.MaNhanVien;
            cboMaNhanVien_SelectionChangeCommitted(null, null);
            cboMaKhach.SelectedValue = hd.MaKhach;
            cboMaKhach_SeletedIndexChangeCommitted(null, null);
            LoadChiTietHDBan(maHD);
            var insertedHoaDon = BHoaDon.LayHoaDon(txtMaHoaDon.Text);
            txtTongTien.Text = insertedHoaDon.TongTien.ToString("N0");
            lblBangChu.Text = "Bằng chữ: " + Functions.DocTienBangChu((long)insertedHoaDon.TongTien, " đồng");
        }

        private void LoadChiTietHDBan(string maHD)
        {
            dgvChiTietHoaDon.DataSource = BHoaDon.LayDanhSachChiTiet(txtMaHoaDon.Text);
            btnHuyHoaDon.Enabled = btnInHoaDon.Enabled = true;
        }

        private void LoadComboBox()
        {
            var dsKhach = DataAccess.ConvertToList<EKhachHang>(BKhachHang.LayDanhSach());
            var dsNhanVien = DataAccess.ConvertToList<ENhanVien>(BNhanVien.LayDanhSach());
            var dsHang = DataAccess.ConvertToList<EHang>(BHang.LayDanhSach());
            Functions.LoadCombobox(dsKhach, cboMaKhach, "MaKhach", "MaKhach");
            Functions.LoadCombobox(dsNhanVien, cboMaNhanVien, "MaNhanVien", "MaNhanVien");
            Functions.LoadCombobox(dsHang, cboMaHang, "MaHang", "MaHang");
            var dsHoaDon = DataAccess.ConvertToList<EHDBan>(BHoaDon.LayDanhSach());
            Functions.LoadCombobox(dsHoaDon, cboMaHoaDonTimKiem, "MaHDBan", "MaHDBan");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHD = GenID();
            txtMaHoaDon.Text = maHD;
            btnThem.Enabled = false;
            btnHuyHoaDon.Enabled = false;
            btnLuuHoaDon.Enabled = true;
            btnInHoaDon.Enabled = false;
        }

        private string GenID()
        {
            return "HD_" + DateTime.Now.ToString("ddMMyy_hhmm");
        }

        private void cboMaKhach_SeletedIndexChangeCommitted(object sender, EventArgs e)
        {
            var khachHang = (EKhachHang)cboMaKhach.SelectedItem;
            txtTenKhach.Text = khachHang.TenKhach;
            txtDiaChi.Text = khachHang.DiaChi;
            mtxtDienThoai.Text = khachHang.DienThoai;
        }

        private void cboMaNhanVien_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var nhanVien = (ENhanVien)cboMaNhanVien.SelectedItem;
            txtTenNhanVien.Text = nhanVien.TenNhanVien;
        }

        private void cboMaHang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var hang = (EHang)cboMaHang.SelectedItem;
            txtTenHang.Text = hang.TenHang;
            nmrDonGia.Value = (decimal)hang.DonGiaBan;
            TinhThanhTien();
        }

        private void TinhThanhTien()
        {
            decimal thanhTien = (100 - nmrGiamGia.Value) / 100 * nmrDonGia.Value * nmrSoLuong.Value;
            nmrThanhTien.Value = thanhTien;
        }

        private void nmrSoLuong_ValueChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void nmrDonGia_ValueChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void nmrGiamGia_ValueChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChiTietHoaDon.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var maHang = dgvChiTietHoaDon["MaHang", e.RowIndex].Value.ToString();
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Hỏi xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BHoaDon.XoaChiTietHoaDon(txtMaHoaDon.Text, maHang);
                    LoadHoaDon(txtMaHoaDon.Text);
                }
            }
        }

        public bool KiemTraDL()
        {
            if (!Functions.KiemTraDuLieuDauVao(pnNhapDL))
            {
                return false;
            }
            if (!Functions.KiemTraDuLieuDauVao(pnNhapDL2, "txtTongTien"))
            {
                return false;
            }
            var hang = (EHang)cboMaHang.SelectedItem;
            if ((decimal)hang.SoLuong < nmrSoLuong.Value)
            {
                MessageBox.Show($"Không có đủ số lượng. Chỉ còn {hang.SoLuong} hàng để bán.", "Thông báo");
                return false;
            }
            return true;
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (KiemTraDL())
            {
                var hd = GetHD();
                BHoaDon.ThemHoaDon(hd);
                var ct = GetCTHDBan();
                BHoaDon.ThemChiTietHoaDon(ct);
                btnThem.Enabled = false;
                btnLuuHoaDon.Enabled = true;
                btnHuyHoaDon.Enabled = true;
                btnInHoaDon.Enabled = true;
                LoadHoaDon(txtMaHoaDon.Text);
            }
        }

        private EHDBan GetHD()
        {
            return new EHDBan()
            {
                MaHDBan = txtMaHoaDon.Text.Trim(),
                MaNhanVien = cboMaNhanVien.Text.Trim(),
                MaKhach = cboMaKhach.Text.Trim(),
                NgayBan = dpkNgayBan.Value,
                TongTien = 0
            };
        }

        private EChiTietHDBan GetCTHDBan()
        {
            return new EChiTietHDBan()
            {
                MaHDBan = txtMaHoaDon.Text.Trim(),
                MaHang = cboMaHang.Text.Trim(),
                SoLuong = (float)nmrSoLuong.Value,
                DonGia = (float)nmrDonGia.Value,
                GiamGia = (float)nmrGiamGia.Value,
                ThanhTien = (float)nmrThanhTien.Value,
            };
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadHoaDon(cboMaHoaDonTimKiem.Text);
        }

        private void dgvChiTietHoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChiTietHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu");
                return;
            }
            if (dgvChiTietHoaDon.SelectedRows.Count == 0)
            {
                return;
            }

            var seleted = dgvChiTietHoaDon.SelectedRows[0];
            cboMaHang.Text = seleted.Cells["MaHang"].Value.ToString();
            txtTenHang.Text = seleted.Cells["TenHang"].Value.ToString();
            nmrSoLuong.Value = int.Parse(seleted.Cells["SoLuong"].Value.ToString());
            nmrDonGia.Value = int.Parse(seleted.Cells["DonGia"].Value.ToString());
            nmrGiamGia.Value = int.Parse(seleted.Cells["GiamGia"].Value.ToString());
            nmrThanhTien.Value = int.Parse(seleted.Cells["ThanhTien"].Value.ToString());
        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            var maHD = txtMaHoaDon.Text;
            BHoaDon.XoaHoaDon(maHD);
            btnThem.Enabled = true;
            btnHuyHoaDon.Enabled = btnLuuHoaDon.Enabled = btnInHoaDon.Enabled = false;
            Functions.ResetValue(this);
            dgvChiTietHoaDon.Rows.Clear();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            var hd = BHoaDon.LayHoaDon(txtMaHoaDon.Text);
            var dsChiTietHD = DataAccess.ConvertToList<EChiTietHDBan>(BHoaDon.LayDanhSachChiTiet(txtMaHoaDon.Text));

            ComExcel.Application exApp = new ComExcel.Application();
            ComExcel.Workbook exBook = exApp.Workbooks.Add(ComExcel.XlWBATemplate.xlWBATWorksheet);
            ComExcel.Worksheet exSheet = exBook.Worksheets[1];
            exSheet.Name = "Hoa don nhap";

            //dinh dang chung
            ComExcel.Range exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Time new roman";
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.Color = Color.Blue;

            exRange.Range["A1:a1"].ColumnWidth = 15;
            exRange.Range["b1:b1"].ColumnWidth = 15;
            exRange.Range["a1:b1"].MergeCells = true;
            exRange.Range["a1:b1"].HorizontalAlignment = ComExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["a1:b1"].Value = "Shop B.A.";

            exRange.Range["a2:b2"].MergeCells = true;
            exRange.Range["a2:b2"].HorizontalAlignment = ComExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["a2:b2"].Value = "Thuy Nguyen - Hai Phong";

            exRange.Range["a3:b3"].MergeCells = true;
            exRange.Range["a3:b3"].HorizontalAlignment = ComExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["a3:b3"].Value = "Dien thoai: 04 38526419";

            exRange.Range["c2:e2"].Font.Size = 16;
            exRange.Range["c2:e2"].Font.Bold = true;
            exRange.Range["c2:e2"].Font.Color = Color.Red;
            exRange.Range["c2:e2"].MergeCells = true;
            exRange.Range["c2:e2"].HorizontalAlignment = ComExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["c2:e2"].Value = "HOA DON BAN";

            exRange.Range["b6:c9"].Font.Size = 12;
            exRange.Range["b6:b6"].Value = "Ma hoa don: ";
            exRange.Range["c6:e6"].MergeCells = true;
            exRange.Range["c6:e6"].Value = hd.MaHDBan;
            exRange.Range["b7:b7"].Value = "Khach hang: ";
            exRange.Range["c7:e7"].MergeCells = true;
            exRange.Range["c7:e7"].Value = hd.TenKhach;
            exRange.Range["b8:b8"].Value = "Dia chi:";
            exRange.Range["c8:e8"].MergeCells = true;
            exRange.Range["c8:e8"].Value = hd.DiaChi;
            exRange.Range["b9:b9"].Value = "Dien thoai: ";
            exRange.Range["c9:e9"].MergeCells = true;
            exRange.Range["c9:e9"].NumberFormat = "@";
            exRange.Range["c9:e9"].Value = hd.DienThoai;

            exRange.Range["a11:f11"].Font.Bold = true;
            exRange.Range["a11:f11"].HorizontalAlignment = ComExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["c11:f11"].ColumnWidth = 12;

            ComExcel.Borders borders = exRange.Range[$"a11:f{11 + dsChiTietHD.Count }"].Borders;
            borders.LineStyle = ComExcel.XlLineStyle.xlContinuous;
            exRange.Range["a11:a11"].Value = "STT";
            exRange.Range[$"a11:a{12 + dsChiTietHD.Count - 1}"].HorizontalAlignment = ComExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["b11:b11"].Value = "Ten hang";
            exRange.Range["c11:c11"].Value = "So luong";
            exRange.Range[$"c11:c{12 + dsChiTietHD.Count - 1}"].HorizontalAlignment = ComExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["d11:d11"].Value = "Don gia";
            exRange.Range[$"d11:d{12 + dsChiTietHD.Count - 1}"].HorizontalAlignment = ComExcel.XlHAlign.xlHAlignRight;
            exRange.Range["e11:e11"].Value = "Giam gia";
            exRange.Range[$"e11:e{12 + dsChiTietHD.Count - 1}"].HorizontalAlignment = ComExcel.XlHAlign.xlHAlignRight;
            exRange.Range["f11:f11"].Value = "Thanh tien";
            exRange.Range[$"f11:f{12 + dsChiTietHD.Count - 1}"].HorizontalAlignment = ComExcel.XlHAlign.xlHAlignRight;

            int hang = 0, cot = 5;
            for (int i = 0; i < dsChiTietHD.Count; i++)
            {
                exSheet.Cells[1][hang + 12] = hang + 1;
                exSheet.Cells[2][hang + 12] = dsChiTietHD[i].TenHang;
                exSheet.Cells[3][hang + 12] = dsChiTietHD[i].SoLuong.ToString("N0");
                exSheet.Cells[4][hang + 12] = dsChiTietHD[i].DonGia.ToString("N0");
                exSheet.Cells[5][hang + 12] = dsChiTietHD[i].GiamGia + "%";
                exSheet.Cells[6][hang + 12] = dsChiTietHD[i].ThanhTien.ToString("N0");
                hang++;
            }

            exRange = exSheet.Cells[cot - 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tong tien:";
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Range["a1:b1"].MergeCells = true;
            exRange.Range["a1:b1"].Value = hd.TongTien.ToString("N0");

            exRange = exSheet.Cells[cot - 1][hang + 15];
            exRange.Font.Bold = true;
            exRange.Value2 = "Bang chu:";
            exRange = exSheet.Cells[cot][hang + 15];
            exRange.Font.Bold = true;
            exRange.Range["a1:b1"].MergeCells = true;
            exRange.Range["a1:b1"].Value = Functions.DocTienBangChu((long)hd.TongTien, " dong");
            exRange.HorizontalAlignment = ComExcel.XlHAlign.xlHAlignRight;

            exRange = exSheet.Cells[4][hang + 17];
            exRange.Range["a1:c1"].MergeCells = true;
            exRange.Range["a1:c1"].MergeCells = true;
            exRange.Range["a1:c1"].Font.Italic = true;
            exRange.Range["a1:c1"].HorizontalAlignment = ComExcel.XlHAlign.xlHAlignCenter;
            DateTime ngayHD = hd.NgayBan;
            exRange.Range["a1:c1"].Value = $"Hai Phong, ngay {ngayHD.Day} thang {ngayHD.Month} nam {ngayHD.Year}";

            exRange.Range["a2:c2"].MergeCells = true;
            exRange.Range["a2:c2"].Font.Italic = true;
            exRange.Range["a2:c2"].HorizontalAlignment = ComExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["a2:c2"].Value = "Nhan vien ban hang";

            exRange.Range["a6:c6"].MergeCells = true;
            exRange.Range["a6:c6"].Font.Italic = true;
            exRange.Range["a6:c6"].HorizontalAlignment = ComExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["a6:c6"].Value = hd.TenNhanVien;

            exApp.Visible = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}