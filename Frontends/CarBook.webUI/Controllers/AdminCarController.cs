using Microsoft.AspNetCore.Mvc;

namespace CarBook.webUI.Controllers
{
    public class AdminCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
