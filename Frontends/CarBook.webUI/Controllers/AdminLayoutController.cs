using Microsoft.AspNetCore.Mvc;

namespace CarBook.webUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
