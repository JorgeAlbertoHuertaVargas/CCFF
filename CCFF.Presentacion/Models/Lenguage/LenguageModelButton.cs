using System.Text.Json;

namespace CCFF.Presentacion.Models.Lenguage
{
    public class LenguageModelButton
    {
        public string Register { get; set; }
        public string Edit { get; set; }
        public string Cancel { get; set; }
        public string Delete { get; set; }
        public string Reset { get; set; }

        public string Search { get; set; }  

        public string Student { get; set; }
        public string Lis_of_Students { get; set; }
        public string RegisterStudent { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public string Acciones { get; set; }

        public string Ingrese_DNI { get; set; }


        public string ChangeLanguage { get; set; }

        public string Config_system { get; set; }
        public string Tipo { get; set; }
        public string Valor { get; set; }
        public string Estado { get; set; }

        public string Activado { get; set; }
        public string Desactivado { get; set; }

        public string Editar { get; set; }
        public string Guardar { get; set; }
        public string Cerrar { get; set; }
        public string Ingles { get; set; }
        public string Espanol { get; set; }

        public string Idioma { get; set; }






        public LenguageModelButton GetLanguageForView()
        {
            var parameters = new CCFFF.Logica.ParametersLogica.LogicaParametersCcff();
            LenguageModelButton language;
            var jsonString = "";
            if (parameters.GetParametersSystemById(1).State)
            {

                jsonString = System.IO.File.ReadAllText("./Models/Lenguage/" + parameters.GetParametersSystemById(1).Value + "/Buttons.json");
                language = JsonSerializer.Deserialize<LenguageModelButton>(jsonString);

            }
            else
            {
                jsonString = System.IO.File.ReadAllText("./Models/Lenguage/Spanish/Buttons.json");
                language = JsonSerializer.Deserialize<LenguageModelButton>(jsonString);
            }
            return language;
        }

    }
}
