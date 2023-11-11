using Microsoft.AspNetCore.Mvc;

namespace Confident.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
