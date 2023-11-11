using Microsoft.AspNetCore.Mvc;

namespace Confident.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
