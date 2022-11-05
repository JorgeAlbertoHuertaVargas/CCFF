



        var Conruc;

        consultarDni = function () {
            Conruc = document.getElementById("dni").value;
            consulta = {
                "Conruc": String(Conruc)
            };
            if (Conruc.length == 8) {
                fetch("https://dniruc.apisperu.com/api/v1/dni/" + Conruc + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImpvbmVsLnNhY3JhbWVudG9Ab3V0bG9vay5jb20ifQ.aMnk3frNo8ai1cSsBuQzHQjZfFP2B0BPHGXQ26zMEHA",
                    {
                        method: "GET",
                        data: JSON.stringify(consulta),
                        headers: { "Content-type": "application/json;charset=UTF-8" }
                    }).then(response => response.json())
                    .then(json => {
                        document.getElementById("dni_ciudadano").value = json.dni;
                        document.getElementById("nombres").value = json.nombres;
                        document.getElementById("apellidos").value = json.apellidoPaterno + " " + json.apellidoMaterno;
                    })

                    .catch(err => console.log(err));

            } else if (Conruc.length == 11) {
                fetch("https://dniruc.apisperu.com/api/v1/ruc/" + Conruc + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImpvbmVsLnNhY3JhbWVudG9Ab3V0bG9vay5jb20ifQ.aMnk3frNo8ai1cSsBuQzHQjZfFP2B0BPHGXQ26zMEHA",
                    {
                        method: "GET",
                        data: JSON.stringify(consulta),
                        headers: { "Content-type": "application/json;charset=UTF-8" }
                    }).then(response => response.json())
                    .then(json => {
                        document.getElementById("dni_ciudadano").value = json.ruc;
                        document.getElementById("nombres").value = json.razonSocial;
                        document.getElementById("apellidos").value = json.direccion;
                    })

                    .catch(err => console.log(err));

            }
            else {
                alert("Erros");
            }
            

        }

        $("#dni").keypress(function (event) {
            if (event.keyCode === 13) {
                $("#buscardni").click();
            }
        });
