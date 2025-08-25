using Microsoft.AspNetCore.Mvc;
namespace CarBook.webUI.ViewComponents.UILayoutViewComponents
{
    public class _FooterUILayoutComponentsPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
   
}
