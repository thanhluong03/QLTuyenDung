using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTWeb
{
    public partial class Userinfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string HTML = @"";

            List<Nguoidung> User = (List<Nguoidung>)Application["User"];
            List<Video> ListVideo = (List<Video>)Application["ListVieo"];
            foreach (Nguoidung user in User)
            {
               // dem++;
                HTML = @"<h1>" + Session["username"].ToString() + "</h1> <h3>" + Session["username"].ToString() + "</h3>";
                  // + "<h3> User" + dem + "<h3>";
            }
            test.InnerHtml = HTML;
            Session.Abandon();
           /* foreach (Video i in ListVideo)
            {
                video = @"<video>" + Session["video"].ToString() + "</video>";
            }
            listvideo.DataSource = ListVideo ;
            listvideo.DataBind();*/
        }
    }
}

