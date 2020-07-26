using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class HomeController : Controller
    {
        public HomeController() { }

        public IActionResult Index()
        {
            return View();
        }
    }
}
