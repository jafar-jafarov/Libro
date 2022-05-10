using Microsoft.AspNetCore.Mvc;

namespace Libro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
