﻿function insert() {   
    VISTA.servicios.wsUsuarios.insert2($("#txtNombre").val(), $("#txtApellidoPaterno").val(),
        $("#txtApellidoMaterno").val(), $("#txtTelefono").val(), $("#txtEmail").val(),
        $("#txtContraseña").val(), $("#txtUsuario").val(),$("#cmbNivel").val(), onSuccess, onError);
}

function onSuccess() {
    alert("Exito");
}
function onError() {
    alert("Error");
}