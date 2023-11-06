using Microsoft.AspNetCore.Mvc;

namespace Confident.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
