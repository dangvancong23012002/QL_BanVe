const adminConfig = {
    movie: {
        url: "/Admin.aspx/getMovie",
        urlAction: "/Admin.aspx",
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
                type: "datetime-local",
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
                widget: "textarea",
                style: "width: 600px; height: 150px"
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
    },
    room: {
        url: "/Admin.aspx/getRoom",
        urlAction: "/Admin.aspx",
        fields: [
            {
                label: "Tên phòng",
                required: true,
                field: "sTenPhong",
                type: "text"
            }
        ]
    },
    category: {
        url: "/Admin.aspx/getCategory",
        urlAction: "/Admin.aspx",
        fields: [
            {
                label: "Tên thể loại",
                required: true,
                field: "sTenTheLoai",
                type: "text"
            },
            {
                label: "Ảnh",
                required: true,
                field: "sAnh",
                type: "file",
                accept: "image/*"
            }
        ]
    },
    product: {
        url: "/Admin.aspx/getProduct",
        urlAction: "/Admin.aspx",
        fields: [
            {
                label: "Tên sản phẩm",
                required: true,
                field: "sTenDoAn",
                type: "text"
            },
            {
                label: "Giá",
                required: true,
                field: "fGia",
                type: "number"
            },
            {
                label: "Số lượng",
                required: true,
                field: "iSoLuong",
                type: "number"
            }
        ]
    },
    users: {
        url: "/Admin.aspx/getUser",
        urlAction: "/Admin.aspx",
        fields: [
            {
                label: "Tên đăng nhập",
                required: true,
                field: "PK_sTenDangNhap",
                type: "text"
            },
            {
                label: "Họ tên",
                required: true,
                field: "sHoTen",
                type: "text"
            },
            {
                label: "Số điện thoại",
                required: true,
                field: "sSoDienThoai",
                type: "text"
            },
            {
                label: "Vai trò",
                required: true,
                field: "sVaiTro",
                type: "text",
                widget: "select",
                options: [
                    {
                        label: "Staff",
                        value: "staff"
                    },
                    {
                        label: "Teamlead",
                        value: "teamlead"
                    },
                    {
                        label: "Admin",
                        value: "admin"
                    }
                ]
            }
        ]
    }
}


function createInputFile(config) {
    const div = document.createElement("div");
    div.className = "item_wrapper-inputFile"
    // ---------------- input -----------------//
    const input = document.createElement("input");
    input.hidden = true;
    input.name = config.field;
    input.type = "file";
    input.accept = config.accept || "";
    input.required = config.required || false;
    input.id = config.field;
    // ---------------- label -----------------//
    const label = document.createElement("label");
    label.htmlFor = config.field;
    label.className = "btn_input-file";
    label.innerText = "Chọn tệp";
    div.appendChild(label);
    // ---------------- item box -----------------//
    const divChild = document.createElement("div");
    divChild.className = "item_input-file";
    let namefile = (config.value || "").split("/");
    namefile = namefile[namefile.length - 1];
    if (config.value) {
        divChild.classList.add("show");
        input.type = "text";
        input.value = config.value;
        label.style = "display: none";
    }
    const span = document.createElement("span");
    span.innerText = namefile;
    span.className = "item_input-name";
    const buttonIcon = document.createElement("button");
    buttonIcon.innerHTML = "<i class='fa fa-trash'></i>";
    buttonIcon.className = "btn btn_icon";
    buttonIcon.onclick = (event) => {
        input.value = "";
        divChild.classList.remove("show");
        label.style = "display: unset";
        input.type = "file";
    }
    divChild.appendChild(span);
    divChild.appendChild(buttonIcon);
    div.appendChild(divChild);
    div.appendChild(input);

    input.onchange = (event) => {
        const files = event.target.files;
        const nameFile = files[0].name;
        span.innerText = nameFile;
        divChild.classList.add("show");
        label.style = "display: none";
    }
    return div;
}