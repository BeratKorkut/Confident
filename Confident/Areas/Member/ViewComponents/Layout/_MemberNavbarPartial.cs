using Microsoft.AspNetCore.Mvc;

namespace Confident.Areas.Member.ViewComponents.Layout
{
    public class _MemberNavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
