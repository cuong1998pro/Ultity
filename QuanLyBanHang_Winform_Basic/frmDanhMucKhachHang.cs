using QuanLyBanHang_Winform_Basic.Classes;
using QuanLyBanHang_Winform_Basic.Classes.BLL;
using QuanLyBanHang_Winform_Basic.Classes.DTO;
using System;
using System.Windows.Forms;

namespace QuanLyBanHang_Winform_Basic
{
    public partial class frmDanhMucKhachHang : Form
    {
        public frmDanhMucKhachHang()
        {
            InitializeComponent();
        }

        private void frmDanhMucKhachHang_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dgvKhachHang.DataSource = BKhachHang.LayDanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            Functions.ResetValue(this);
            txtMaKhach.Text = "KH";
            txtTenKhach.Focus();
        }

        private void dgvKhachHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhach.Focus();
                return;
            }
            var dgv = sender as DataGridView;
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Bảng không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgv.SelectedRows.Count == 0)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                return;
            }
            var selectedrow = dgv.SelectedRows[0];

            txtMaKhach.Text = selectedrow.Cells[0].Value.ToString();
            txtTenKhach.Text = selectedrow.Cells[1].Value.ToString();
            txtDiaChi.Text = selectedrow.Cells[2].Value.ToString();
            mtxtDienThoai.Text = selectedrow.Cells[3].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Functions.KiemTraDuLieuDauVao(pnNhapDL))
            {
                EKhachHang khachHang = GetKhachHang();
                BKhachHang.Sua(khachHang);
                LoadDataGridView();
                Functions.ResetValue(this);
            }
        }

        private EKhachHang GetKhachHang()
        {
            return new EKhachHang()
            {
                MaKhach = txtMaKhach.Text.Trim(),
                TenKhach = txtTenKhach.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                DienThoai = mtxtDienThoai.Text.Trim()
            };
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Hỏi xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var maKhach = txtMaKhach.Text;
                BKhachHang.Xoa(maKhach);
                LoadDataGridView();
                Functions.ResetValue(this);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Functions.KiemTraDuLieuDauVao(pnNhapDL))
            {
                var khachHang = GetKhachHang();
                BKhachHang.Them(khachHang);
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnBoQua.Enabled = false;
                LoadDataGridView();
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
            txtTenKhach.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}