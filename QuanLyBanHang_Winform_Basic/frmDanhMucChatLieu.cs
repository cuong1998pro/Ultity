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
    public partial class frmDanhMucChatLieu : Form
    {
        public frmDanhMucChatLieu()
        {
            InitializeComponent();
        }

        private void frmDanhMucChatLieu_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dgvChatLieu.DataSource = BChatLieu.LayDanhSach();
        }

        private void dgvChatLieu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenChatLieu.Focus();
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

            txtMaChatLieu.Text = selectedrow.Cells[0].Value.ToString();
            txtTenChatLieu.Text = selectedrow.Cells[1].Value.ToString();

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
            txtTenChatLieu.Focus();
            txtMaChatLieu.Text = "CL";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Functions.KiemTraDuLieuDauVao(pnNhapDL))
            {
                return;
            }
            var newChatLieu = new EChatLieu()
            {
                MaChatLieu = txtMaChatLieu.Text,
                TenChatLieu = txtTenChatLieu.Text.Trim()
            };
            BChatLieu.Them(newChatLieu);
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
            txtTenChatLieu.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!Functions.KiemTraDuLieuDauVao(pnNhapDL))
            {
                return;
            }
            EChatLieu chatLieu = new EChatLieu()
            {
                MaChatLieu = txtMaChatLieu.Text,
                TenChatLieu = txtTenChatLieu.Text.Trim()
            };
            BChatLieu.Sua(chatLieu);

            LoadDataGridView();
            Functions.ResetValue(this);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Hỏi xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                BChatLieu.Xoa(txtMaChatLieu.Text);
                LoadDataGridView();
                Functions.ResetValue(this);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}