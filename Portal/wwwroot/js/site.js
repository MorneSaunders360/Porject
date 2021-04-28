// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function callAjax(ajaxType, ajaxUrl, ajaxInputData, async) {

    var outputData = "";
    $.ajax({
        type: ajaxType,
        url: ajaxUrl,
        data: ajaxInputData,
        contentType: "application/json; charset=utf-8",
        dataType: "text",
        async: async,
        cache: false
    }).done(function (data) {
        outputData = data;

    }).fail(function (response) {
        if (response.status != 0) {


            return "";
        }
    });
    return outputData;
}

function OpenLogin() {
    $("#LogInDiv").show();;
    var ajaxType = "Get";
    var ajaxUrl = "/Account/Login";
    var ajaxInputData = "";
    var result = callAjax(ajaxType, ajaxUrl, ajaxInputData, false);
    $("#LogInDiv").html(result);

}
function CloseLogin() {
    $("#LogInDiv").hide();;
}

// START CLOCK SCRIPT

Number.prototype.pad = function (n) {
    for (var r = this.toString(); r.length < n; r = 0 + r);
    return r;
};

function updateClock() {
    var now = new Date();
    var milli = now.getMilliseconds(),
        sec = now.getSeconds(),
        min = now.getMinutes(),
        hou = now.getHours(),
        mo = now.getMonth(),
        dy = now.getDate(),
        yr = now.getFullYear();
    var months = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
    var tags = ["mon", "d", "y", "h", "m", "s", "mi"],
        corr = [months[mo], dy, yr, hou.pad(2), min.pad(2), sec.pad(2), milli];
    for (var i = 0; i < tags.length; i++)
        document.getElementById(tags[i]).firstChild.nodeValue = corr[i];
}

function initClock() {
    updateClock();
    window.setInterval("updateClock()", 1);

}

