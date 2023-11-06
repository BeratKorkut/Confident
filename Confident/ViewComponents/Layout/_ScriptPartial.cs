using Microsoft.AspNetCore.Mvc;

namespace Confident.ViewComponents.Layout
{
    public class _ScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
