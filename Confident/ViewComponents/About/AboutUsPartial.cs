using Microsoft.AspNetCore.Mvc;

namespace Confident.ViewComponents.About
{
    public class AboutUsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
