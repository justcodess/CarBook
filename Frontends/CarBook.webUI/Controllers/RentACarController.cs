using Microsoft.AspNetCore.Mvc;

namespace CarBook.webUI.Controllers
{
    public class RentACarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
