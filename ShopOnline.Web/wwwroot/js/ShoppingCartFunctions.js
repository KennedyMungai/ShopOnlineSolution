function MakeUpdateQtyButtonVisible(id, visible) {
    const updateQtyButton = document.querySelector("button[data-itemId='" + id + "']");

    if (visible == true) {
        updateQtyButton.getElementsByClassName.display = "inline-block";
    }
    else
    {
        updateQtyButton.style.display = "none";
    }
}