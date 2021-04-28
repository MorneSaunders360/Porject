var _gridClassNamePortalDeviceScheduleTable = "mdl-data-table__cell--non-numeric";
var ToolBarHTMLPortalDeviceScheduleTable = '<button type="button" onclick="EditPortalDeviceSchedule(0)" class="btn-command">Add</button>';
function InitializePortalDeviceScheduleTable(tableDiv, gridClassName, ToolBarHTML) {
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
    InitializePortalDeviceScheduleTable($("#PortalDeviceScheduleTable"), _gridClassNamePortalDeviceScheduleTable, ToolBarHTMLPortalDeviceScheduleTable);

});
function EditPortalDeviceSchedule(PortalDeviceScheduleId) {
    var PortalDeviceId = $("#PortalDeviceId").val();
    $.ajax({
        cache: false,
        type: "GET",
        url: '/PortalDeviceSchedule/EditPortalDeviceSchedule?PortalDeviceScheduleId=' + PortalDeviceScheduleId + "&PortalDeviceId=" + PortalDeviceId,
        success: function (result) {
            $('#DivPortalDeviceScheduleModel').html(result);
            $('#myModalPortalDeviceSchedule').modal('show');

        },
        error: function (result) {

        }

    });
}
function SavePortalDeviceSchedule() {
    $.ajax({
        cache: false,
        type: "Post",
        url: '/PortalDeviceSchedule/SavePortalDeviceSchedule',
        data: $("#PortalDeviceScheduleForm").serialize(),
        success: function (result) {
            $('#myModalPortalDeviceSchedule').modal('hide');
            $('#DivPortalDeviceSchedule').html(result);
            InitializePortalDeviceScheduleTable($("#PortalDeviceScheduleTable"), _gridClassNamePortalDeviceScheduleTable, ToolBarHTMLPortalDeviceScheduleTable);

        },
        error: function (results) {
            //$("#btnEntityChildAdd").hide(); //$("#btnEntityChildAdd").attr("disable", false);

        }
    });
}