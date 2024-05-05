using Microsoft.AspNetCore.Mvc;

namespace sisdepre.Controllers
{
    public class PerfilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string getName()
        {
            return "Juan Perez";
        }

        public IActionResult Mensajes()
        {
            return View();
        }   
    }
}
