using Microsoft.AspNetCore.Mvc;

namespace Confident.Areas.Member.ViewComponents.Layout
{
    public class _MemberHeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
