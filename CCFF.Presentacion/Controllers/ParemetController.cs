using CCFF.Datos;
using CCFF.Modelo.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CCFF.Presentacion.Controllers
{
    public class ParemetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public List<Paremet> GetParamets()
        {
            using (var _conext = new AplicationDbContext(AplicationDbContext.ops.dbOptions))
            {

                return _conext.Paramets.ToList();

            }

        }

        public async Task<IActionResult> Registrar(int ParemetId, bool Statusnew)
        {
           

            var nuestarus = Statusnew;

            


            using (var _conext = new AplicationDbContext(AplicationDbContext.ops.dbOptions))
            {
                var dbParemet = await _conext.Paramets
                .FirstOrDefaultAsync(h => h.ParemetId == ParemetId);
                if (dbParemet == null)
                    return NotFound("Super Hero wasn't found. Too bad. :(");
                dbParemet.Status = Statusnew;
                await _conext.SaveChangesAsync();
                return Ok(dbParemet);
            }
        }
    }
}
