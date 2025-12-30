using CarBook.Dto.ContactDtos;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CarBook.Dto.BlogDtos;
using CarBook.Dto.CommentDtos;

namespace CarBook.webUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminContact")]
    public class AdminContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Route("Index")]

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7098/api/Contact");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonData);
                return View(values);

            }
            return View();
        }
        
        [Route("RemoveContact/{id}")]
        public IActionResult RemoveContact(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = client.DeleteAsync($"https://localhost:7098/api/Contact/{id}").Result;
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminContact", new { area = "Admin" });
            }
            return View();
        }
        
    }
}
