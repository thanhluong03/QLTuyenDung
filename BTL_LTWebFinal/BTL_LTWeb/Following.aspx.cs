using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTWeb
{
    public partial class Following : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["username"] != null)
            {
                int soluot = Convert.ToInt32(Application["sofollow"]);

                if (Request.Cookies["follow"] != null)
                {
                    List<Video> followList = new List<Video>();
                    List<Video> taikhoanList = (List<Video>)Application["ListVideo"];
                    string[] TksID = Request.Cookies["follow"].Value.Split(',');
                    foreach (string i in TksID)
                    {
                        foreach (Video product in taikhoanList)
                        {
                            if (product.Id == i)
                            {
                                soluot++;
                                followList.Add(product);

                            }
                        }
                        //sogiohang.InnerHtml = "<p> Số người follow  " + soluot +"</p>";
                    }
                    listfollow.DataSource = followList;
                    listfollow.DataBind();

                }
                else
                {
                    Response.Redirect("Trangchu.aspx");
                }
            }
            else
            {
                Response.Redirect("Dangnhap.aspx");
            }
        }
    }
}