using CCFF.Modelo;
using CCFFF.Logica.LogicAlumno;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CCFF.Presetacion.Controllers
{
    public class AlumnoController : Controller
    {
        private readonly LogicaAlumno alumnos = new LogicaAlumno();

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(alumnos.GetAllAlumnos);
        }

        [HttpPost]

        public IActionResult Registrar(Alumno alumno)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    alumnos.AddAlumno(alumno);  
                    return RedirectToAction("Registrar");
                }
                return View();
            }catch (Exception error)
            {
                throw new DataException("Error al registrar", error);
            }
        }

        [HttpGet]
        public IActionResult DeleteAlumnos(int id)
        {
            try
            {
                var Alumno = alumnos.DeleteAlumno(id);

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
            var Alumno = alumnos.GetAlumnoById(id);
            return Json(Alumno);
        }
    }

   
}
