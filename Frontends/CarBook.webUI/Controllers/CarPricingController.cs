using Microsoft.AspNetCore.Mvc;

namespace CarBook.webUI.Controllers
{
    public class CarPricingController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Pricing";
            ViewBag.v2 = "Car Pricing";
            return View();
        }
    }
}
