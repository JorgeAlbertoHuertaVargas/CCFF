
using CCFFF.Logica.ParametersLogica;
using Microsoft.AspNetCore.Mvc;

namespace CCFF.Presentacion.Controllers
{
    public class ParametersCcffController : Controller
    {
        private readonly LogicaParametersCcff parametersLogic = new LogicaParametersCcff();
        public IActionResult Index()
        {
            return View(parametersLogic.GetAllParametersSystem());
        }

        [HttpPost]
        public IActionResult Update(int id, string value, int state)
        {
            bool stateBool = true;
            if (state == 0)
            {
                stateBool = false;
            }
            parametersLogic.UpdateParametersSystem(id, value, stateBool);
            return RedirectToAction("Index");
        }
    }
}
