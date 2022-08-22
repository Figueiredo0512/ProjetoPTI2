using Microsoft.AspNetCore.Mvc;
using ProjetoPTI2.Models;
using System.Collections.Generic;

namespace ProjetoPTI2.Controllers
{
    public class LoginsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
