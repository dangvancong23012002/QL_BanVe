<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QL_BanVe.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="assets/css/styles.css" rel="stylesheet" />
    <link href="assets/css/grid.css" rel="stylesheet" />
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
                        <div class="row sm-gutter">
                            <div class="col c-6 l-2-4">
                                <a href="MovieDetail.aspx" class="card__item">
                                    <div class="card__item-img" style="background-image: url(./assets/img/harry_potter_hoangtulai.jpg)"></div>
                                    <h4 class="card__item-name">Harry Potter và hoàng tử lai</h4>
                                    <div class="card__item-action">
                                        <span class="card__item-like">
                                            <i class="uil uil-heart"></i>
                                        </span>
                                        <div class="card__item-rating">
                                            <i class="uil uil-star card__item-rating-icon--gold"></i>
                                            <i class="uil uil-star"></i>
                                            <i class="uil uil-star"></i>
                                            <i class="uil uil-star"></i>
                                            <i class="uil uil-star"></i>
                                        </div>
                                        <span class="card__item-views">88 lượt xem</span>
                                    </div>
                                    <div class="card__item-date">12/8/2023</div>
                                </a>
                            </div>
                            <div class="col c-6 l-2-4">
                                <a href="MovieDetail.aspx" class="card__item">
                                    <div class="card__item-img" style="background-image: url(./assets/img/harry_potter_hoangtulai.jpg)"></div>
                                    <h4 class="card__item-name">Cướp biển vùng Caribean 1: Lời nguyền của tàu Ngọc Trai Đen</h4>
                                    <div class="card__item-action">
                                        <span class="card__item-like">
                                            <i class="uil uil-heart"></i>
                                        </span>
                                        <div class="card__item-rating">
                                            <i class="uil uil-star card__item-rating-icon--gold"></i>
                                            <i class="uil uil-star"></i>
                                            <i class="uil uil-star"></i>
                                            <i class="uil uil-star"></i>
                                            <i class="uil uil-star"></i>
                                        </div>
                                        <span class="card__item-views">88 lượt xem</span>
                                    </div>
                                    <div class="card__item-date">12/8/2023</div>
                                </a>
                            </div>
                            <div class="col c-6 l-2-4">
                                <a href="MovieDetail.aspx" class="card__item">
                                    <div class="card__item-img" style="background-image: url(./assets/img/harry_potter_hoangtulai.jpg)"></div>
                                    <h4 class="card__item-name">Thông báo Khảo sát áp dụng Chương trình đào tạo mới năm 2022 cho các khóa 1910A, 2010A, 2110A</h4>
                                    <div class="card__item-action">
                                        <span class="card__item-like">
                                            <i class="uil uil-heart"></i>
                                        </span>
                                        <div class="card__item-rating">
                                            <i class="uil uil-star card__item-rating-icon--gold"></i>
                                            <i class="uil uil-star"></i>
                                            <i class="uil uil-star"></i>
                                            <i class="uil uil-star"></i>
                                            <i class="uil uil-star"></i>
                                        </div>
                                        <span class="card__item-views">88 lượt xem</span>
                                    </div>
                                    <div class="card__item-date">12/8/2023</div>
                                </a>
                            </div>
                            <div class="col c-6 l-2-4">
                                <a href="MovieDetail.aspx" class="card__item">
                                    <div class="card__item-img" style="background-image: url(./assets/img/harry_potter_hoangtulai.jpg)"></div>
                                    <h4 class="card__item-name">Thông báo Khảo sát áp dụng Chương trình đào tạo mới năm 2022 cho các khóa 1910A, 2010A, 2110A</h4>
                                    <div class="card__item-action">
                                        <span class="card__item-like">
                                            <i class="uil uil-heart"></i>
                                        </span>
                                        <div class="card__item-rating">
                                            <i class="uil uil-star card__item-rating-icon--gold"></i>
                                            <i class="uil uil-star"></i>
                                            <i class="uil uil-star"></i>
                                            <i class="uil uil-star"></i>
                                            <i class="uil uil-star"></i>
                                        </div>
                                        <span class="card__item-views">88 lượt xem</span>
                                    </div>
                                    <div class="card__item-date">12/8/2023</div>
                                </a>
                            </div>
                            <div class="col c-6 l-2-4">
                                <a href="MovieDetail.aspx" class="card__item">
                                    <div class="card__item-img" style="background-image: url(./assets/img/harry_potter_hoangtulai.jpg)"></div>
                                    <h4 class="card__item-name">Thông báo Khảo sát áp dụng Chương trình đào tạo mới năm 2022 cho các khóa 1910A, 2010A, 2110A</h4>
                                    <div class="card__item-action">
                                        <span class="card__item-like">
                                            <i class="uil uil-heart"></i>
                                        </span>
                                        <div class="card__item-rating">
                                            <i class="uil uil-star card__item-rating-icon--gold"></i>
                                            <i class="uil uil-star"></i>
                                            <i class="uil uil-star"></i>
                                            <i class="uil uil-star"></i>
                                            <i class="uil uil-star"></i>
                                        </div>
                                        <span class="card__item-views">88 lượt xem</span>
                                    </div>
                                    <div class="card__item-date">12/8/2023</div>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </main>
        </div>
    </form>
    <script src="assets/js/main.js"></script>
</body>
</html>
