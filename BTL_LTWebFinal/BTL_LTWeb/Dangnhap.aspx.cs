using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTWeb
{
    public partial class Dangnhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                List<Nguoidung> User = (List<Nguoidung>)Application["User"];
                string usernamedn = Request.Form["userdn"];
                string passworddn = Request.Form["passworddn"];
              //  string solansai = Request.Form["btn_error"];
                int dem = 0;
                int check = 0;
                int a = 0;
                int b = 0;
                int c = 0;
                if (usernamedn != "" && passworddn != "")
                {
                    for (int i = 0; i < passworddn.Length; i++)
                    {
                        if (passworddn[i] >= 'a' && passworddn[i] <= 'z')
                        {
                            c++;
                        }
                        if (passworddn[i] >= 'A' && passworddn[i] <= 'Z')
                        {
                            a++;
                        }
                        if (passworddn[i] >= '0' && passworddn[i] <= '9')
                        {
                            b++;
                        }
                    }
                    if (c == 0)
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
                        foreach (Nguoidung user in User)
                        {
                            if (usernamedn == user.UserName)
                            {
                                dem = 1;
                                //check = 1;

                                if (passworddn == user.PassWord)
                                {

                                    Session["username"] = usernamedn;
                                    Response.Redirect("HomeUserLogined.aspx");
                                    break;
                                }
                                else
                                {
                                    btn_error.InnerHtml = "Sai mật khẩu";
                                    continue;
                                }
                            }
                            if (dem == 0)
                            {
                                btn_error.InnerHtml = "Không tồn tại tài khoản ";
                            }
                        }
                    }
                  

                }
            }

        }
    }
}