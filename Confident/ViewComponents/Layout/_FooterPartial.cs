using Microsoft.AspNetCore.Mvc;

namespace Confident.ViewComponents.Layout
{
    public class _FooterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
