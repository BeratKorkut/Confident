using Microsoft.AspNetCore.Mvc;

namespace Confident.ViewComponents.About
{
    public class WhyUsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
