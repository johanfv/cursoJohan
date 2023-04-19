using Microsoft.AspNetCore.Mvc;

namespace EjemploOracle.mvc.Controllers
{
    public class test : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
