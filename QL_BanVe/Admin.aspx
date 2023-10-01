<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="QL_BanVe.Admin" %>

<%@ Register Src="~/UI/UI_TrangAdmin/adminContent.ascx" TagPrefix="admin" TagName="content" %>
<%@ Register Src="~/UI/UI_TrangAdmin/theSiderBar.ascx" TagPrefix="admin" TagName="siderBar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Page</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.3.0/css/all.min.css" integrity="sha512-SzlrxWUlpfuzQ+pcUCosxcglQRNAq/DZjVsC0lE40xsADsfeQoEypE+enwcOiGjk/bSuGGKHEyjSoQ1zVisanQ==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <link rel="stylesheet" href="assets/css/adminPage.css" />
    <script src="assets/js/request.js" type="text/javascript" defer></script>
</head>
<body>
    <div class="adminPage_wrapper" id="adminPage_wrapper">
        <admin:siderBar runat="server" ID="adminSideBar" />
        <form id="adminPage_content" runat="server">
            <div class="adminPage_content-wrapper">
                <admin:content runat="server" ID="adminContent" />
            </div>
        </form>
    </div>
</body>
</html>
