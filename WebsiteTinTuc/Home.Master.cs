using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteTinTuc
{
    public partial class Home : System.Web.UI.MasterPage
    {
        private TinTucDataContext dt = new TinTucDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            rpBanTin.DataSource = dt.BanTin_SelectAll();
            rpBanTin.DataBind();
        }
    }
}