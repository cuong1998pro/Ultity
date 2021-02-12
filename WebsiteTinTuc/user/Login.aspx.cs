using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteTinTuc
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private TinTucDataContext dt = new TinTucDataContext();

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text;
            var dl = dt.DangNhap_Search(username, password);
            if (dl.Count() > 0)
            {
                Session["admin"] = true;
                Response.Redirect("/index.aspx");
            }
            else
            {
                lblThongBao.Text = "Đăng nhập thất bại. Mời bạn nhập lại !";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }
    }
}