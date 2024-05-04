using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BTL_LTWeb
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["User"] = new List<Nguoidung>();
            List<Nguoidung> Users = (List<Nguoidung>)Application["User"];
            Users.Add(new Nguoidung("admin1", "1", "1"));

            Application["Comment"] = new List<Comment>();

            Application["ListVideo"] = new List<Video>();
            List<Video> ListVideo = new List<Video>();
            //Sản phẩm bán chạy
            ListVideo.Add(new Video() { Id = "1", images = "Images/Gypsy.png", video = "Images/video1.mp4", Name = "Gypsy", Detail = "Cool Video" });
            ListVideo.Add(new Video() { Id = "2", images = "Images/Cat.png", video = "Images/video2.mp4", Name = "Shinee", Detail = "Phân tử" });
            ListVideo.Add(new Video() { Id = "3", images = "Images/dammaytaidl.png", video = "Images/video3.mp4", Name = "Pirate", Detail = "Anime" });
            ListVideo.Add(new Video() { Id = "4", images = "Images/nami.png", video = "Images/video4.mp4", Name = "Sachi", Detail = "Trái đất" });
            ListVideo.Add(new Video() { Id = "5", images = "Images/pirate.png", video = "Images/video5.mp4", Name = "LyLy", Detail = "Hoạt hình" });
            ListVideo.Add(new Video() { Id = "6", images = "Images/zoro.png", video = "Images/video6.mp4", Name = "Lucky", Detail = "Đàn nhạc" });
            ListVideo.Add(new Video() { Id = "7", images = "Images/1200px-TikTok_logo.svg.png", video = "Images/video7.mp4", Name = "Nano", Detail = "Lung linh" });
            Application["ListVideo"] = ListVideo;

            Application["solansai"] = 1;
        }
        protected void Session_Start(object sender, EventArgs e)
        {
             Session["login"] = 0;
            Session["username"] = "";
            Session["password"] = "";
            Session["video"] = "";
        }
    }
}