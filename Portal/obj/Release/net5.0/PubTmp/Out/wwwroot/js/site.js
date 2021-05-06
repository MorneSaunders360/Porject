// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function callGenAjax(ajaxType, ajaxUrl, Async, ajaxInputData) {
    var outputData = "";
    $.ajax({
        type: ajaxType,
        url: ajaxUrl,
        data: ajaxInputData,
        async: Async,
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




// START CLOCK SCRIPT



