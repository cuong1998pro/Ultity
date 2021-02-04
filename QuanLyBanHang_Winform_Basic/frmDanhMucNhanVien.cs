using QuanLyBanHang_Winform_Basic.Classes;
using QuanLyBanHang_Winform_Basic.Classes.BLL;
using QuanLyBanHang_Winform_Basic.Classes.DTO;
using System;
using System.Windows.Forms;

namespace QuanLyBanHang_Winform_Basic
{
    public partial class frmDanhMucNhanVien : Form
    {
        public frmDanhMucNhanVien()
        {
            InitializeComponent();
        }

        private void frmDanhMucNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dgvNhanVien.DataSource = BNhanVien.LayDanhSach();
        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhanVien.Focus();
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

            txtMaNhanVien.Text = selectedrow.Cells[0].Value.ToString();
            txtTenNhanVien.Text = selectedrow.Cells[1].Value.ToString();
            radioButton1.Checked = selectedrow.Cells[2].Value.ToString() == "Nam";
            radioButton2.Checked = selectedrow.Cells[2].Value.ToString() == "Nữ";
            txtDiaChi.Text = selectedrow.Cells[3].Value.ToString();
            mtxtDienThoai.Text = selectedrow.Cells[4].Value.ToString();
            dtpNgaySinh.Text = selectedrow.Cells[5].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            Functions.ResetValue(this);
            txtTenNhanVien.Focus();
            txtMaNhanVien.Text = "NV";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Hỏi xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                BNhanVien.Xoa(txtMaNhanVien.Text);
                LoadDataGridView();
                Functions.ResetValue(this);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!Functions.KiemTraDuLieuDauVao(pnNhapDL))
            {
                return;
            }
            BNhanVien.Sua(GetNhanVien());

            LoadDataGridView();
            Functions.ResetValue(this);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Functions.KiemTraDuLieuDauVao(pnNhapDL))
            {
                return;
            }

            BNhanVien.Them(GetNhanVien());
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            Functions.ResetValue(this);
            LoadDataGridView();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            Functions.ResetValue(this);
            txtTenNhanVien.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private ENhanVien GetNhanVien()
        {
            return new ENhanVien()
            {
                MaNhanVien = txtMaNhanVien.Text,
                TenNhanVien = txtTenNhanVien.Text.Trim(),
                GioiTinh = radioButton1.Checked ? radioButton1.Text : radioButton2.Text,
                DiaChi = txtDiaChi.Text.Trim(),
                DienThoai = mtxtDienThoai.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value
            };
        }
    }
}