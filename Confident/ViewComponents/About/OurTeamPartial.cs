using Microsoft.AspNetCore.Mvc;

namespace Confident.ViewComponents.About
{
    public class OurTeamPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
