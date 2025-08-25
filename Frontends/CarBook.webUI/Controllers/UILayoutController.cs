using Microsoft.AspNetCore.Mvc;

namespace CarBook.webUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
