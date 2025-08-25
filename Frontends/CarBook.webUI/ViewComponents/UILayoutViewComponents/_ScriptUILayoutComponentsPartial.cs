using Microsoft.AspNetCore.Mvc;
namespace CarBook.webUI.ViewComponents.UILayoutViewComponents
{
    public class _ScriptUILayoutComponentsPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    
}
