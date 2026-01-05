using CarBook.Dto.BrandDtos;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CarBook.Dto.RentACarDtos;

namespace CarBook.webUI.Controllers
{
    public class RentACarController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;
        public RentACarController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task< IActionResult> Index(int id)
        {
        var BookPickDate = TempData["BookPickDate"] ;
            var BookOffDate = TempData["BookOffDate"];
            var PickTime = TempData["PickTime"];
            var OffTime = TempData["OffTime"];
            var Location = TempData["Location"];

            //filterRentACarDto.LocationID = int.Parse(Location.ToString());
            //filterRentACarDto.Available = true;
            id = int.Parse(Location.ToString());


            ViewBag.BookPickDate = BookPickDate;
            ViewBag.BookOffDate = BookOffDate;
            ViewBag.PickTime = PickTime;
            ViewBag.OffTime = OffTime;
            ViewBag.Location = Location;


            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7098/api/RentACar?LocationID={id}&Available=true" );
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FilterRentACarDto>>(jsonData);
                return View(values);

            }
            return View();

        }
    }
}
