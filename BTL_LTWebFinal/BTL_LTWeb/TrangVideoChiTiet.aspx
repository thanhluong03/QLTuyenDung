    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrangVideoChiTiet.aspx.cs" Inherits="BTL_LTWeb.TrangVideoChiTiet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Style/Chitiet.css"/>
   
</head>
<body>
    <form id="form1" runat="server">
    <!--navigation end-->
    <!--video start-->
    <div class="container play-contain">
        <div class="row">
            <div class="play-vid">
                <asp:ListView ID="listvideo" runat="server">
                    <ItemTemplate>
                <video controls autoplay>
                    <source src="<%# Eval("video") %>" type="video/mp4"> 
                </video>
                <div class="tags">
                    <a href="">#anime</a>
                    <a href="">#hehe</a>
                    <a href="">#shinee</a>
                </div>
                <h3>Anime Thanh Gươm Diệt Qủy</h3>
                <div class="play-info">
                    <p>5k views &bull; 1 days ago</p>
                    <div>
                        <a href=""><img src="Images/like.png" alt="">2k</a>
                        <a href=""><img src="Images/dislike.png" alt="">159</a>
                        <a href=""><img src="Images/share.png" alt="">Share</a>
                        <a href=""><img src="Images/save.png" alt="">Save</a>
                    </div>
                </div>
                <hr>
                <div class="owner">
                    <img src="<%# Eval("images") %>" alt="">
                    <div>
                        <p><%# Eval("Name") %></p>
                        <span>1.2M Subscribers</span>
                    </div>
                    <button type="button">Subscribe</button>
                </div>
                        </ItemTemplate>
                    </asp:ListView>
                <div class="description">
                    <p>Anime hay và ý nghĩa</p>
                    <p>Subscribe To Our Channel </p>
                    <hr>
                    <h4>18 Comments</h4>
                    <div class="add-comment">
                        <img src="Images/ani.jpg" alt="">
                        <input type="text" placeholder="Write Comments">
                    </div>
                    <div class="prev-comnet">
                        <img src="Images/Cat.png" alt="">
                        <div>
                            <h3>Fliker Smith <span> 45 min ago</span></h3>
                            <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Molestiae quasi quod impedit, velit architecto similique ccusantium commodi, veritatis cumque id, velit doloremque ducimus eaque eos dignissimos animi perspiciatis ullam rerum eligendi. Autem.</p>
                            <div class="action">
                                <img src="Images/like.png" alt="">
                                <span>1522</span>
                                <img src="Images/dislike.png" alt="">
                                <span>52</span>
                                <span>Reply</span>
                                <a href="">All Replies</a>
                            </div>
                        </div>
                    </div>
                    <div class="prev-comnet">
                        <img src="Images/Gypsy.png" alt="">
                        <div>
                            <h3>Fliker Smith <span> 45 min ago</span></h3>
                            <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Molestiae quasi quod impedit, velit architecto similique ccusantium commodi, veritatis cumque id, velit doloremque ducimus eaque eos dignissimos animi perspiciatis ullam rerum eligendi. Autem.</p>
                            <div class="action">
                                <img src="Images/like.png" alt="">
                                <span>1522</span>
                                <img src="Images/dislike.png" alt="">
                                <span>52</span>
                                <span>Reply</span>
                                <a href="">All Replies</a>
                            </div>
                        </div>
                    </div>
                    <div class="prev-comnet">
                        <img src="Images/pirate.png" alt="">
                        <div>
                            <h3>Fliker Smith <span> 45 min ago</span></h3>
                            <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Molestiae quasi quod impedit, velit architecto similique ccusantium commodi, veritatis cumque id, velit doloremque ducimus eaque eos dignissimos animi perspiciatis ullam rerum eligendi. Autem.</p>
                            <div class="action">
                                <img src="Images/like.png" alt="">
                                <span>1522</span>
                                <img src="Images/dislike.png" alt="">
                                <span>52</span>
                                <span>Reply</span>
                                <a href="">All Replies</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="right-sidebar">
                <div class="side-list">
                    <a href="switch.html" class="small-size"><img src="Images/pirate.png" class="thumbnail" alt=""></a>
                    <div class="video-info">
                        <a href="switch.html">Anime</a>
                        <p>The Webfix</p>
                        <p>5k views &bull; 1 days</p>
                    </div>
                </div>
                <div class="side-list">
                    <a href="switch.html" class="small-size"><img src="Images/nami.png" class="thumbnail" alt=""></a>
                    <div class="video-info">
                        <a href="switch.html">Anime</a>
                        <p>The Webfix</p>
                        <p>5k views &bull; 1 days</p>
                    </div>
                </div>
                <div class="side-list">
                    <a href="switch.html" class="small-size"><img src="Images/Cat.png" class="thumbnail" alt=""></a>
                    <div class="video-info">
                        <a href="switch.html">Anime</a>
                        <p>The Webfix</p>
                        <p>5k views &bull; 1 days</p>
                    </div>
                </div>

                <div class="side-list">
                    <a href="switch.html" class="small-size"><img src="Images/ani.jpg" class="thumbnail" alt=""></a>
                    <div class="video-info">
                        <a href="switch.html">Anime</a>
                        <p>The Webfix</p>
                        <p>5k views &bull; 1 days</p>
                    </div>
                </div>
                <div class="side-list">
                    <a href="switch.html" class="small-size"><img src="Images/nami.png" class="thumbnail" alt=""></a>
                    <div class="video-info">
                        <a href="switch.html">Anime</a>
                        <p>The Webfix</p>
                        <p>5k views &bull; 1 days</p>
                    </div>
                </div>
                <div class="side-list">
                    <a href="switch.html" class="small-size"><img src="Images/Cat.png" class="thumbnail" alt=""></a>
                    <div class="video-info">
                        <a href="switch.html">Anime</a>
                        <p>The Webfix</p>
                        <p>5k views &bull; 1 days</p>
                    </div>
                </div>
                <div class="side-list">
                    <a href="switch.html" class="small-size"><img src="Images/nami.png" class="thumbnail" alt=""></a>
                    <div class="video-info">
                        <a href="switch.html">Anime</a>
                        <p>The Webfix</p>
                        <p>5k views &bull; 1 days</p>
                    </div>
                </div>
                <div class="side-list">
                    <a href="switch.html" class="small-size"><img src="Images/nami.png" class="thumbnail" alt=""></a>
                    <div class="video-info">
                        <a href="switch.html">Anime</a>
                        <p>The Webfix</p>
                        <p>5k views &bull; 1 days</p>
                    </div>
                </div>
                <div class="side-list">
                    <a href="switch.html" class="small-size"><img src="Images/nami.png" class="thumbnail" alt=""></a>
                    <div class="video-info">
                        <a href="switch.html">Anime</a>
                        <p>The Webfix</p>
                        <p>5k views &bull; 1 days</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--video end-->
    </form>
    <script>
        var menuIcon = document.querySelector(".menu");
        var sidebar = document.querySelector(".sidebar");
        var container = document.querySelector(".container");

        menuIcon.onclick = function () {
            sidebar.classList.toggle("small-sidebar");
            container.classList.toggle("large-container");
        }
    </script>
</body>
</html>
