<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="QL_BanVe.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Page</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.3.0/css/all.min.css" integrity="sha512-SzlrxWUlpfuzQ+pcUCosxcglQRNAq/DZjVsC0lE40xsADsfeQoEypE+enwcOiGjk/bSuGGKHEyjSoQ1zVisanQ==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <link rel="stylesheet" href="assets/css/adminPage.css" />
</head>
<body>
    <div class="adminPage_wrapper">
        <div class="adminPage_siderBar-wrapper">
            <div id="adminPage_siderBar" class="adminPage_siderBar">
                <a href="Admin.aspx" class="adminPage_logo">
                    <img src="assets/img/harry_potter_hoang_tu_lai.jpg" alt="logo" title="logo" class="adminPage_logo-img" />
                </a>
                <ul id="adminPage_siderBar-menu" class="adminPage_siderBar-menu">
                    <li class="adminPage_siderBar-menuItem active" onclick="itemMenuClick(event, 'dashboard')" title="Dashboard">
                        <i class="fa fa-chart-simple"></i> <span>Dashboard</span>
                    </li>
                    <li class="adminPage_siderBar-menuItem" onclick="itemMenuClick(event, 'movie')" title="Quản lý phim">
                        <i class="fa fa-film"></i><span>Quản lý phim</span>
                    </li>
                    <li class="adminPage_siderBar-menuItem" onclick="itemMenuClick(event, 'room')" title="Quản lý phòng chiếu">
                        <i class="fa fa-chair"></i><span>Quản lý phòng chiếu</span>
                    </li>
                    <li class="adminPage_siderBar-menuItem" onclick="itemMenuClick(event, 'category')" title="Quản lý thể loại">
                        <i class="fa fa-tag"></i><span>Quản lý thể loại</span>
                    </li>
                    <li class="adminPage_siderBar-menuItem" onclick="itemMenuClick(event, 'product')" title="Quản lý sản phẩm">
                        <i class="fa fa-gift"></i><span>Quản lý sản phẩm</span>
                    </li>
                    <li class="adminPage_siderBar-menuItem" onclick="itemMenuClick(event, 'users')" title="Quản lý tài khoản">
                        <i class="fa fa-users"></i><span>Quản lý tài khoản</span>
                    </li>
                </ul>
                <div class="adminPage_siderBar-collapse" onclick="siderBarCollapse(event)"><i class="fa fa-chevron-left"></i></div>
            </div>
        </div>
        <form id="form1" runat="server">
            <div class="adminPage_content">

            </div>
        </form>
    </div>
    <script>
        function itemMenuClick(event, page) {
            const menu = document.getElementById('adminPage_siderBar-menu');
            const element = event.target;
            if (!element || !menu) return;
            if (!element.classList.contains('active')) {
                for (let child of menu.children) {
                    child.classList.remove('active');
                }
                element.classList.add('active');
            }
        }

        function siderBarCollapse(event) {
            const siderBar = document.getElementById("adminPage_siderBar");
            const element = event.target.querySelector("i");
            element.classList.toggle("fa-chevron-left");
            element.classList.toggle("fa-chevron-right");

            siderBar.classList.toggle("collapsed");
        }
    </script>
</body>
</html>
