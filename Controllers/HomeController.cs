using Microsoft.AspNetCore.Mvc;

namespace MvcViewEngineApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Works()
        {
            return View("Index");
        }
    }
}
