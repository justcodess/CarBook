using CarBook.Dto.ContactDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
 using System.Text;

namespace CarBook.webUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
       

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Contact";
            ViewBag.v2 = "Contact Us";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateContactDto createContactDto)
        {
            var client = _httpClientFactory.CreateClient();
            createContactDto.CreatedDate = DateTime.Now;
            var jsonData = JsonConvert.SerializeObject(createContactDto);
            StringContent stringContent = new StringContent(jsonData,Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7098/api/Contact", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                ViewBag.Message = "Message was sent";
                return RedirectToAction("Index", stringContent);
            }
            ViewBag.Message = "Message was not sent";
            return View();

        }

    }
}
