using CCFF.Modelo;
using CCFF.Presentacion.Models.ViewModel;
using CCFFF.Logica.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CCFF.Presentacion.Controllers
{
    public class AlumnoController : Controller
    {
        private readonly IAlumnoLogica _alumnoLogica;
        public AlumnoController(IAlumnoLogica alumnoLogica)
        {
            _alumnoLogica = alumnoLogica;
        }

        public IActionResult Registrar()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            IEnumerable<Alumno> alumnos = await _alumnoLogica.GetAllAlumnos();
            List<AlumnoVM> lista = alumnos
                .Select(x => new AlumnoVM()
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido,
                    Codigo = x.Codigo,
                    Dni = x.Dni,
                    correo = x.correo,
                    celular = x.celular,


                }).ToList();

            return View(lista);
        }

        [HttpPost]

        public async Task<IActionResult> Registrar(Alumno alumno)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //Alumno alum = new Alumno()
                    //{
                    //    Nombre = alumno.Nombre,
                    //    Apellido = alumno.Apellido,
                    //    Codigo = alumno.Codigo,
                    //    Dni = alumno.Dni,
                    //    correo = alumno.correo,
                    //    celular = alumno.celular,

                    //};

                    await _alumnoLogica.RegisterAlumno(alumno);
                    return RedirectToAction("Listar");
                }
                return View();
            }
            catch (Exception error)
            {
                throw new DataException("Error al registrar", error);
            }
        }

        [HttpGet]
        public IActionResult DeleteAlumnos(int id)
        {
            try
            {
                var Alumno = _alumnoLogica.RemoveAlumno(id);

                return RedirectToAction("Listar");

            }
            catch (Exception error)
            {
                throw new DataException("Error al eliminar datos.", error);
            }
        }

        [HttpGet]
        public ActionResult GetAlumnoById(int id)
        {
            var Alumno = _alumnoLogica.GetAlumnoById(id);
            return Json(Alumno);
        }
    }
}