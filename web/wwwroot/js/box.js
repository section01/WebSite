/**
 * 予約済みの席を特定
 */
function box_reserved() {
    const reserved = document.getElementById("reserved").value.trim().split(',');
    reserved.forEach(id => {
        document.getElementById(id).classList.add("box_reserved");
    });
}

/**
 * 選択した席を設定
 */
function box_click(dom) {
    document.getElementById("box_select").value = dom.id;
}

/**
 * 初期表示
 */
window.onload = () => {
    box_reserved();
}