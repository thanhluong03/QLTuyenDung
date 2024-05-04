using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTWeb
{
    public partial class TrangChu : System.Web.UI.Page
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
            listvideo.DataSource = video;
            listvideo.DataBind();
        }

    
    }
}