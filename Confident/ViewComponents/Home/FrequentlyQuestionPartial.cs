using Microsoft.AspNetCore.Mvc;

namespace Confident.ViewComponents.Home
{
    public class FrequentlyQuestionPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
