$(document).ready(function () {

    InitializeTable($('#example'));


});

function InitializeTable(tableDiv) {
    var gridClassName = "";
    if (_gridClassName != undefined && _gridClassName != "") {
        gridClassName = _gridClassName;
    }
    else {
        gridClassName = 'select-checkbox mdl-data-table__cell--non-numeric';
    }

    var table = $(tableDiv).DataTable({
        responsive: true,
        "pagingType": "simple_numbers",
        columnDefs: [{
            orderable: false,
            className: gridClassName, //'mdl-data-table__cell--non-numeric', //'select-checkbox mdl-data-table__cell--non-numeric',
            targets: 0
        }],
        select: {
            style: 'os multi',
            selector: 'td:first-child'
        },
        order: [[1, 'asc']],
        "dom": '<"table-dropdown"l>f<"toolbar">rtip'
    });

    var ToolBarHTML = "";
    if (_gridDeleteBtnUrl != "") {
        ToolBarHTML += '<button type="button" onclick="DeleteData()" class="fa fa-trash-o btn"></button> ';
    }
    if (_gridCreateButtonUrl != "") {
        ToolBarHTML += '<button onclick="PushToPage()" class="fa fa-plus-circle btn"></button>';
    }
    else if (_gridCreateButtonHtml != "") {
        ToolBarHTML += _gridCreateButtonHtml;
    }

    $("div.toolbar").html(ToolBarHTML);
}
function DeleteData() {
    var table = $('#example').DataTable();
    var rows = table.rows('.selected').indexes();
    //var data = table.rows(rows).data();

    alert(JSON.stringify(rows.toArray()));
    //TODO Implement Ajax to Soft delete items...
    var rows = table
        .rows('.selected')
        .remove()
        .draw();



}
function PushToPage() {
    window.location.href = _gridCreateButtonUrl;
    
}