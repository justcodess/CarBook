using CarBook.webUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarBook.webUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index page has been opened.");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Privacy page has been opened.");
            return View();
        }

        public IActionResult Error()
        {
            _logger.LogError("An error has occurred. RequestId: {RequestId}",
                Activity.Current?.Id ?? HttpContext.TraceIdentifier);

            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }

    }
}
