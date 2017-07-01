//添加按钮
//function btn_Add_Clicking(url, ismax, width, height) {
//    alert(url);

//}
function btn_Add_Clicking(sender, args) {

    var oWnd = radopen(pageset._addurl, "RadWindowManager1");
    if (pageset._ismax == 0) {
        oWnd.setSize(pageset._addset._w, pageset._addset._h);
    } else {
        oWnd.Maximize();
    }

    oWnd.center();
}

//更新按钮
function btn_Edit_Clicking(url, ismax, width, height) {
    if (id == -1) {
        alert("请选择1条数据！");
    } else {

        var oWnd = radopen(pageset._editurl + "?id=" + id, "RadWindowManager1");
        if (pageset._ismax == 0) {
            oWnd.setSize(pageset._editset._w, pageset._editset._h);
        } else {
            oWnd.Maximize();
        }
        oWnd.center();
    }
}

//取消按钮
function bthCanel_Clicked(sender, args) {
    CloseRadWindow();
}
//关闭模式窗口
function CloseAndRebind(args) {
    GetRadWindow().BrowserWindow.refreshGrid(args);
    window.location.reload();
}
function GetRadWindow() {
    var oWindow = null;
    if (window.radWindow) oWindow = window.radWindow; //Will work in Moz in all cases, including clasic dialog
    else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow; //IE (and Moz as well)
    return oWindow;
}
//关闭模式窗口
function CloseRadWindow() {
    GetRadWindow().Close();
}
