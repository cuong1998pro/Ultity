using QuanLyBanHang_Winform_Basic.Classes;
using QuanLyBanHang_Winform_Basic.Classes.BLL;
using QuanLyBanHang_Winform_Basic.Classes.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_Winform_Basic
{
    public partial class frmDanhMucHangHoa : Form
    {
        public frmDanhMucHangHoa()
        {
            InitializeComponent();
            dgvHangHoa.AutoGenerateColumns = false;
        }

        private void LoadGridView()
        {
            dgvHangHoa.DataSource = BHang.LayDanhSach();
        }

        private void frmDanhMucHangHoa_Load(object sender, EventArgs e)
        {
            LoadGridView();
            var dsChatLieu = BChatLieu.LayDanhSach();
            btnLuu.Enabled = btnBoQua.Enabled = false;
            Functions.LoadCombobox(dsChatLieu, cboChatLieu, "TenChatLieu", "MaChatLieu");
        }

        private void dgvHangHoa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Bảng không có dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnBoQua.Enabled = false;
                btnThem.Enabled = true;
                return;
            }
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnBoQua.Enabled = false;
                btnThem.Enabled = true;
                return;
            }
            if (dgv.SelectedRows.Count == 0)
            {
                return;
            }

            var selected = dgv.SelectedRows[0];

            txtMaHang.Text = selected.Cells[0].Value.ToString();
            txtTenHang.Text = selected.Cells[1].Value.ToString();
            cboChatLieu.Text = selected.Cells[2].Value.ToString();
            nmrSoLuong.Text = selected.Cells[3].Value.ToString();
            nmrDonGiaNhap.Text = selected.Cells[4].Value.ToString();
            nmrDonGiaXuat.Text = selected.Cells[5].Value.ToString();
            txtGhiChu.Text = selected.Cells[7].Value.ToString();
            txtAnh.Text = selected.Cells["Anh"].Value.ToString();
            try
            {
                picAnh.Image = Image.FromFile(selected.Cells["Anh"].Value.ToString());
            }
            catch
            {
                picAnh.Image = null;
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnBoQua.Enabled = true;
            Functions.ResetValue(this);
            txtTenHang.Focus();
            txtMaHang.Text = "H";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Functions.KiemTraDuLieuDauVao(pnNhapDL, "txtAnh"))
            {
                return;
            }
            EHang hang = GetHang();
            BHang.Them(hang);
            btnThem.Enabled = true;
            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnBoQua.Enabled = false;
            LoadGridView();
            Functions.ResetValue(this);
        }

        private EHang GetHang()
        {
            return new EHang()
            {
                MaHang = txtMaHang.Text.Trim(),
                TenHang = txtTenHang.Text.Trim(),
                MaChatLieu = cboChatLieu.SelectedValue.ToString(),
                SoLuong = (float)nmrSoLuong.Value,
                DonGiaBan = (float)nmrDonGiaNhap.Value,
                DonGiaNhap = (float)nmrDonGiaXuat.Value,
                Anh = txtAnh.Text.Trim(),
                GhiChu = txtGhiChu.Text.Trim(),
            };
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Hỏi xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var maHang = txtMaHang.Text;
                BHang.Xoa(maHang);
                LoadGridView();
                Functions.ResetValue(this);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Functions.KiemTraDuLieuDauVao(pnNhapDL))
            {
                var hangHoa = GetHang();
                BHang.Sua(hangHoa);
                LoadGridView();
                Functions.ResetValue(this);
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            Functions.ResetValue(this);
            txtTenHang.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadGridView();
            btnBoQua_Click(null, null);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var maHang = txtMaHang.Text;
            var tenHang = txtTenHang.Text;
            var maChatLieu = cboChatLieu.SelectedValue.ToString();
            dgvHangHoa.DataSource = BHang.TimKiem(maHang, tenHang, maChatLieu);
            btnBoQua_Click(null, null);
        }
    }
}