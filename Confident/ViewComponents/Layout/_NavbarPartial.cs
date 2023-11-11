using Microsoft.AspNetCore.Mvc;

namespace Confident.ViewComponents.Layout
{
    public class _NavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
