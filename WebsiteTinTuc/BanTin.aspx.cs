using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteTinTuc
{
    public partial class BanTin1 : System.Web.UI.Page
    {
        private TinTucDataContext dt = new TinTucDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            var idBanTin = int.Parse(Request["idBanTin"]);
            rpBanTin.DataSource = dt.BanTin_SelectID(idBanTin);
            rpBanTin.DataBind();
            rpChiTiet.DataSource = dt.ChiTiet_SelectBanTin(idBanTin);
            rpChiTiet.DataBind();
        }
    }
}