using Microsoft.AspNetCore.Mvc;

namespace Confident.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index(int code)
        {
            return View();
		}
		public IActionResult AccessDenied()
		{
			return View();
		}
	}
}
