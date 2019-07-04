using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViagensNet.Models;

namespace ViagensNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Landing()
        {
            ViewData["Message"] = "Pagina da Landing Page.";

            return View();
        }

        public IActionResult Checkout()
        {
            ViewData["Message"] = "Página de Checkout.";

            return View();
        }


        public IActionResult Confirmacao()
        {
            ViewData["Message"] = "Página de confirmação.";

            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
