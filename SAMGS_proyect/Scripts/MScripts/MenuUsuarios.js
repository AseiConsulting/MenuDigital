function obtenerPersona() {
    agregaAlPrincipal();
    const tabla = new DataTable('#dataTable');
    let counter = 1;

    $.ajax({
        url: '/Usuarios/LstUsuarios',
        type: 'GET',
        data: {
        },

        dataType: 'json',
        success: function (response) {
            var clientes = JSON.stringify(response);
            for (var i = 0; i < response.data.length; i++) {
                tabla.row
                    .add([
                        response.data[i].iUserID,
                        response.data[i].VCHUSUARIO,
                        response.data[i].sUserName,
                        response.data[i].vchidUserCorp,
                        response.data[i].iPerfilId,
                        response.data[i].idDepto,
                        response.data[i].sPasword,
                        response.data[i].sPreguntaSecreta,
                        response.data[i].sRespuestaSecreta,
                        response.data[i].bActivo,
                        response.data[i].iCaducidad,
                        response.data[i].iEsEmp,
                        //"<button type='button' class='btn btn-success btn-circle btn-sm fas fa-check' data-toggle='modal' data-target='#usuariosModal' onclick='regresadatos(this)'></button>"
                        "<a data-toggle='modal' data-target='#usuariosModal' onclick = 'regresadatos(this)' class= 'btn btn-success' ><span class='icon text-white-50'><i class='fas fa-check'></i></span><span class='text'></span></a >"
                    ])
                    .draw(false);

                counter++;

            }
        },
        error: function (jqXHR, status, error) {
            alert('Hay un error al cargar los datos');
        },
        complete: function (jqXHR, status) {
        }
    });

}

function ObtenerEmpleados() {
    const tabla = new DataTable('#tableEmpleado');
    let counter = 1;

    $.ajax({
        url: '/Usuarios/listarEmpleados',
        type: 'GET',
        data: {
        },

        dataType: 'json',
        success: function (response) {
            var clientes = JSON.stringify(response);
            for (var i = 0; i < response.data.length; i++) {
                tabla.row
                    .add([
                        response.data[i].idEmpleado,
                        response.data[i].nombreEmp,
                        "<button type='button' class='btn btn-success btn-circle btn-sm fas fa-check' data-toggle='modal' data-target='#usuariosModal' onclick='regresadatosEmp(this)'></button>"
                    ])
                    .draw(false);

                counter++;

            }
        },
        error: function (jqXHR, status, error) {
            alert('Hay un error al cargar los datos');
        },
        complete: function (jqXHR, status) {
        }
    });
}
function agregaAlPrincipal() {
    var elemento = document.getElementById('content');
    $("#content-wrapper").append(elemento);
}

//Carga datos al selcionar el grid
function regresadatos(button) {
    var txtid;
    var txtNom;
    var flexCheck
    var txtPassword;
    var txtPerfilId;
    var txtPassword;
    var txtidDepto;
    var txtisPreguntaSecreta;
    var txtisRespuestaSecreta;
    var iCaducidad;
    var txtInactivo;
    var txtUserCorp;
    var iEsEmpleado;
    var check1;
    var check2;
    var nombreUsuario;

    $("table tbody tr").click(function () {
        txtid = $(this).find("td:eq(0)").text();
        nombreUsuario = $(this).find("td:eq(1)").text();
        txtNom = $(this).find("td:eq(2)").text();
        txtUserCorp = $(this).find("td:eq(3)").text();
        txtPerfilId = $(this).find("td:eq(4)").text();
        txtidDepto = $(this).find("td:eq(5)").text();
        txtPassword = $(this).find("td:eq(6)").text();
        txtisPreguntaSecreta = $(this).find("td:eq(7)").text();
        txtisRespuestaSecreta = $(this).find("td:eq(8)").text();
        txtInactivo = $(this).find("td:eq(9)").text();
        iCaducidad = $(this).find("td:eq(10)").text();
        flexCheck = $(this).find("td:eq(11)").text();

        $("#txtId").val(txtid);
        $("#txtNom").val(nombreUsuario);
        $("#txtUserName").val(txtNom);
        $("#txtUserCorp").val(txtUserCorp);
        $("#txtPerfilId").val(txtPerfilId);
        $("#txtidDepto").val(txtidDepto);
        $("#txtPassword").val(txtPassword);
        $("#txtisPreguntaSecreta").val(txtisPreguntaSecreta);
        $("#txtisRespuestaSecreta").val(txtisRespuestaSecreta);
        $("#txtInactivo").val(txtInactivo);
        if (flexCheck == 1)
        { $("#idCheck").prop('checked', true) }
        else
        { $("#idCheck").prop('checked', false) };

        if (iCaducidad == 1)
        { $("#CheckCadu").prop('checked', true) }
        else
        { $("#CheckCadu").prop('checked', false) };
        if (txtInactivo == 1)
        { $("#CheckEstatus").prop('checked', true) }
        else
        { $("#CheckEstatus").prop('checked', false) };

    });
};

function regresadatosEmp(button) {
    var txtid;
    $("tableEmpleado tbody tr").click(function () {
        txtid = $(this).find("td:eq(0)").text();
        $("#txtUserName").val(txtid);
    });
};
//valido datos para guardar informacion
function validarDatos() {
    var opcion = confirm("Desea Guardar los cambios?");
    if (opcion == true) {
        id = $("#txtId").val();
        nuser = $("#txtUserName").val();
        NomUser = $("#txtNom").val();
        userCorp =  $("#txtUserCorp").val();
        PerfilID = $("#txtPerfilId").val();
        idDepto=$("#txtidDepto").val();
        password = $("#txtPassword").val();
        PreguntaSecreta=$("#txtisPreguntaSecreta").val();
        RespuestaSecreta = $("#txtisRespuestaSecreta").val();
        checkEmp = $("#idCheck").val();
        iCaducidad = $("#CheckCadu").val();
        inactivo = $("#CheckEstatus").val();

        $.ajax({
            url: '/Usuarios/UpdateAddUser', //le envio el dato del evento en el controles que va a ejecutar
            data: {
                "iUserID" :id,
                "VCHUSUARIO": NomUser,
                "vchidUserCorp": userCorp,
                "sUserName" : nuser,
                "sPasword": password,
                "iPerfilId": PerfilID,
                "idDepto":idDepto,
                "sPreguntaSecreta":PreguntaSecreta,
                "sRespuestaSecreta":RespuestaSecreta,
                "bActivo" : inactivo,
                "iCaducidad" : iCaducidad,
                "iEsEmp": checkEmp

            },
            type: 'GET',
            dataType: 'json',
            success: function (response) {

                alert('Los datos se guardaron correctamente');
            },
            error: function (jqXHR, status, error) {
                alert('Disculpe, existió un problema en el guardado de datos');
            },
            complete: function (jqXHR, status) {
            }

        });

    };
}

function limpiadatos(button) {
    txtid = "";
    nombreUsuario = "";
    txtNom = "";
    txtUserCorp = "";
    txtPerfilId = "";
    txtidDepto = "";
    txtPassword = "";
    txtisPreguntaSecreta = "";
    txtisRespuestaSecreta = "";
    txtInactivo = "";
    iCaducidad = "";
    flexCheck = "";

    $("#txtId").val(txtid);
    $("#txtNom").val(nombreUsuario);
    $("#txtUserName").val(txtNom);
    $("#txtUserCorp").val(txtUserCorp);
    $("#txtPerfilId").val(txtPerfilId);
    $("#txtidDepto").val(txtidDepto);
    $("#txtPassword").val(txtPassword);
    $("#txtisPreguntaSecreta").val(txtisPreguntaSecreta);
    $("#txtisRespuestaSecreta").val(txtisRespuestaSecreta);
    $("#txtInactivo").val(txtInactivo);
    if (flexCheck == 1) { $("#idCheck").prop('checked', true) }
    else { $("#idCheck").prop('checked', false) };

    if (iCaducidad == 1) { $("#CheckCadu").prop('checked', true) }
    else { $("#CheckCadu").prop('checked', false) };
    if (txtInactivo == 1) { $("#CheckEstatus").prop('checked', true) }
    else { $("#CheckEstatus").prop('checked', false) };
}

function catPerfil(number) {
    //var cmblst = document.getElementById('cmbPerfil');
    var i = 1;
    $.ajax({
        url: "/Usuarios/listarCatalogo",
        data: {
            "id": 1
        },
        type: 'GET',
        dataType: 'Json',
        success: function (response) {
            $("#cmbPerfiles")
                .empty()
                .append($("<option></option>")
                    .val("0")
                    .html("Seleccione Perfil:"));
            for (var i = 0; i < response.Data.data.length; i++) {
                $("#cmbPerfiles").append($("<option></option>")
                    .val(i)
                    .html(response.Data.data[i].descripcion));
            };
        },
        error: function (jqXHR, status, error) {
            alert('Hay un error al cargar los datos de perfiles');
        },
        complete: function (jqXHR, status) {
        }
    });

};

function catDeptos(number) {
    var cmblst = document.getElementById('cmbDeptos');
    var i = 1;
    $.ajax({
        url: "/Usuarios/listarCatalogo",
        data: { "id":2},
        type: 'GET',
        dataType: 'Json',
        success: function (response) {

            $("#cmbDeptos")
                .empty()
                .append($("<option></option>")
                    .val("0")
                    .html("Seleccione Departamento:"));


            for (var i = 0; i < response.Data.data.length; i++) {

                $("#cmbDeptos").append($("<option></option>")
                    .val(i)
                    .html(response.Data.data[i].descripcion));
            };
        },
        error: function (jqXHR, status, error) {
            alert('Hay un error al cargar los datos de departamentos');
        },
        complete: function (jqXHR, status) {
        }
    });

};
