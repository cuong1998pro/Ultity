using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteTinTuc.baiviet
{
    public partial class chi_tiet : System.Web.UI.Page
    {
        private TinTucDataContext dt = new TinTucDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request["id"]);
            int idBanTin = int.Parse(Request["idbantin"]);
            //tang so lan xem
            dt.ChiTiet_UpdateSoLanXem(id);
            var data = dt.ChiTiet_SelectID(id);
            rpBanTin.DataSource = data;
            rpBanTin.DataBind();
            rpChiTiet.DataSource = data;
            rpChiTiet.DataBind();
            rpRandom.DataSource = dt.ChiTiet_SelectRandom(idBanTin);
            rpRandom.DataBind();
        }
    }
}