<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="adminContent.ascx.cs" Inherits="QL_BanVe.UI.UI_TrangAdmin.adminContent" %>

<div class="adminPage_content">
    <div class="adminPage_content-header">
        <h1 class="header_title"><asp:Literal runat="server" ID="adminPage_title"/></h1>
        <button class="btn btn-primary" type="button" onclick="showModal('create')"><i class="fa fa-plus"></i>Thêm mới</button>
    </div>
    <div class="adminPage_content-control">
        <div class="wrapper_input">
            <asp:TextBox CssClass="input" runat="server" ID="inputKey"/>
            <asp:Label CssClass="text_desc" AssociatedControlID="inputKey" runat="server" ID="description" />
        </div>
        <button runat="server" id="btnSearch" class="btn btn-success"><i class="fa fa-search"></i>Tìm kiếm</button>
        <button type="button" class="btn btn-primary" onclick="showModal('update')"><i class="fa fa-pencil"></i>Cập nhật</button>
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

<div class="adminPage_modal" id="adminContent_modal">
    <div class="modal_overLay"></div>
    <div class="modal_content">
        <div class="modal_content-header">
            <h1 id="modal_header">Thêm mới</h1>
            <button type="button" class="btn btn_icon" onclick="closeModal()"><i class="fa fa-close"></i></button>
        </div>
        <div class="modal_content-body" id="modal_body">
            
        </div>
        <div class="modal_content-footer">
            <button type="button" class="btn btn-primary" id="btn_modal-submit"></button>
            <button type="button" class="btn" onclick="closeModal()"><i class="fa fa-close"></i>Hủy</button>
        </div>
    </div>
</div>
<script src="assets/js/request.js" type="text/javascript"></script>
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
                        url: "/Admin.aspx/getCategory",
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

    async function closeModal() {
        const modal = document.getElementById("adminContent_modal");
        modal.classList.remove("show");
    }

    function setTitleAndButtonModal(action) {
        let title = document.getElementById("modal_header");
        let buttonSubmit = document.getElementById("btn_modal-submit");
        const modal = document.getElementById("adminContent_modal");
        modal.classList.add("show");
        if (action == "create") {
            title.innerText = "Thêm mới";
            buttonSubmit.innerHTML = `<i class="fa fa-plus"></i>Thêm mới`;
        } else if (action == "update") {
            title.innerText = "Cập nhật";
            buttonSubmit.innerHTML = `<i class="fa fa-pencil"></i>Cập nhật`;
        }
    }

    async function showModal(action) {
        let page = getPage();
        if (!page) return;
        const configPage = config[page];
        if (!configPage) return;
        setTitleAndButtonModal(action);
        const fields = configPage.fields || [];
        const bodyModal = document.getElementById("modal_body");
        bodyModal.innerHTML = "";
        for (let field of fields) {
            const div = document.createElement('div');
            div.className = "item_form"
            const label = document.createElement("label");
            label.htmlFor = field.field;
            label.className = "item_form-label"
            label.innerText = field.label + (field.required ? ": *" : ":");
            div.appendChild(label);
            const element = await createWidgetElement(field);
            div.appendChild(element);
            bodyModal.appendChild(div);
        }
    }

    async function createWidgetElement(config) {
        let widget = config.widget || "";
        let element = "";
        switch (widget) {
            case "select":
                element = document.createElement("select");
                element.id = config.field;
                element.className = "item_form-item"
                if (config.options && config.options.length > 0) {
                    for (let { label, value } of config.options) {
                        if (!label || !value) continue;
                        const option = document.createElement("option");
                        option.value = value;
                        option.innerText = label;
                        element.appendChild(option);
                    }
                } else if (config.getOptions?.url) {
                    const result = await request(config.getOptions.url, config.getOptions.body, config.getOptions.method);
                    let options = []
                    if (result.status === 200) {
                        options = result.data || [];
                    }
                    for (let option of options) {
                        const opt = document.createElement("option");
                        opt.value = option[config.getOptions.save];
                        opt.innerText = option[config.getOptions.view];
                        element.appendChild(opt);
                    }
                }
                break;
            case "textarea":
                element = document.createElement("textarea");
                element.id = config.field;
                element.className = "item_form-item"
                break;
            default:
                element = document.createElement("input");
                element.name = config.field;
                element.type = config.type;
                element.accept = config.accept || "";
                element.required = config.required || false;
                element.id = config.field;
                element.className = "item_form-item"
                break;
        }
        return element;
    }

</script>
