using Microsoft.AspNetCore.Mvc;

namespace Confident.Controllers
{
    public class AdvertController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
