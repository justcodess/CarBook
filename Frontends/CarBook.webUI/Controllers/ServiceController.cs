using CarBook.Dto.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.webUI.Controllers
{
    public class ServiceController : Controller
    {
        
        public IActionResult Index()
        {
            ViewBag.v1 = "Service";
            ViewBag.v2 = "Our Services";

            return View();
        }
    }
}
