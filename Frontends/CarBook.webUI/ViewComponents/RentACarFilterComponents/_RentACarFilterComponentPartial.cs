using Microsoft.AspNetCore.Mvc;

namespace   CarBook.webUI.ViewComponents.RentACarFilterComponents
{
    public class _RentACarFilterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
