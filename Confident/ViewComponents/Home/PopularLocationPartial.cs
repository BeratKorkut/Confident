using Microsoft.AspNetCore.Mvc;

namespace Confident.ViewComponents.Home
{
    public class PopularLocationPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
