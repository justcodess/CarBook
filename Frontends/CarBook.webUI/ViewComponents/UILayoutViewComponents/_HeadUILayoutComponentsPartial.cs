using Microsoft.AspNetCore.Mvc;

namespace CarBook.webUI.ViewComponents.UILayoutViewComponents
{
    public class _HeadUILayoutComponentsPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
