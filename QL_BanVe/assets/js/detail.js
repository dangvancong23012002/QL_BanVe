const modalView = document.querySelector(".detail__modal");

document.querySelector(".detail__buy-btn").addEventListener('click', () => {
    modalView.classList.add("active-modal");
});

document.querySelector(".detail__modal-close").addEventListener('click', () => {
    modalView.classList.remove("active-modal");
});

window.onclick = (event) => {
    if (event.target == modalView) {
        modalView.classList.remove("active-modal");
    }
}