using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTWeb
{
    public partial class Dangky : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                List<Nguoidung> User = (List<Nguoidung>)Application["User"];
                Nguoidung nd = new Nguoidung();

                string username = Request.Form["username"];
                string password = Request.Form["password"];
                string repassword = Request.Form["repassword"];
                int a = 0;
                int b = 0;
                int c = 0;
                int check = 0;
                foreach (Nguoidung i in User)
                {
                    if (i.UserName == username)
                    {
                        
                        btn_error.InnerHtml = "Đã tồn tại tài khoản";
                        check = 1;
                    }
                }

                if (repassword != password)
                {
                    btn_error.InnerHtml = "Xác nhận mật khẩu sai";
                    check = 1;
                }
                for (int i = 0; i < password.Length; i++)
                {
                    if (password[i] >= 'a' && password[i] <= 'z')
                    {
                        c++;
                    }
                    if (password[i] >= 'A' && password[i] <= 'Z')
                    {
                        a++;
                    }
                    if (password[i] >= '0' && password[i] <= '9')
                    {
                        b++;
                    }
                }
                if (c==0)
                {
                    btn_error.InnerHtml = "Mật khẩu phải có ít nhất 1 chữ thường";
                    check = 1;
                }
                if (a == 0)
                {
                    btn_error.InnerHtml = "Mật khẩu phải có ít nhất 1 chữ hoa";
                    check = 1;
                }
                if (b == 0)
                {
                    btn_error.InnerHtml = "Mật khẩu phải có ít nhất 1 chữ số";
                    check = 1;
                }
                if (check == 0)
                {
                    nd.UserName = username;
                    nd.PassWord = password;


                    Session["username"] = username;
                    Session["password"] = password;

                    User.Add(nd);
                    Application["User"] = User;
                    Response.Write("<script>alert('Đăng ký tài khoản thành công !');</script>");
                   
                }
            }

        }
    }
}