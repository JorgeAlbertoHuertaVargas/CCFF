
using CCFF.Modelo;
using CCFFF.Logica.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        private readonly IAlumnoLogica _alumnoLogica;
        public AlumnoController(IAlumnoLogica alumnoLogica)
        {
            _alumnoLogica = alumnoLogica;
        }

        [HttpGet("Listar")]
        public async Task<IActionResult> GetAlumnos()
        {
            var respose = await _alumnoLogica.GetAllAlumnos();
            return Ok(respose);
        }
        
        

        [HttpGet("ListarAlumnoByID")]
        public async Task<IActionResult> GetAlumnoById(int id)
        {
            var respose = await _alumnoLogica.GetAlumnoById(id);
            return Ok(respose);
        }
        

        [HttpPost("Registrar")]
        public async Task<IActionResult> RegistrarAlumno([FromBody] Alumno alumno)
        {
            var response =  await _alumnoLogica.RegisterAlumno(alumno);
            return Ok(response);
        }

        [HttpPut("Eliminar/{id:int}")]
        public async Task<IActionResult> EliminarAlumno(int id)
        {
         var respose = await _alumnoLogica.RemoveAlumno(id);    
            return Ok(respose);
        }

    }
}
