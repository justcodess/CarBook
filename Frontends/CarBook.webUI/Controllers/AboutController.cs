using Microsoft.AspNetCore.Mvc;

namespace CarBook.webUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
