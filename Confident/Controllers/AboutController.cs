using Microsoft.AspNetCore.Mvc;

namespace Confident.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
