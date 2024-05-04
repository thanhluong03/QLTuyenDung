using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTWeb
{
    public partial class ListComment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Comment> cmt = (List<Comment>)Application["Comment"];
            if (cmt != null)
            {
                Nguoidung member = (Nguoidung)Session["Nguoidung"];

                foreach (Comment nd in cmt)
                {
                    if (nd.UserName == Convert.ToString(Session["username"]) && nd.PassWord == Convert.ToString(Session["password"]))
                    {
                        Response.Write($"<p {nd.UserName};text-align:right;'><span> {nd.UserName} :</span> {nd.TinNhan};text-align:right;font-size:8px'>{nd.ThoiGian} </span>  </p> ");

                    }
                    else
                    {
                        Response.Write($"<p {nd.UserName};text-align:left;'><span> {nd.UserName} :</span> {nd.TinNhan};text-align:right;font-size:8px'>{nd.ThoiGian} </span>  </p> ");

                    }
                }
            }
        }
    }
}