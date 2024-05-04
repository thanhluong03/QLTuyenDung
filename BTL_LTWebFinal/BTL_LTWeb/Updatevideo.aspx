<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Updatevideo.aspx.cs" Inherits="BTL_LTWeb.Updatevideo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang tải video</title>
      <link rel="stylesheet" href="Style/HeaderAndFooter.css"/>
    <link rel="stylesheet" href="Style/Updatevideo.css"/>
    <script src="https://kit.fontawesome.com/b1dd2c0aae.js" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
    <header>
    <nav class="navbar">
        <a href ="HomeUserLogined.aspx"><img class="logo" src="Images/1200px-TikTok_logo.svg.png" alt="TikTok"/></a>

        <div class="search-bar">
            <input type="text" class="search-input" placeholder="Search accounts and videos"/>
            <button class="search-btn">
                <i class="fas fa-search"></i>
            </button>
        </div>
        <div class="nav-right">
            <button class="upload-btn">Upload</button>
            <a href="/Userinfo.aspx"><img style="zoom:10%" class="logo-login" src="/Images/loginico.png" alt="Login" /></a>
            <div class="drop-down">
                <i class="fas fa-ellipsis-v fa-lg"></i>
                <div class="menu hidden">
                    <ul>
                        <li>
                             <a href="/logout.aspx"><i class="fa-solid fa-right-from-bracket"></i>Đăng xuất</a>
                        </li>
                        <li>
                            <a href="#"><i class="fas fa-font fa-lg"></i>English</a>
                        </li>
                        <li>
                            <a href="#"><i class="far fa-question-circle fa-lg"></i>Feedback and help</a>
                        </li>
                        <li>
                            <a href="#"><i class="far fa-keyboard fa-lg"></i>Keyboard shortcuts</a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </nav>
   </header>

   <main>
        <section class="border">
            <div>
                <img src = "Images/dammaytaidl.png" width="40" height="40" alt="Ảnh">
                <p><b>Chọn video để tải lên</b></p> <br>
                <p>Tối đa 5 phút </p>
                <p>Nhỏ hơn 1GB</p>
            </div>
        <div class="update">
            <p>Chọn tập tin</p>
            <asp:FileUpload ID="txtfile" runat="server" />
                <button type ="submit"  >Update</button>
        </div>
        </section>
       
        
   </main>
        
        <script src="/Scripts/script.js"></script>
    </form>
</body>
</html>
