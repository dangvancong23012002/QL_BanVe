<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="theSiderBar.ascx.cs" Inherits="QL_BanVe.UI.UI_TrangAdmin.theSiderBar" %>

<div id="adminPage_siderBar-wrapper" class="adminPage_siderBar-wrapper">
    <div class="adminPage_siderBar">
        <a href="Admin.aspx" class="adminPage_logo">
            <img src="assets/img/harry_potter_hoang_tu_lai.jpg" alt="logo" title="logo" class="adminPage_logo-img" />
        </a>
        <ul id="adminPage_siderBar-menu" class="adminPage_siderBar-menu">
            <li class="adminPage_siderBar-menuItem" id="item-movie" title="Quản lý phim">
                <a href="?page=movie">
                    <i class="fa fa-film"></i><span>Quản lý phim</span>
                </a>
            </li>
            <li class="adminPage_siderBar-menuItem" id="item-room" title="Quản lý phòng chiếu">
                <a href="?page=room">
                    <i class="fa fa-chair"></i><span>Quản lý phòng chiếu</span>
                </a>
            </li>
            <li class="adminPage_siderBar-menuItem" id="item-category" title="Quản lý thể loại">
                <a href="?page=category">
                    <i class="fa fa-tag"></i><span>Quản lý thể loại</span>
                </a>
            </li>
            <li class="adminPage_siderBar-menuItem" id="item-product" title="Quản lý sản phẩm">
                <a href="?page=product">
                    <i class="fa fa-gift"></i><span>Quản lý sản phẩm</span>
                </a>
            </li>
            <li class="adminPage_siderBar-menuItem" id="item-users" title="Quản lý tài khoản">
                <a href="?page=users">
                    <i class="fa fa-users"></i><span>Quản lý tài khoản</span>
                </a>
            </li>
        </ul>
        <div class="adminPage_siderBar-collapse" onclick="siderBarCollapse(event)"><i class="fa fa-chevron-left"></i></div>
    </div>
</div>

<script>

    document.addEventListener("DOMContentLoaded", () => {
        const params = window.location.search;
        const paramsObject = new URLSearchParams(params);
        const page = paramsObject.get("page");
        const menu = document.getElementById('adminPage_siderBar-menu');
        const element = document.getElementById(`item-${page}`);
        if (!element || !menu) return;
        if (!element.classList.contains('active')) {
            for (let child of menu.children) {
                child.classList.remove('active');
            }
            element.classList.add('active');
        }
    })

    function siderBarCollapse(event) {
        const siderBar = document.getElementById("adminPage_wrapper");
        const element = event.target.querySelector("i");
        element.classList.toggle("fa-chevron-left");
        element.classList.toggle("fa-chevron-right");

        siderBar.classList.toggle("collapsed");
    }
</script>