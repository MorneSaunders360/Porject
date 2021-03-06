var _gridClassName = "mdl-data-table__cell--non-numeric";
var ToolBarHTML = '<button type="button" onclick="EditPortalDevice(0)" class="btn-command">Add</button>';
function InitializePortalDeviceTable(tableDiv, gridClassName, ToolBarHTML) {
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
        "dom": '<"toolbar">frtip'
    });
    $('.toolbar', $(tableDiv).parent()).html(ToolBarHTML);

    //$(tableDiv).find('toolbar').html(ToolBarHTML);
    //$("div.toolbar").html(ToolBarHTML);
}

$(document).ready(function () {
    InitializePortalDeviceTable($("#example"), _gridClassName, ToolBarHTML);

});

function EditPortalDevice(PortalDeviceId) {
    window.location.href = "/PortalDevice/Edit?PortalDeviceId=" + PortalDeviceId
}