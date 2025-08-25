using Microsoft.AspNetCore.Mvc;

namespace CarBook.webUI.ViewComponents.AboutViewComponents
{
    public class _BecameADriverComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
