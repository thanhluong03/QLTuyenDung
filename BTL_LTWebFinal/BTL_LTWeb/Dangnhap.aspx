<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dangnhap.aspx.cs" Inherits="BTL_LTWeb.Dangnhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Style/HeaderAndFooter.css"/>
    <link rel="stylesheet" href="Style/Dangnhap.css"/>
    <script src="https://kit.fontawesome.com/b1dd2c0aae.js" crossorigin="anonymous"></script>
   
</head>
<body>
   
   <header>
    <nav class="navbar">
        <a href="TrangChu.aspx"><img class="logo" src="Images/1200px-TikTok_logo.svg.png" alt="TikTok"/></a>
        <div class="search-bar">
            <input type="text" class="search-input" placeholder="Search accounts and videos"/>
            <button class="search-btn">
                <i class="fas fa-search"></i>
            </button>
        </div>
        <div class="nav-right">
            
            <button type="button" onclick="location.href='Dangnhap.aspx';" class="login-btn">Login</button>
           
        </div>
    </nav>
   </header>
        <main class="border">
            <section>
                <div class="noi-dung">
                  <form id="form1" runat="server"  onsubmit ="return valid()">
                    <div class="form">
                        <h2>Đăng nhập</h2>
                         <div class="input-form">
                            <span>Tên tài khoản</span>
                            <input type ="text" id ="userdn" name ="userdn" placeholder ="Nhập tài khoản" />
                        </div>
                        <div class="input-form">
                            <span>Password</span>
                            <input type ="password" id ="passworddn" name ="passworddn" placeholder="Nhập mật khẩu" />
                        </div>
                        <div class="input-form">
                            <input type="submit" id="dangnhap" onclick ="Dangnhap()" value="Đăng Nhập"/>
                        </div>
                        <p runat="server" id="btn_error" name ="btn_error" style="color:red"></p>
                        <div class="input-form">
                           <p>Bạn Chưa Có Tài Khoản? <a href="Dangky.aspx">Đăng Ký</a> hoặc dùng <a href="/HomeUserLogined.aspx"> Tài khoản khách </a></p>
                        </div>

                    </div>
                   </form>
                </div>
            </section>
        </main>
        <script src = "/Scripts/Dangnhap.js"></script>
</body>

</html>
