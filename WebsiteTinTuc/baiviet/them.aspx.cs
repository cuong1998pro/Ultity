using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteTinTuc.baiviet
{
    public partial class them : System.Web.UI.Page
    {
        private TinTucDataContext dt = new TinTucDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                drBanTin.DataSource = dt.BanTin_SelectAll();
                drBanTin.DataTextField = "NoiDung";
                drBanTin.DataValueField = "ID";
                drBanTin.DataBind();
            }
        }

        private bool KiemTra()
        {
            if (drBanTin.Text == "")
            {
                lblThongBao.Visible = true;
                lblThongBao.Text = "Bạn chưa chọn bản tin";
                drBanTin.Focus();
                return false;
            }
            if (txtTieuDe.Text == "")
            {
                lblThongBao.Visible = true;
                lblThongBao.Text = "Bạn chưa nhập tiêu đề";
                txtTieuDe.Focus();
                return false;
            }
            if (txtNoiDung.Text == "")
            {
                lblThongBao.Visible = true;
                lblThongBao.Text = "Bạn chưa nhập tiêu đề";
                txtNoiDung.Focus();
                return false;
            }
            return true;
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!KiemTra())
            {
                return;
            }
            var tieuDe = txtTieuDe.Text.Trim();
            var noiDung = txtNoiDung.Text;
            var idBanTin = int.Parse(drBanTin.SelectedValue);
            var ngayDang = DateTime.Now;
            dt.ChiTiet_Insert(tieuDe, noiDung, ngayDang, idBanTin);
            Response.Redirect("/index.aspx");
        }
    }
}