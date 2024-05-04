using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTWeb
{
    public partial class TrangVideoChiTiet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString.Get("id");

            if (id != null)
            {
                List<Video> video = (List<Video>)Application["ListVideo"];
                List<Video> vd = new List<Video>();
                foreach (Video i in video)
                {
                    if (id == i.Id)
                    {
                        vd.Add(i);

                    }
                    listvideo.DataSource = vd;
                    listvideo.DataBind();
                }
            }
            else
            {
                Response.Redirect("TrangChu.aspx");
            }
        }
    }
}