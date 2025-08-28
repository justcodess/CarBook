using Microsoft.AspNetCore.Mvc;

namespace CarBook.webUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Home";
            ViewBag.v2 = "CarBook";
            return View();
        }
    }
}
