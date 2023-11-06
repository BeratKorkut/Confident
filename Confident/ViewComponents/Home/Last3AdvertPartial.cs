using Microsoft.AspNetCore.Mvc;

namespace Confident.ViewComponents.Home
{
    public class Last3AdvertPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
