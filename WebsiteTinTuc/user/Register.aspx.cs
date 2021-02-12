using System;

namespace WebsiteTinTuc
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private TinTucDataContext dt = new TinTucDataContext();

        private bool KiemTra()
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtNhapLai.Text == "")
            {
                lblThongBao.Text = "Đăng ký thất bại. Mời bạn nhập đủ dữ liệu.";
                txtPassword.Text = txtNhapLai.Text = "";
                txtUsername.Focus();
                return false;
            }
            if (txtPassword.Text != txtNhapLai.Text)
            {
                lblThongBao.Text = "Mật khẩu xác nhận không đúng.";
                txtPassword.Text = txtNhapLai.Text = "";
                txtUsername.Focus();
                return false;
            }
            return true;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (!KiemTra()) return;
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text;
            dt.DangNhap_Insert(username, password);
        }
    }
}