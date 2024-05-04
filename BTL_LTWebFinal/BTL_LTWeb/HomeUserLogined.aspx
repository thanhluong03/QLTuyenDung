<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeUserLogined.aspx.cs" Inherits="BTL_LTWeb.HomeUserLogined" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang chủ</title>
    <link rel="stylesheet" href="Style/HeaderAndFooter.css"/>
    <link rel="stylesheet" href="Style/TrangChu.css"/>
    <script src="https://kit.fontawesome.com/b1dd2c0aae.js" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form2" runat="server">
        <header>
            <nav class="navbar">
                <img class="logo" src="Images/1200px-TikTok_logo.svg.png" alt="TikTok"/>
                <div class="search-bar">
                    <input type="text" class="search-input" placeholder="Search accounts and videos"/>
                    <button class="search-btn">
                        <i class="fas fa-search"></i>
                    </button>
                </div>
                <div class="nav-right">
                    <button type="button" onclick="location.href='Updatevideo.aspx';" class="upload-btn">Upload</button>
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
        <div class="left">
            <div class="btns">
                <a href="HomeUserLogined.aspx"><i class="fas fa-home"></i><span>For You</span></a>
                <a href="/Following.aspx"><i class="fas fa-user-friends"></i><span>Following</span></a>
                <a href=""><i class="fas fa-video"></i><span>Live</span></a>
            </div>
            
            <div class="accounts">
                <p>Suggested accounts</p>
                <div class="user">
                    <img src="Images/Cat.png" alt="avartar"/>
                    <h6 class="username">Shinee</h6>
                </div>
                <div class="user">
                    <img src="Images/pirate.png" alt="avartar"/>
                    <h6 class="username">Luffy</h6>
                </div>
    
                <div class="user">
                    <img src="Images/nami.png" alt="avartar"/>
                    <h6 class="username">Nami</h6>
                </div>
                
                <div class="user">
                    <img src="Images/zoro.png" alt="avartar"/>
                    <h6 class="username">Zoro</h6>
                </div>
            </div>

            <div class="tags">
                <p>Discover</p>
                <div>
                    <a href="#"># tiktokcookbook</a>
                    <a href="#"># summeressentials</a>
                    <a href="#"># music</a>
                    <a href="#"># memories</a>
                    <a href="#"># whoisbetter</a>
                    <a href="#"># tiktokcookbook</a>
                    <a href="#"># summeressentials</a>
                    <a href="#"># music</a>
                    <a href="#"># memories</a>
                    <a href="#"># whoisbetter</a>
                </div>
            </div>

            <div class="links">
                <div>
                    <div class="link">
                        <a href="#">About</a>
                        <a href="#">Newsroom</a>
                        <a href="#">Contact</a>
                        <a href="#">Careears</a>
                        <a href="#">ByteDance</a>
                        <a href="#">About</a>
                        <a href="#">Newsroom</a>
                        <a href="#">Contact</a>
                        <a href="#">Careears</a>
                        <a href="#">ByteDance</a>
                    </div>
                    <div class="copyright">
                        <h6>&copy; 2023 TikTok</h6>
                    </div>
                </div>
            </div>


        </div>
       <div class="right">
            <asp:ListView ID="listvideo" runat="server">
                <ItemTemplate>
                    <div class="post">
                <div class="post-info">
                    <div class="user">
                        <img src="<%# Eval("images") %>" alt="avartar">
                        <div>
                            <h6><%# Eval("Name") %></h6>
                            <p><%# Eval("Detail") %></p>
                        </div>
                    </div>
                    
                    <button type="submit" runat="server" onserverclick="AddToFllowButton">Follow</button>
                </div>
                <div class="post-content">
                
                    <video autoplay muted controls loop disablepictureinpicture controlslist="nodownload noplaybackrate">
                        <source src="<%# Eval("video") %>">
                    </video>
                    <div class="video-icons">
                        <a href="#"><i class="fas fa-heart fa-lg"></i> <span>1.6k</span></a>
                        <a href="TrangVideoChiTiet.aspx?id=<%# Eval("Id") %>"><i class="fas fa-comment-dots fa-lg"></i><span>450</span></a>
                        <a href="#"><i class="fas fa-share fa-lg"></i><span>170</span></a>
                    </div>
                </div>
            </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
        </main>
            <script src="/Scripts/script.js"></script>
    </form>
</body>
</html>
