function box_click(dom) {
    for (const i of document.querySelectorAll(".reserved")) {
        if (dom.id === i.value) {
            return;
        }
    }
    document.getElementById("box_num").value = dom.id;
}

window.onload = () => {
    for (const i of document.querySelectorAll(".reserved")) {
        let dom = document.getElementById(i.value);
        dom.style.backgroundColor = "#FFFF00";
    }
}
