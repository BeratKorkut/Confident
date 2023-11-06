using Microsoft.AspNetCore.Mvc;

namespace Confident.ViewComponents.Home
{
    public class WhoAreWePartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
