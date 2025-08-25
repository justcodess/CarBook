using Microsoft.AspNetCore.Mvc;

namespace CarBook.webUI.ViewComponents.UILayoutViewComponents
{
    public class _NavbarUILayoutComponentsPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
