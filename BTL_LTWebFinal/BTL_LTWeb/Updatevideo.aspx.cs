using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTWeb
{
    public partial class Updatevideo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filevideo = Request.Form["txtfile"];
            
            List<Video> video = (List<Video>)Application["ListVideo"];
            Video vd = new Video();
            int check = 0;
            if (IsPostBack)
            {
                foreach (Video i in video)
                {
                    if(filevideo == i.video)
                    {
                        Response.Write("<script>alert('Trùng video !');</script>");
                        check = 1;
                    }
                }
                if (check == 0)
                {
                    vd.video = filevideo;
                    Session["video"] = filevideo;

                    video.Add(vd);
                    Application["ListVideo"] = video;
                    Response.Write("<script>alert('Update video thành công !');</script>");
                }
            }
           
        }
    }
}