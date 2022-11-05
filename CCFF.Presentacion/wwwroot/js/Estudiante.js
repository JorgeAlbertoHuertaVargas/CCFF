

function RegistarEstudiante() {
    var Id = $("txtId").val();
    var Id = 0;
    $.ajax({
        url: "Alumno/Registrar",
        data: {
            Id: Id,
            Dni: $("#dni_ciudadano").val(),
            Codigo: $("#inputCodigo").val(),
            Nombre: $("#nombres").val(),
            Apellido: $("#apellidos").val(),
            correo: $("#InputCorreo").val(),
            celular: $("#InputCelular").val()

        },
        type: "POST"
    }).done(function (response) {
        Mensajes(response);
    })
}

function Mensajes(result) {
    if (result == true) {
        $("#Checkname").show("slow").delay(2000).hide("slow");
    }
}


$(".btn-register").click(function () {
    
    if ($("#inputCodigo").val() != "" && $("#dni_ciudadano").val() != "" && $("#nombres").val() != "" && $("#apellidos").val() != "" &&
        $("#inputCelular").val() != "" && $("#inputCorreo").val() != "" ) {
               
            $.ajax({
                url: "Registrar",
                data: {
                    Id:$("#txtId").val(),
                    Dni: $("#dni_ciudadano").val(),
                    Codigo: $("#inputCodigo").val(),
                    Nombre: $("#nombres").val(),
                    Apellido: $("#apellidos").val(),
                    correo: $("#inputCorreo").val(),
                    celular: $("#inputCelular").val()

                },
                type: 'POST'

            }).done(function (resp) {
                //swal({
                //    type: "success",
                //    title: "El alumno registro correctamente",
                //    showConfirmButton: true,
                //    confirmButtonText: "Cerrar",
                //    closeOnConfirm: false
                //}).then(function (result) {
                //    if (result.value) {
                //        window.location = "Registrar";
                //    }
                //})
            })

       
    } else {

        $("#Cheknames").show("slow").delay(2000).hide("slow");
        return;
    }
});