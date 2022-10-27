using Microsoft.AspNetCore.Mvc;

namespace ProjetoPTI2.Controllers
{
    public class Chamados_inicial_Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
