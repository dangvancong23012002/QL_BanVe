<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QL_BanVe.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="assets/css/styles.css" rel="stylesheet" />
    <link href="assets/css/grid.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v4.0.0/css/line.css" />
    <title>Trang chủ</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header class="header">
                <nav class="nav container">
                    <div class="nav__data">
                        <a href="#" class="nav__logo">
                           Betas Cinemas
                        </a>
                        <div class="nav__toggle" id="nav-toggle">
                            <i class="uil uil-bars nav__burger"></i>
                            <i class="uil uil-times nav__close"></i>
                        </div>
                    </div>
                    <div class="nav__menu" id="nav-menu">
                        <div class="nav__function">
                            <div class="nav__search">
                                <input type="text" name="name" value="" placeholder="Tìm kiếm" />
                                <i class="uil uil-search"></i>
                            </div>
                            <ul class="nav__list">
                                <li><a href="#" class="nav__link">Thể loại</a></li>
                                <li><a href="#" class="nav__link">Tất cả</a></li>
                                <li><span class="nav__link" id="username" runat="server"></span></li>
                            </ul>
                        </div>
                    </div>
                </nav>
            </header>
            <main>
                <div class="grid wide">
                    <div class="card">
                        <div class="row sm-gutter list-film">
                                                  
                        </div>
                    </div>
                </div>
            </main>
        </div>
    </form>
    <script src="assets/js/main.js"></script>
</body>
</html>
