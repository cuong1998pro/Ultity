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
    public partial class frmMonDiemHP : Form
    {
        public frmMonDiemHP()
        {
            InitializeComponent();
        }

        private QuanLyDiemDataContext dt = new QuanLyDiemDataContext();
        private bool addHocKy = false, addMon = false;

        private void btnThemHocKy_Click(object sender, EventArgs e)
        {
            txtMaHocKy.Clear();
            txtMaHocKy.Enabled = true;
            txtMaHocKy.Focus();
            txtTenHocKy.Clear();
            addHocKy = true;
        }

        private void btnLuuHocKy_Click(object sender, EventArgs e)
        {
            var maHocKy = txtMaHocKy.Text.Trim();
            var tenHocKy = txtTenHocKy.Text.Trim();
            if (addHocKy)
            {
                dt.HocKy_Insert(maHocKy, tenHocKy);
                addHocKy = false;
                txtMaHocKy.Enabled = false;
                frmMonDiemHP_Load(null, null);
                cboChonHocKy.Text = maHocKy;
            }
            else
            {
                dt.HocKy_Update(maHocKy, tenHocKy);
                frmMonDiemHP_Load(null, null);
                cboChonHocKy.Text = maHocKy;
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            dt.HocKy_Delete(txtMaHocKy.Text);
            frmMonDiemHP_Load(null, null);
        }

        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            txtMaMon.Clear();
            txtMaMon.Enabled = true;
            txtMaMon.Focus();
            txtTenMon.Clear();
            txtSoTinChi.Clear();
            addMon = true;
        }

        private void cboChonHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMonHoc.DataSource = dt.MonHP_SelectMaHocKy(cboChonHocKy.Text);
            cboMonHoc.DisplayMember = "MaMon";
            cboMonHoc.ValueMember = "MaMon";
            Functions.Binding(txtMaMon, "Text", cboMonHoc.DataSource, "MaMon");
            Functions.Binding(txtTenMon, "Text", cboMonHoc.DataSource, "TenMon");
            Functions.Binding(txtSoTinChi, "Text", cboMonHoc.DataSource, "SoTinChi");
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var maLop = cboChonLop.Text;
            var maMon = txtMaMon.Text;
            dt.DiemHP_Init(maMon, maLop);
            dgvBangDiem.DataSource = dt.BangDiemHP(maLop, maMon);
        }

        private void btnLuuMonHoc_Click(object sender, EventArgs e)
        {
            var maMon = txtMaMon.Text.Trim();
            var tenMon = txtTenMon.Text.Trim();
            var soTinChi = int.Parse(txtSoTinChi.Text.Trim());
            var maHocKy = txtMaHocKy.Text.Trim();
            if (addMon)
            {
                dt.MonHP_Insert(maMon, tenMon, soTinChi, maHocKy);
                txtMaMon.Enabled = false;
                addMon = false;
                cboChonHocKy_SelectedIndexChanged(null, null);
                cboMonHoc.Text = maMon;
            }
            else
            {
                dt.MonHP_Update(maMon, tenMon, soTinChi, maHocKy);
                cboChonHocKy_SelectedIndexChanged(null, null);
                cboMonHoc.Text = maMon;
            }
        }

        private void btnXoaMonHoc_Click(object sender, EventArgs e)
        {
            dt.MonHP_Delete(txtMaMon.Text);
            cboChonHocKy_SelectedIndexChanged(null, null);
        }

        private void cboChonLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMonHoc_SelectedIndexChanged(null, null);
        }

        private void dgvBangDiem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvBangDiem.Rows[e.RowIndex];
            if (row.Cells["DiemLan1"].Value.ToString() != string.Empty)
            {
                var maMon = txtMaMon.Text.Trim();
                var maSV = row.Cells["MaSV"].Value.ToString();
                float diemLan1 = float.Parse(row.Cells["DiemLan1"].Value.ToString());
                dt.DiemHP_UpdateDiemLan1(maSV, maMon, diemLan1);
            }

            if (row.Cells["DiemLan2"].Value.ToString() != string.Empty)
            {
                var maMon = txtMaMon.Text.Trim();
                var maSV = row.Cells["MaSV"].Value.ToString();
                float diemLan2 = float.Parse(row.Cells["DiemLan2"].Value.ToString());
                dt.DiemHP_UpdateDiemLan2(maSV, maMon, diemLan2);
            }
        }

        private void frmMonDiemHP_Load(object sender, EventArgs e)
        {
            cboChonLop.DataSource = dt.Lop_SelectAll();
            cboChonLop.DisplayMember = "MaLop";
            cboChonLop.ValueMember = "MaLop";
            cboChonHocKy.DataSource = dt.HocKy_SelectAll();
            cboChonHocKy.DisplayMember = "MaHocKy";
            cboChonHocKy.ValueMember = "MaHocKy";

            Functions.Binding(txtMaHocKy, "Text", cboChonHocKy.DataSource, "MaHocKy");
            Functions.Binding(txtTenHocKy, "Text", cboChonHocKy.DataSource, "TenHocKy");
            txtMaHocKy.Enabled = txtMaMon.Enabled = false;
        }
    }
}