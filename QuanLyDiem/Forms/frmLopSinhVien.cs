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
    public partial class frmLopSinhVien : Form
    {
        private QuanLyDiemDataContext dt = new QuanLyDiemDataContext();

        public frmLopSinhVien()
        {
            InitializeComponent();
        }

        private void frmLopSinhVien_Load(object sender, EventArgs e)
        {
            txtMaLop.Enabled = false;
            txtMaSV.Enabled = false;
            cboChonLop.DataSource = dt.Lop_SelectAll();
            cboChonLop.DisplayMember = "MaLop";
            cboChonLop.ValueMember = "TenLop";
            Functions.Binding(txtMaLop, "Text", cboChonLop.DataSource, "MaLop");
            Functions.Binding(txtTenLop, "Text", cboChonLop.DataSource, "TenLop");
            dgvSinhVien.AutoGenerateColumns = false;
        }

        private bool addLop = false;

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            txtMaLop.Clear();
            txtMaLop.Enabled = true;
            txtTenLop.Clear();
            txtMaLop.Focus();
            addLop = true;
        }

        private void btnLuuLop_Click(object sender, EventArgs e)
        {
            var maLop = txtMaLop.Text.Trim();
            var tenLop = txtTenLop.Text.Trim();

            if (addLop)
            {
                dt.Lop_Insert(maLop, tenLop);
                addLop = false;
                txtMaLop.Enabled = false;
                frmLopSinhVien_Load(null, null);
                cboChonLop.Text = maLop;
            }
            else
            {
                dt.Lop_Update(maLop, tenLop);
                frmLopSinhVien_Load(null, null);
                cboChonLop.Text = maLop;
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            var maLop = txtMaLop.Text.Trim();
            dt.Lop_Delete(maLop);
            frmLopSinhVien_Load(null, null);
        }

        private void cboChonLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            var maLop = cboChonLop.Text;
            AddBindingToDataGridView(dt.SinhVien_SelectMaLop(maLop));
        }

        private void AddBindingToDataGridView(object dataSource)
        {
            dgvSinhVien.DataSource = dataSource;
            Functions.Binding(txtMaSV, "Text", dgvSinhVien.DataSource, "MaSV");
            Functions.Binding(txtHoTen, "Text", dgvSinhVien.DataSource, "HoTen");
            Functions.Binding(dpkNgaySinh, "Value", dgvSinhVien.DataSource, "NgaySinh");

            Binding bindingNam = new Binding("Checked", dgvSinhVien.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never);
            bindingNam.Format += new ConvertEventHandler(CheckNam);
            rdoGioiTinhNam.DataBindings.Clear();
            rdoGioiTinhNam.DataBindings.Add(bindingNam);

            Binding bindingNu = new Binding("Checked", dgvSinhVien.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never);
            bindingNu.Format += new ConvertEventHandler(CheckNu);
            rdoGioiTinhNu.DataBindings.Clear();
            rdoGioiTinhNu.DataBindings.Add(bindingNu);

            Functions.Binding(txtDanToc, "Text", dgvSinhVien.DataSource, "DanToc");
            Functions.Binding(txtNoiSinh, "Text", dgvSinhVien.DataSource, "NoiSinh");
        }

        private void CheckNu(object sender, ConvertEventArgs e)
        {
            e.Value = e.Value.ToString() == "Nữ";
        }

        private void CheckNam(object sender, ConvertEventArgs e)
        {
            e.Value = e.Value.ToString() == "Nam";
        }

        private void dgvSinhVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private bool addSV = false;

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDanToc.Clear();
            rdoGioiTinhNam.Checked = true;
            dpkNgaySinh.ResetText();
            txtNoiSinh.Clear();
            txtMaSV.Enabled = false;
            txtMaSV.Focus();
            addSV = true;
        }

        private void btnLuuSV_Click(object sender, EventArgs e)
        {
            var maSV = txtMaSV.Text.Trim();
            var hoTen = txtHoTen.Text.Trim();
            var gioiTinh = rdoGioiTinhNam.Checked ? "Nam" : "Nữ";
            var noiSinh = txtNoiSinh.Text.Trim();
            var ngaySinh = dpkNgaySinh.Value;
            var danToc = txtDanToc.Text.Trim();
            var maLop = txtMaLop.Text.Trim();
            if (addSV)
            {
                dt.SinhVien_Insert(maSV, hoTen, ngaySinh, gioiTinh, danToc, noiSinh, maLop);
                addSV = false;
                txtMaSV.Enabled = false;
                cboChonLop_SelectedIndexChanged(null, null);
            }
            else
            {
                dt.SinhVien_Update(maSV, hoTen, ngaySinh, gioiTinh, danToc, noiSinh, maLop);
                cboChonLop_SelectedIndexChanged(null, null);
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            dt.SinhVien_Delete(txtMaSV.Text);
        }

        private void txtTimSV_TextChanged(object sender, EventArgs e)
        {
            var hoTen = txtTimSV.Text;
            var maLop = txtMaLop.Text;
            AddBindingToDataGridView(dt.SinhVien_Search(hoTen, maLop));
        }
    }
}