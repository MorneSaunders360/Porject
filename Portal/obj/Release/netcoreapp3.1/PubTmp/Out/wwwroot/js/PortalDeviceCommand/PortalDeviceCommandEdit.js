var _gridClassName = "mdl-data-table__cell--non-numeric";
var ToolBarHTML = '<button type="button" onclick="EditPortalDeviceCommand(0)" class="btn-command">Add</button>';
function InitializePortalDeviceCommandTable(tableDiv, gridClassName, ToolBarHTML) {
    $(tableDiv).removeClass('table-child-types');
    var table = $(tableDiv).DataTable({
        responsive: true,
        "pagingType": "simple_numbers",
        columnDefs: [{
            orderable: false,
            className: gridClassName, //'mdl-data-table__cell--non-numeric', //'select-checkbox mdl-data-table__cell--non-numeric',
            targets: 0
        }],
        select: {
            style: 'os',
            selector: 'td:first-child'
        },
        //order: [[1, 'asc']],
        "dom": 'f<"toolbar">rtip'
    });
    $('.toolbar', $(tableDiv).parent()).html(ToolBarHTML);

    //$(tableDiv).find('toolbar').html(ToolBarHTML);
    //$("div.toolbar").html(ToolBarHTML);
}

$(document).ready(function () {
    InitializePortalDeviceCommandTable($("#PortalDeviceCommandTable"), _gridClassName, ToolBarHTML);

});
function EditPortalDeviceCommand(PortalDeviceCommandId) {
    var PortalDeviceId = $("#PortalDeviceId").val();
    $.ajax({
        cache: false,
        type: "GET",
        url: '/PortalDeviceCommand/EditPortalDeviceCommand?PortalDeviceCommandId=' + PortalDeviceCommandId + "&PortalDeviceId=" + PortalDeviceId,
        success: function (result) {
            $('#DivPortalDeviceCommandModel').html(result);
            $('#myModalPortalDeviceCommand').modal('show');

        },
        error: function (result) {

        }

    });
}
function SavePortalDeviceCommand() {
    $.ajax({
        cache: false,
        type: "Post",
        url: '/PortalDeviceCommand/SavePortalDeviceCommand',
        data: $("#PortalDeviceCommandForm").serialize(),
        success: function (result) {
            $('#myModalPortalDeviceCommand').modal('hide');
            $('#DivPortalDeviceCommand').html(result);
            InitializePortalDeviceCommandTable($("#PortalDeviceCommandTable"), _gridClassName, ToolBarHTML);

        },
        error: function (results) {
            //$("#btnEntityChildAdd").hide(); //$("#btnEntityChildAdd").attr("disable", false);

        }
    });
}
function copy(elementId)
{
    var copyText = document.getElementById(elementId);
    copyText.select();
    copyText.setSelectionRange(0, 99999)
    document.execCommand("copy");
    //alert("Copied the text: " + copyText.value);



}