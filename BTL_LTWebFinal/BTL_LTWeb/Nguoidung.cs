using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_LTWeb
{
    public class Nguoidung
    {
        string username;
        string password;
        string repassword;
        public Nguoidung(string username, string password, string repassword)
        {
            this.username = username;
            this.password = password;
            this.repassword = repassword;
        }
        public Nguoidung()
        {

        }
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public string PassWord
        {
            get { return password; }
            set { password = value; }
        }
        public string RePassWord
        {
            get { return repassword; }
            set { repassword = value; }
        }
    }
}