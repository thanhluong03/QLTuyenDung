using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTWeb
{
    public partial class HomeUserLogined : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Video> ListVideo = (List<Video>)Application["ListVideo"];
            List<Video> video = new List<Video>();

            foreach (Video i in ListVideo)
            {
                string id = i.Id;

                if (id == "1" || id == "2" || id == "3" || id == "4" || id == "5" || id == "6" || id == "7")
                {
                    video.Add(i);
                }
            }
            listvideo.DataSource = ListVideo;
            listvideo.DataBind();


        }
        protected void AddToFllowButton(object sender, EventArgs e)
        {

            if (Session["username"] != null)
            {
                string id = Request.QueryString.Get("id");
                //Store cart to cookies
                if (Request.Cookies["follow"] == null)
                {
                    Response.Cookies["follow"].Value = $"{id},";
                    Response.Cookies["follow"].Expires = DateTime.Now.AddDays(14);
                }
                else
                {

                    //Store cookies by productID, example: 1,2,3,40,50,... 
                    Response.Cookies["follow"].Value = Request.Cookies["follow"].Value + $"{id},";
                    Response.Cookies["follow"].Expires = DateTime.Now.AddDays(14);
                }
            }
            else
            {
                Response.Redirect("HomeUserLogined.aspx");
            }

        }
    }
}