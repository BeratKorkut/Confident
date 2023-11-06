using Microsoft.AspNetCore.Mvc;

namespace Confident.ViewComponents.Home
{
    public class SearchPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
