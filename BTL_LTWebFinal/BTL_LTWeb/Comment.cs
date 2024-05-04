using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_LTWeb
{
    public class Comment
    {
        string username;
        string password;
        string tinnhan;
        string thoigian;

        public Comment(string username, string password, string tinnhan, string thoigian)
        {
            this.username = username;
            this.password = password;
            this.tinnhan = tinnhan;
            this.thoigian = thoigian;
        }
        public Comment()
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
        public string TinNhan
        {
            get { return tinnhan; }
            set { tinnhan = value; }
        }
        public string ThoiGian
        {
            get { return thoigian; }
            set { thoigian = value; }
        }
    }
}