using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTWeb
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Session.Abandon();
            Response.Redirect("~/Trangchu.aspx");
        }
       /* protected void dangxuat()
        {
            //xóa list
           /* List<Nguoidung> User = (List<Nguoidung>)Application["User"];
            User.RemoveAt(0);
            // Xóa session
            Session.Clear();

            // Xóa cookie
            HttpCookie loginCookie = Request.Cookies["Login"];
            if (loginCookie != null)
            {
                loginCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(loginCookie);
            }

            // Chuyển hướng về trang đăng nhập
            Response.Redirect("~/Trangchu.aspx");
        }*/
    }
}