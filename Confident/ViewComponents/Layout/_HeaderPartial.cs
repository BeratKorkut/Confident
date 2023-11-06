using Microsoft.AspNetCore.Mvc;

namespace Confident.ViewComponents.Layout
{
    public class _HeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
