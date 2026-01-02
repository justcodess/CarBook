using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace CarBook.webUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminStatistic")]
    public class AdminStatisticController : Controller
    {
       
        [Route("Index")]

        public async Task<IActionResult> Index()
        {
            return View();
        }
        
    }
}
