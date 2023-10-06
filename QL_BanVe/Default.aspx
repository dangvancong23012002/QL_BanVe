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
                                <li><a href="#" class="nav__link">Lịch sử</a></li>
                                
                            </ul>
                            <%--<span class="nav__link" id="username" runat="server"></span>--%>
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
        <%-- footer --%>
        <footer class="footer ">
            <div class="footer-container ">
                <div class="grid wide ">
                    <div class="footer-wrap row ">
                        <div class="footer-padd l-4 m-12 c-12 ">
                            <div class="row">
                                <div class="footer-padd c-12">
                                    <h2 class="footer-content-header ">Giới thiệu</h2>
                                    <p class="footer-content-text ">
                                        Betas Cinemas trang mua vé trực tuyến của thương hiệu thời Cinemas, vé chiếu theo khung giờ, vé chiếu theo lượt xem, phụ kiện, giúp bạn tiếp cận xu hướng thời trang mới nhất.
                                    </p>
                                </div>
                            </div>
                        </div>

                        <div class="footer-padd l-8 m-12 c-12 ">
                            <div class="row ">
                                <div class="footer-content footer-padd l-4 m-12 c-12 ">
                                    <h2 class="footer-content-header ">Thông tin liên hệ</h2>
                                    <div class=" footer-contact ">
                                        <ul>
                                            <li class="contact-1 "><i class='bx bxs-map'></i>Tầng 4, tòa nhà Flemington, số 182, đường Lê Đại Hành, phường 15, quận 11, Tp. Hồ Chí Minh.</li>
                                            <li class="contact-2 "><i class='bx bxs-phone-call'></i>1900.636.099</li>
                                            <li class="contact-4 "><i class='bx bxl-gmail'></i>hi@haravan.com</li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="footer-content footer-padd l-4 m-12 c-12 ">
                                    <h2 class="footer-content-header ">Liên kết</h2>
                                    <div class=" toggle-footer ">
                                        <ul>

                                            <li class="item ">
                                                <a href=" " title="Sản phẩm khuyến mãi ">Sản phẩm khuyến mãi</a>
                                            </li>

                                            <li class="item ">
                                                <a href=" " title="Sản phẩm nổi bật ">Sản phẩm nổi bật</a>
                                            </li>

                                            <li class="item ">
                                                <a href=" " title="Tất cả sản phẩm ">Tất cả sản phẩm</a>
                                            </li>

                                        </ul>
                                    </div>
                                </div>
                                <div class="footer-content footer-padd l-4 m-12 c-12 ">
                                    <h2 class="footer-content-header ">Hỗ trợ</h2>
                                    <div class="footer-content toggle-footer ">
                                        <ul>

                                            <li class="item ">
                                                <a href="/search " title="Tìm kiếm ">Tìm kiếm</a>
                                            </li>

                                            <li class="item ">
                                                <a href="/pages/about-us " title="Giới thiệu ">Giới thiệu</a>
                                            </li>

                                            <li class="item ">
                                                <a href="/pages/chinh-sach-doi-tra " title="Chính sách đổi trả ">Chính sách đổi trả</a>
                                            </li>

                                            <li class="item ">
                                                <a href="/pages/chinh-sach-bao-mat " title="Chính sách bảo mật ">Chính sách bảo mật</a>
                                            </li>

                                            <li class="item ">
                                                <a href="/pages/dieu-khoan-dich-vu " title="Điều khoản dịch vụ ">Điều khoản dịch vụ</a>
                                            </li>

                                            <li class="item ">
                                                <a href="/pages/lien-he " title="Liên hệ ">Liên hệ</a>
                                            </li>

                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </footer>
    </form>
    <script src="assets/js/main.js"></script>
</body>
</html>
