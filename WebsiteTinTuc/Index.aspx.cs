using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteTinTuc
{
    public partial class Index : System.Web.UI.Page
    {
        private TinTucDataContext dt = new TinTucDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            rpChiTiet.DataSource = dt.ChiTiet_SelectHome();
            rpChiTiet.DataBind();
        }
    }
}