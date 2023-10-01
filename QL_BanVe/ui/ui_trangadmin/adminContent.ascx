<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="adminContent.ascx.cs" Inherits="QL_BanVe.UI.UI_TrangAdmin.adminContent" %>


<div class="adminPage_content">
    <div class="adminPage_content-header">
        <h1 class="header_title"><asp:Literal runat="server" ID="adminPage_title"/></h1>
        <button class="btn btn-primary" type="button"><i class="fa fa-plus"></i>Thêm mới</button>
    </div>
    <div class="adminPage_content-control">
        <div class="wrapper_input">
            <asp:TextBox CssClass="input" runat="server" ID="inputKey" />
            <asp:Label CssClass="text_desc" AssociatedControlID="inputKey" runat="server" ID="description" />
        </div>
        <button runat="server" type="button" id="btnSearch" class="btn btn-success"><i class="fa fa-search"></i>Tìm kiếm</button>
        <button type="button" class="btn btn-primary"><i class="fa fa-pencil"></i>Cập nhật</button>
        <button runat="server" type="button" id="btnDelete" class="btn btn-primary"><i class="fa fa-trash"></i>Xóa</button>
    </div>
    <div class="adminPage_content-table">
        <table id="table_view" border="1">
            <thead runat="server" id="table_header" class="table_view-header"></thead>
            <tbody runat="server" id="table_body"></tbody>
        </table>
        <div class="table_footer">
            <button runat="server" type="button" id="prevPage" class="btn"><i class="fa fa-chevron-left"></i>Trang trước</button>
            <asp:Literal runat="server" ID="pageControl">Page 1 of 1</asp:Literal>
            <button runat="server" type="button" id="nextPage" class="btn"><i class="fa fa-chevron-right"></i>Trang sau</button>
        </div>
    </div>
</div>