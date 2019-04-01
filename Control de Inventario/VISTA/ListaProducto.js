$(document).ready(function () {


    VISTA.servicios.wsProductos.getAll(onComplete_cargarlista);

});

function onComplete_cargarlista(response) {

    //alert("onComplete_cargarlista + " + response);
    var dataSet = JSON.parse(response);

    tabla = $('#example').dataTable({
        data: dataSet,
        "lengthMenu": [[9], [9]],
        "bLengthChange": false,
        "info": false,
        columns: [

            { title: "Codigo", data: "Codigo", render: $.fn.dataTable.render.text() },
            { title: "Nombre", data: "Nombre", render: $.fn.dataTable.render.text() },
            { title: "Cantidad", data: "Cantidad", render: $.fn.dataTable.render.text() },
            { title: "PrecioCosto", data: "PrecioCosto", render: $.fn.dataTable.render.text() },
            { title: "PrecioPublico", data: "PrecioPublico", render: $.fn.dataTable.render.text() },
            { title: "PrecioMayoreo", data: "PrecioMayoreo", render: $.fn.dataTable.render.text() },
            { title: "Categoria", data: "Categoria", render: $.fn.dataTable.render.text() }            
        ]
    });
}