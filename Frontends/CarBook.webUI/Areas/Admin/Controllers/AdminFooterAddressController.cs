using CarBook.Dto.FooterAddressDtos;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CarBook.Dto.BlogDtos;

namespace CarBook.webUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminFooterAddress")]
    public class AdminFooterAddressController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminFooterAddressController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Route("Index")]

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7098/api/FooterAddress");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFooterAddressDto>>(jsonData);
                return View(values);

            }
            return View();
        }
        [HttpGet]
        [Route("CreateFooterAddress")]
        public async Task<IActionResult> CreateFooterAddress()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7098/api/FooterAddress");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultFooterAddressDto>>(jsonData);


            return View();

        }
        [HttpPost]
        [Route("CreateFooterAddress")]
        public async Task<IActionResult> CreateFooterAddress(CreateFooterAddressDto createFooterAddressDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createFooterAddressDto);

            StringContent stringContent = new StringContent(
                jsonData,
                Encoding.UTF8,
                "application/json");

            var responseMessage = await client.PostAsync(
                "https://localhost:7098/api/FooterAddress",
                stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminFooterAddress", new { area = "Admin" });
            }

            return View();
        }
        [Route("RemoveFooterAddress/{id}")]
        public IActionResult RemoveFooterAddress(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = client.DeleteAsync($"https://localhost:7098/api/FooterAddress/{id}").Result;
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminFooterAddress", new { area = "Admin" });
            }
            return View();
        }
        [HttpGet]
        [Route("UpdateFooterAddress/{id}")]
        public async Task<IActionResult> UpdateFooterAddress(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7098/api/FooterAddress/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateFooterAddressDto>(jsonData);


                return View(values);
            }
            return View();
        }
        [HttpPost]
        [Route("UpdateFooterAddress/{id}")]
        public async Task<IActionResult> UpdateFooterAddress(UpdateFooterAddressDto updateFooterAddressDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateFooterAddressDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync($"https://localhost:7098/api/FooterAddress", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminFooterAddress", new { area = "Admin" });
            }
            return View();

        }
    }
}
