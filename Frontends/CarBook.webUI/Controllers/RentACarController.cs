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
            var Location = TempData["Location"];

            id = int.Parse(Location.ToString());

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
