<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dangky.aspx.cs" Inherits="BTL_LTWeb.Dangky" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Style/HeaderAndFooter.css"/>
    <link rel="stylesheet" href="Style/Dangky.css" />
    <script src="https://kit.fontawesome.com/b1dd2c0aae.js" crossorigin="anonymous"></script>
</head>
<body>
   
        <header>
    <nav class="navbar">
        <a href="TrangChu.aspx"><img class="logo" src="Images/1200px-TikTok_logo.svg.png" alt="TikTok"></a>
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
        v<main class="border">
            <section>
                <div class="noi-dung">
                    <div class="form">
                        <form id="form1" runat="server" onsubmit="return valid()">
                            <div class="auth__header">
                                <h2>Đăng ký tài khoản</h2>
                                <button type="button" onclick="location.href='Dangnhap.aspx';" class="login-btn">Đăng nhập</button>
                            </div>
                            <div class="input-form">
                                <span>Tên đăng nhập</span>
                                <input type="text" id="username" name="username" placeholder="Nhập tên đăng nhập" />
                            </div>
                            <div class="input-form">
                                <span>Password</span>
                                <input type="password" id="password" name="password" placeholder="Nhập mật khẩu" />
                            </div>
                            <div class="input-form">
                                <span>Xác nhận Password</span>
                                <input type="password" id="repassword" name="repassword" placeholder="Nhập lại mật khẩu" />
                            </div>
                            <p runat="server" id="btn_error" style="color: red"></p>
                            <div class="input-form">
                                <input type="submit" value="Đăng ký" />
                            </div>
                        </form>
                    </div>
                </div>
            </section>
        </main>s
         <script src = "/Scripts/Dangky.js"></script>   
        

     
</body>
</html>
