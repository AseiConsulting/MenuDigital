
function PruebaConx() {
    $.ajax({
        url: '/Default/Prueba',
        type: 'GET',
        data: {
             },
        dataType: 'json',
        success: function (response) {
            var clientes = JSON.stringify(response);

            alert('Conexion exitosa');
        },
        error: function (jqXHR, status, error) {
            alert('Conexion Fallida');
        },
        complete: function (jqXHR, status) {
        }
    });

}

function agregaAlPrincipal() {
    var elemento = document.getElementById('content');
    $("#content-wrapper").append(elemento);
}
