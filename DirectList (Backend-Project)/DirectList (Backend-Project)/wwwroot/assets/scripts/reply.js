let btn = document.querySelectorAll(".reply");

let reply = document.querySelectorAll(".replyComment");
for (let i = 0; i < btn.length; i++) {
    btn[i].addEventListener("click", (e) => {
        e.preventDefault();
        reply[i].classList.toggle("show");
    });
}