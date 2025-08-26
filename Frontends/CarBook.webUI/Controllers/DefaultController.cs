using Microsoft.AspNetCore.Mvc;

namespace CarBook.webUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
