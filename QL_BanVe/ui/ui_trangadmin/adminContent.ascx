<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="adminContent.ascx.cs" Inherits="QL_BanVe.UI.UI_TrangAdmin.adminContent" %>

<div class="adminPage_content">
    <div class="adminPage_content-header">
        <h1 class="header_title"><asp:Literal runat="server" ID="adminPage_title"/></h1>
        <button class="btn btn-primary" type="button"><i class="fa fa-plus"></i>Thêm mới</button>
    </div>
    <div class="adminPage_content-control">
        <div class="wrapper_input">
            <asp:TextBox CssClass="input" runat="server" ID="inputKey"/>
            <asp:Label CssClass="text_desc" AssociatedControlID="inputKey" runat="server" ID="description" />
        </div>
        <button runat="server" id="btnSearch" class="btn btn-success"><i class="fa fa-search"></i>Tìm kiếm</button>
        <button type="button" class="btn btn-primary"><i class="fa fa-pencil"></i>Cập nhật</button>
        <button runat="server" type="button" id="btnDelete" class="btn btn-primary"><i class="fa fa-trash"></i>Xóa</button>
    </div>
    <div class="adminPage_content-table">
        <div class="table_wrapper">
            <table id="table_view" border="1" cellpadding="10">
                <thead runat="server" id="table_header" class="table_view-header"></thead>
                <tbody runat="server" id="table_body" class="table_view-body"></tbody>
            </table>
        </div>
        <div class="table_footer">
            <button runat="server" type="button" id="prevPage" class="btn"><i class="fa fa-chevron-left"></i>Trang trước</button>
            <asp:Literal runat="server" ID="pageControl">Page 1 of 1</asp:Literal>
            <button runat="server" type="button" id="nextPage" class="btn"><i class="fa fa-chevron-right"></i>Trang sau</button>
        </div>
    </div>
</div>

<div class="adminPage_modal">
    <div class="modal_overLay"></div>
    <div class="modal_content">
        <div class="modal_content-header">
            <h1 id="modal_header">Thêm mới</h1>
            <button type="button" class="btn btn_icon"><i class="fa fa-close"></i></button>
        </div>
        <div class="modal_content-body" id="modal_body">

        </div>
        <div class="modal_content-footer">
            <button type="button" class="btn btn-primary"><i class="fa fa-plus"></i>Thêm mới</button>
            <button type="button" class="btn"><i class="fa fa-close"></i>Hủy</button>
        </div>
    </div>
</div>

<script>
    const config = {
        movie: {
            fields: [
                {
                    label: "Tên phim",
                    required: true,
                    field: "sTenPhim",
                    type: "text"
                },
                {
                    label: "Thể loại",
                    required: true,
                    field: "FK_iTheLoaiID",
                    type: "number",
                    widget: "select",
                    getOptions: {
                        url: "/UI/UI_TrangAdmin/adminContent.ascx/getCategory",
                        save: "PK_iTheLoaiID",
                        view: "sTenTheLoai",
                        method: "GET"
                    }
                },
                {
                    label: "Ngày chiếu",
                    required: true,
                    field: "dNgayChieu",
                    type: "date",
                },
                {
                    label: "Giá",
                    required: true,
                    field: "fGia",
                    type: "number"
                },
                {
                    label: "Nội dung",
                    required: true,
                    field: "sNoiDung",
                    type: "text",
                    widget: "textarea"
                },
                {
                    label: "Thời lượng",
                    required: true,
                    field: "iThoiLuong",
                    type: "number"
                },
                {
                    label: "Ảnh",
                    required: true,
                    field: "sAnh",
                    type: "file",
                    accept: "image/*"
                },
                {
                    label: "Ảnh quảng cáo",
                    required: true,
                    field: "sAnhQuangCao",
                    type: "file",
                    accept: "image/*"
                },
                {
                    label: "Trailer",
                    required: true,
                    field: "sTrailer",
                    type: "file",
                    accept: "video/*"
                },
            ]
        }
    }
    function getPage() {
        const params = window.location.search;
        const paramsObject = new URLSearchParams(params);
        const page = paramsObject.get("page");
        return page;
    }

    function showModal() {
        let page = getPage();
        if (!page) return;
        const configPage = config[page];
        const fields = configPage.fields || [];
        for (let field of fields) {
            const div = document.createElement('div');
            div.className = "item_form"
            if (field.widget) {

            }
        }
    }

    function createWidgetElement(config) {
        let widget = config.widget || "";
        const element = "";
        switch (widget) {
            case "select":
                element = document.createElement("select");
                if (config.options && config.options.length > 0) {
                    for (let { label, value } of options) {
                        if (!label || !value) continue;
                        const option = document.createElement("option");
                        option.value = value;
                        option.label = label;
                    }
                } else if (config.getOptions?.url) {
                    const result = request(config.getOptions.url, config.getOptions.body, config.getOptions.method);
                    console.log(result);
                }
                break;
            case "textarea":
                element = document.createElement("textarea");
                break;
            default:
                element = document.createElement("input");
                break;
        }
    }

</script>
