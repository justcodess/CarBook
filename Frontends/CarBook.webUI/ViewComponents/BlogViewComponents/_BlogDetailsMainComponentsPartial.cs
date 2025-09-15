using Microsoft.AspNetCore.Mvc;

namespace CarBook.webUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsMainComponentsPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
