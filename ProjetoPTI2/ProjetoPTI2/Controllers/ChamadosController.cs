using Microsoft.AspNetCore.Mvc;

namespace ProjetoPTI2.Controllers
{
    public class ChamadosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
