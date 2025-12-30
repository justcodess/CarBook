using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CarBook.Dto.LocationDtos;


namespace CarBook.webUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminLocation")]
    public class AdminLocationController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminLocationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Route("Index")]

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7098/api/Location");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLocationDto>>(jsonData);
                return View(values);

            }
            return View();
        }
        [HttpGet]
        [Route("CreateLocation")]
        public async Task<IActionResult> CreateLocation()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7098/api/Location");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultLocationDto>>(jsonData);


            return View(new CreateLocationDto());

        }
        [HttpPost]
        [Route("CreateLocation")]
        public async Task<IActionResult> CreateLocation(CreateLocationDto createLocationDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createLocationDto);

            StringContent stringContent = new StringContent(
                jsonData,
                Encoding.UTF8,
                "application/json");

            var responseMessage = await client.PostAsync(
                "https://localhost:7098/api/Location",
                stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminLocation", new { area = "Admin" });
            }

            return View();
        }
        [Route("RemoveLocation/{id}")]
        public IActionResult RemoveLocation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = client.DeleteAsync($"https://localhost:7098/api/Location/{id}").Result;
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminLocation", new { area = "Admin" });
            }
            return View();
        }
        [HttpGet]
        [Route("UpdateLocation/{id}")]
        public async Task<IActionResult> UpdateLocation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7098/api/Location/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateLocationDto>(jsonData);


                return View(values);
            }
            return View();
        }
        [HttpPost]
        [Route("UpdateLocation/{id}")]
        public async Task<IActionResult> UpdateLocation(UpdateLocationDto updateLocationDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateLocationDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync($"https://localhost:7098/api/Location", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminLocation", new { area = "Admin" });
            }
            return View();

        }

    }
}
