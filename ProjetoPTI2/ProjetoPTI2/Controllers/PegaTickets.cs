using Microsoft.AspNetCore.Mvc;

namespace ProjetoPTI2.Controllers
{
    public class PegaTickets : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
