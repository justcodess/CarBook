using CarBook.Dto.LocationDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace CarBook.webUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7098/api/Location");
            
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLocationDto>>(jsonData);
                List<SelectListItem>values2 =(from x in values select new SelectListItem
            {
                Text = x.Name,
                Value = x.LocationID.ToString()
            }).ToList();
            ViewBag.v = values2;

            return View();

        }
        [HttpPost]
        public IActionResult Index(string book_pick_date,string book_off_date,string time_pick,string time_off,string locationID)
        {
            TempData["BookPickDate"] = book_pick_date;
            TempData["BookOffDate"] = book_off_date;
            TempData["PickTime"] = time_pick;
            TempData["OffTime"] = time_off;
            TempData["Location"] = locationID;

            return RedirectToAction("Index", "RentACar");
        }
    }
}
