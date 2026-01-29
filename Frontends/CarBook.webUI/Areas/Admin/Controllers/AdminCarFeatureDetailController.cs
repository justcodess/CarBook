using System.Text;
using CarBook.Dto.CarFeatureDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.webUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminCarFeatureDetail")]
    public class AdminCarFeatureDetailController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminCarFeatureDetailController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Route("Index/{id}")]
        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7098/api/CarFeatures?id="+ id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarFeatureByCarIdDto>>(jsonData);
                return View(values);

            }
            return View();
        }

        //[HttpPost]
        //[Route("Index")]
        //public async Task<IActionResult> Index(List<ResultCarFeatureByCarIdDto> resultCarFeatureByCarIdDto)
        //{
        //    foreach(var item in resultCarFeatureByCarIdDto)
        //    {
        //        if (item.Available)
        //        {
        //            var client = _httpClientFactory.CreateClient();
        //            var jsonData = JsonConvert.SerializeObject(resultCarFeatureByCarIdDto);
        //            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        //            var responseMessage = await client.PutAsync($"https://localhost:7098/api/Category", stringContent);
        //            if (responseMessage.IsSuccessStatusCode)
        //            {
        //                return RedirectToAction("Index", "AdminCategory", new { area = "Admin" });
        //            }
        //            return View();

        //        }
        //        else
        //        {
                        
        //        }
        //    }
                
            
        //}

    }
}
