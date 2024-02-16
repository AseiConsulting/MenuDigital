function obtenerArea() {
    agregaAlPrincipal();
    const tablaArea = new DataTable('#tablaArea');
    let counter = 1;

    $.ajax({
        url: '/Areas/LstAreas',
        type: 'GET',
        data: {
        },

        dataType: 'json',
        success: function (response) {
            var areas = JSON.stringify(response);
            for (var i = 0; i < response.data.length; i++) {
                tablaArea.row
                    .add([
                        response.data[i].idArea,
                        response.data[i].adepto,
                        response.data[i].descripcion,  
                        "<button type='button' class='btn btn-success btn-circle btn-sm fas fa-check' data-toggle='modal' data-target='#areaModal' onclick='regresadatos(this)'></button>"
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
function mostdaArea(button) {
    var txtid;
    var txtdpt
    var txtdesc;


    $("table tbody tr").click(function () {
        txtid = $(this).find("td:eq(0)").text();
        txtdptoa = $(this).find("td:eq(1)").text();
        Descripcion = $(this).find("td:eq(2)").text();


        $("#txtIdArea").val(txtid);
        $("#txtdptoa").val(txtdpt);
        $("#txtdesc").val(Descripcion);


    });
};
function regresadatos() {
    var idArea;
    var deptoar;
    var descripcion;


    $("table tbody tr").click(function () {
        idArea = $(this).find("td:eq(0)").text();
        deptoar = $(this).find("td:eq(1)").text();
        descripcion = $(this).find("td:eq(2)").text();

        $("#txtIdArea").val(idArea);
        $("#txtdptoa").val(deptoar);
        $("#txtdesc").val(descripcion);


    });
}


function AgregArea() {
    var opcion = confirm("Desea Guardar los cambios?");
    var idArea = 0;
    var adepto = 0;
    var descripcion = "";


    if (opcion == true) {
        idArea = $("#txtIdArea").val();
        adepto = $("#txtdptoa").val();
        descripcion = $("#txtdesc").val();

        $.ajax({
            url: '/Areas/updateAreas', //le envio el dato del evento en el controles que va a ejecutar
            data: {
                "idArea": idArea,
                "adepto": adepto,
                "descripcion": descripcion,

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
};


function limpiadatos() {
    id = "";
    dpt = "";
    descripcion = "";

    $("#txtIdArea").val(id);
    $("#txtdptoa").val(dpt);
    $("#txtdesc").val(descripcion);
}