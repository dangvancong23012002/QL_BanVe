<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="adminContent.ascx.cs" Inherits="QL_BanVe.UI.UI_TrangAdmin.adminContent" %>

<div class="adminPage_content">
    <div class="adminPage_content-header">
        <h1 class="header_title"><asp:Literal runat="server" ID="adminPage_title"/></h1>
        <button class="btn btn-primary" type="button" onclick="showModal('create')"><i class="fa fa-plus"></i>Thêm mới</button>
    </div>
    <div class="adminPage_content-control">
        <div class="wrapper_input">
            <asp:TextBox CssClass="input" runat="server" ID="inputKey" ClientIDMode="Static"/>
            <asp:Label CssClass="text_desc" AssociatedControlID="inputKey" runat="server" ID="description" />
        </div>
        <button runat="server" id="btnSearch" class="btn btn-success"><i class="fa fa-search"></i>Tìm kiếm</button>
        <button type="button" class="btn btn-primary" onclick="showModal('update')"><i class="fa fa-pencil"></i>Cập nhật</button>
        <button type="button" id="btnDelete" class="btn btn-primary" onclick="deleteData(event)"><i class="fa fa-trash"></i>Xóa</button>
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
<script src="../../assets/js/adminConfig.js" type="text/javascript"></script>
<script>
    function getPage() {
        const params = window.location.search;
        const paramsObject = new URLSearchParams(params);
        const page = paramsObject.get("page");
        return page;
    }

    function closeModal() {
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
        buttonSubmit.onclick = (event) => clickSubmitForm(action,event);
    }

    async function showModal(action) {
        let page = getPage();
        if (!page) return;
        const configPage = adminConfig[page];
        if (!configPage) return;
        let data = {};
        if (action == "update") {
            let inputId = document.getElementById("inputKey");
            if (!inputId?.value) {
                alert("vui lòng nhập mã!");
                return;
            } else {
                let rs = await getDataByUrl(configPage.url + "?id=" + inputId.value) || [];
                data = rs[0];
                if (!data) {
                    alert("Không tìm thấy sản phẩm!");
                    return;
                }
            }
        }
        setTitleAndButtonModal(action);
        const fields = configPage.fields || [];
        await createItem(fields, data);
    }

    async function createItem(fields, data = {}) {
        const bodyModal = document.getElementById("modal_body");
        const formModal = document.createElement("form");
        formModal.id = "modal_form"
        bodyModal.innerHTML = "";
        for (let field of fields) {
            const div = document.createElement('div');
            div.className = "item_form"
            const label = document.createElement("label");
            label.htmlFor = field.field;
            label.className = "item_form-label"
            label.innerText = field.label + (field.required ? ": *" : ":");
            field.value = data[field.field] || "";
            div.appendChild(label);
            const element = await createWidgetElement(field);
            div.appendChild(element);
            formModal.appendChild(div);
        }
        bodyModal.appendChild(formModal)
    }

    async function createWidgetElement(config) {
        let widget = config.widget || "";
        let element = document.createElement("input");
        element.value = config.value;
        switch (widget) {
            case "select":
                element = document.createElement("select");
                element.name = config.field;
                element.id = config.field;
                element.className = "item_form-item"
                const optionDefault = document.createElement("option");
                optionDefault.value = "";
                optionDefault.innerText = "Choose option";
                if (!config.value) optionDefault.selected = true;
                element.appendChild(optionDefault);
                if (config.options && config.options.length > 0) {
                    for (let { label, value } of config.options) {
                        if (!label || !value) continue;
                        const option = document.createElement("option");
                        option.selected = value == config.value || false;
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
                        opt.selected = opt.value == config.value || false;
                        opt.innerText = option[config.getOptions.view];
                        element.appendChild(opt);
                    }
                }
                break;
            case "textarea":
                element = document.createElement("textarea");
                element.style = config.style;
                element.value = config.value;
                element.id = config.field;
                element.name = config.field;
                element.className = "item_form-item"
                break;
            default:
                if (config.type == "file") {
                    element = createInputFile(config);
                } else {
                    element.name = config.field;
                    element.type = config.type;
                    element.required = config.required || false;
                    element.id = config.field;
                    element.className = "item_form-item"
                }
                break;
        }
        return element;
    }

    async function getDataByUrl(url, body, method = "GET") {
        const result = await request(url, body, method);
        if (!result) return null;
        if (result.status === 200) {
            return result.data;
        } else {
            return null;
        }
    }

    async function clickSubmitForm(action, event) {
        let page = getPage();
        if (!page) return;
        const configPage = adminConfig[page];
        if (!configPage || !configPage.fields) return;
        const { fields } = configPage;
        const form = document.getElementById("modal_form");
        const formData = new FormData(form);
        for (let field of fields) {
            if (field.required && !formData.get(field.field)) {
                alert(field.label + " is required!");
                return;
            }
            if (field.type.includes("date")) {
                let value = new Date(formData.get(field.field)).toISOString();
                formData.set(field.field, value);
            }
        }
        if (action === "update") {
            let inputId = document.getElementById("inputKey");
            if (!inputId?.value) {
                alert("Lỗi vui lòng thử lại!");
                closeModal();
                return;
            }
            formData.set("id", inputId.value);
        } 
        event.target.setAttribute("disabled", "true");
        const url = configPage.urlAction + `/handleForm?action=${action}&page=${page}`;
        let result = await request(url, formData);
        event.target.removeAttribute("disabled");
        if (result.status == 200) {
            closeModal();
            location.reload();
        } else {
            alert("Submit failed!");
        }
    }

    async function deleteData(event) {
        let page = getPage();
        if (!page) return;
        const configPage = adminConfig[page];
        if (!configPage || !configPage.urlAction) return;
        let inputId = document.getElementById("inputKey");
        if (!inputId?.value) {
            alert("Vui lòng nhập mã!");
            return;
        }
        if (!confirm("Bạn có chắc muốn xóa!")) {
            return;
        }
        event.target.setAttribute("disabled", "true");
        const url = configPage.urlAction + `/deleteData?ID=${inputId.value}&page=${page}`;
        let result = await request(url, null, "GET");
        event.target.removeAttribute("disabled");
        if (result.status == 200) {
            location.reload();
        } else {
            alert("Xóa thất bại!");
        }
    }

</script>
