using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations;

namespace CCFF.Modelo
{
    public class Alumno
    {

        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Dni { get; set; }

       // [Required(ErrorMessage = "El correo es obligatorio")]
        public string? correo { get; set; }


      // [Required(ErrorMessage = "El celular es obligatorio")]
        public string? celular { get; set; }

      

        
    }
}

