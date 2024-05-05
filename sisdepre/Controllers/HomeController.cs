using Microsoft.AspNetCore.Mvc;
using sisdepre.Models;
using System.Diagnostics;

namespace sisdepre.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //retornar datos a la vista
            ViewData["Mensaje"] = "Hola Mundo";
            ViewData["Fecha"] = DateTime.Now;
            ViewData["Nombre"] = "Juan Perez";
            ViewData["Edad"] = 25;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Acerca()
        {
            return View();
        }
    }
}