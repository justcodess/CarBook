using Microsoft.AspNetCore.Mvc;
namespace CarBook.webUI.ViewComponents.UILayoutViewComponents
{
    public class _MainCoverUILayoutComponentsPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    
}
