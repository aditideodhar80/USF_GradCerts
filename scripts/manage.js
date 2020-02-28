
//Following three functions are used to change text area color based on focus and blur
var bkColor = "#ffffcc";
function getEvent(e) {
    if (window.event != null) {
        return event;
    }
    return e;
}
function setBKColor(e) {
    e = getEvent(e);
    var src = e.srcElement || e.target;
    if (src != null) {
        src.style.backgroundColor = bkColor;
    }
}
function reSetBKColor(e) {
    e = getEvent(e);
    var src = e.srcElement || e.target;
    if (src != null) {
        src.style.backgroundColor = "#ffffff"
    }
}

//This function sets the background of textbox to light yellow when the row is active
function AfterRowActivateHandler(gridId, rowId) {
    var oRow = igtbl_getRowById(rowId);
    var oCol = oRow.getCellFromKey("bullet_text").Column;
    var oCell = oRow.getCellFromKey("bullet_text");
    var elem = oCell.Element;

    elem.children[0].style.backgroundColor = "#ffffcc";
}

function showMessage(gridid, msg) {
    //var grid=igtbl_getGridById(gridid);
    var myrow = igtbl_getActiveRow(gridid);
    if (myrow == null) {
        alert(msg);
    }

}