const showMenu = (toggleId, navId) => {
    const toggle = document.getElementById(toggleId),
        nav = document.getElementById(navId);

    toggle.addEventListener('click', () => {
        nav.classList.toggle('show-menu');
        toggle.classList.toggle('show-icon');
    });
}
showMenu('nav-toggle', 'nav-menu')

function loadVehim() {
    const formData = new FormData();
    formData.append("thaoTac", "hienThi");
    var xhr = new XMLHttpRequest();
    xhr.open('post', 'cms/Ajax/Phim.aspx', false);
    xhr.onreadystatechange = () => {
        if (xhr.readyState == 4 && xhr.status == 200) {
            const data = JSON.parse(xhr.responseText);
            console.log(data);
            let html = "";
            html += data.map(obj => 
                `
                <div class="col c-6 l-2-4">
                    <a href="MovieDetail.aspx?id=${obj.PK_iPhimID}" class="card__item">
                        <div class="card__item-img" style="background-image: url(${obj.sAnh})"></div>
                        <h4 class="card__item-name">${obj.sTenPhim}</h4>
                        <div class="card__item-date">Thời lượng ${obj.iThoiLuong} phút</div>
                    </a>                
                </div>     
                `
            ).join("");
            document.querySelector('.list-film').innerHTML = html;
        } else {
            alert(`Error: ${xhr.status}`);
        }
    }
    xhr.send(formData);
}
loadVehim();

function timPhim() {
    document.querySelector(".nav__search input").addEventListener('keyup', () => {
        let keyword = document.querySelector('.nav__search input').value;
        console.log(keyword);
        const formData = new FormData();
        formData.append("thaoTac", "tim");
        formData.append("tuKhoa", keyword);
        var xhr = new XMLHttpRequest();
        xhr.open('post', 'cms/Ajax/Phim.aspx', false);
        xhr.onreadystatechange = () => {
            if (xhr.readyState == 4 && xhr.status == 200) {
                 
            } else {
                alert(`Error: ${xhr.status}`);
            }
        }
        xhr.send(formData);
    });
}
timPhim();

