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
        public async Task< IActionResult> Index(FilterRentACarDto filterRentACarDto)
        {
        var BookPickDate = TempData["BookPickDate"] ;
            var BookOffDate = TempData["BookOffDate"];
            var PickTime = TempData["PickTime"];
            var OffTime = TempData["OffTime"];
            var Location = TempData["Location"];

            filterRentACarDto.LocationID = int.Parse(Location.ToString());
            filterRentACarDto.Available = true;


            ViewBag.BookPickDate = BookPickDate;
            ViewBag.BookOffDate = BookOffDate;
            ViewBag.PickTime = PickTime;
            ViewBag.OffTime = OffTime;
            ViewBag.Location = Location;


            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(filterRentACarDto) ;

            StringContent stringContent = new StringContent(
                jsonData,
                Encoding.UTF8,
                "application/json");

            var responseMessage = await client.PostAsync(
                "https://localhost:7098/api/RentACar",
                stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
           
        }
    }
}
