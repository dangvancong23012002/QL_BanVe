<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieDetail.aspx.cs" Inherits="QL_BanVe.MovieDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="assets/css/base.css" rel="stylesheet" />
    <link href="assets/css/grid.css" rel="stylesheet" />
    <link href="assets/css/styles.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v4.0.0/css/line.css" />
    <title>Chi tiết vé</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header class="header">
                <nav class="nav container">
                    <div class="nav__data">
                        <a href="#" class="nav__logo">Betas Cinemas
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
                                <li><div class="dropdown__item">
                                    <div class="nav__link">
                                        Tài khoản<i class="uil uil-angle-down dropdown__arrow"></i>
                                    </div>
                                    <ul class="dropdown__menu">
                                        <li>
                                            <a href="#" class="dropdown__link">Đăng ký</a>
                                        </li>
                                        <li>
                                            <a href="#" class="dropdown__link">Đăng nhập</a>
                                        </li>
                                    </ul>
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                </nav>
            </header>
            <main>
                <div class="grid wide">
                    <div class="detail">
                        <div class="detail__info" id="detail" runat="server">
                            
                        </div>
                        <div class="detail__room row-10px">
                            <div class="detail__room-tile">Chọn phòng chiếu phim</div>
                            <div class="row detail__seat-width">
                                <div class="col c-6">
                                    <div class="detail__room-input">
                                        <input type="checkbox" name="name" value="" /> Phòng 1   
                                    </div>
                                </div>
                                <div class="col c-6">
                                    <div class="detail__room-input">
                                        <input type="checkbox" name="name" value="" />
                                        Phòng 1   
                                    </div>
                                </div>
                                <div class="col c-6">
                                    <div class="detail__room-input">
                                        <input type="checkbox" name="name" value="" />
                                        Phòng 1   
                                    </div>
                                </div>
                                <div class="col c-6">
                                    <div class="detail__room-input">
                                        <input type="checkbox" name="name" value="" />
                                        Phòng 1   
                                    </div>
                                </div>
                                <div class="col c-6">
                                    <div class="detail__room-input">
                                        <input type="checkbox" name="name" value="" />
                                        Phòng 1   
                                    </div>
                                </div>
                                <div class="col c-6">
                                    <div class="detail__room-input">
                                        <input type="checkbox" name="name" value="" />
                                        Phòng 1   
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="detail__seat row-10px">
                            <div>Chọn ghế ngồi</div> 
                            <div class="detail__seat-width">
                                <div class="detai__seat-screen">
                                    <div>
                                        Màn hình chính <br />
                                        <div class="detai__seat-screen-box"></div>
                                    </div>
                                </div>
                                <div class="row detail__seat-row-gap">
                                    <div class="col l-2">
                                        <button class="detai__btn-seat">1</button>
                                    </div>
                                    <div class="col l-2">
                                        <button class="detai__btn-seat">2</button>
                                    </div>
                                    <div class="col l-2">
                                        <button class="detai__btn-seat">3</button>
                                    </div>
                                    <div class="col l-2">
                                        <button class="detai__btn-seat">4</button>
                                    </div>
                                    <div class="col l-2">
                                        <button class="detai__btn-seat">5</button>
                                    </div>
                                    <div class="col l-2">
                                        <button class="detai__btn-seat">6</button>
                                    </div>
                                    <div class="col l-2">
                                        <button class="detai__btn-seat">7</button>
                                    </div>
                                    <div class="col l-2">
                                        <button class="detai__btn-seat">8</button>
                                    </div>
                                    <div class="col l-2">
                                        <button class="detai__btn-seat">9</button>
                                    </div>
                                    <div class="col l-2">
                                        <button class="detai__btn-seat">10</button>
                                    </div>
                                    <div class="col l-2">
                                        <button class="detai__btn-seat">11</button>
                                    </div>
                                    <div class="col l-2">
                                        <button class="detai__btn-seat">12</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="detail__food row-10px">
                            Chọn đồ ăn/nước uống
                            <div class="row">
                                <div class="col l-12">
                                    <div class="row">
                                        <div class="col l-6">
                                            <div class="detail__food-name">Nước Sting</div>
                                            <div class="detail__food-price">10 000đ</div>
                                            <div class="detail__food-count">Hiện tại còn: 9</div>
                                        </div>
                                        <div class="col l-6">
                                            Số lượng
                                            <input type="text" name="name" value="" />
                                        </div>
                                    </div>
                                    
                                </div>
                                <div class="col l-12">
                                    <div class="row">
                                        <div class="col l-6">
                                            <div class="detail__food-name">Nước Sting</div>
                                            <div class="detail__food-price">10 000đ</div>
                                            <div class="detail__food-count">Hiện tại còn: 9</div>
                                        </div>
                                        <div class="col l-6">
                                            Số lượng
                                            <input type="text" name="name" value="" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </main>
            <footer class="footer ">
                <div class="footer-container ">
                    <div class="grid wide ">
                        <div class="footer-wrap row ">
                            <div class="footer-content col l-4 m-12 c-12 ">
                                <h2 class="footer-content-header ">Giới thiệu</h2>
                                <p class="footer-content-text ">
                                    Movies Online trang mua sắm trực tuyến của thương hiệu thời trang Lama, thời trang nam, nữ, phụ kiện, giúp bạn tiếp cận xu hướng thời trang mới nhất.
                                </p>
                            </div>
                            <div class="col l-8 m-12 c-12 ">
                                <div class="row ">
                                    <div class="footer-content col l-4 m-12 c-12 ">
                                        <h2 class="footer-content-header ">Thông tin liên hệ</h2>
                                        <div class=" footer-contact ">
                                            <ul>
                                                <li class="contact-1"><i class='bx bxs-map'></i>Tầng 4, tòa nhà Flemington, số 182, đường Lê Đại Hành, phường 15, quận 11, Tp. Hồ Chí Minh.</li>
                                                <li class="contact-2"><i class='bx bxs-phone-call'></i>1900.636.099</li>
                                                <li class="contact-4"><i class='bx bxl-gmail'></i>hi@haravan.com</li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class="footer-content col l-4 m-12 c-12 ">
                                        <h2 class="footer-content-header ">Liên kết</h2>
                                        <div class=" toggle-footer ">
                                            <ul>
                                                <li class="item ">
                                                    <a href="productAll.aspx" title="Sản phẩm khuyến mãi ">Sản phẩm khuyến mãi</a>
                                                </li>
                                                <li class="item ">
                                                    <a href="productAll.aspx" title="Sản phẩm nổi bật ">Sản phẩm nổi bật</a>
                                                </li>
                                                <li class="item ">
                                                    <a href="productAll.aspx" title="Tất cả sản phẩm ">Tất cả sản phẩm</a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class="footer-content col l-4 m-12 c-12 ">
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
        </div>
    </form>
    <script src="assets/js/main.js"></script>
</body>
</html>
