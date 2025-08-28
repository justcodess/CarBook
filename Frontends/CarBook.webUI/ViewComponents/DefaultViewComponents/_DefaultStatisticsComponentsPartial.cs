using Microsoft.AspNetCore.Mvc;

namespace CarBook.webUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultStatisticsComponentsPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
