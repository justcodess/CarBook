using Microsoft.AspNetCore.Mvc;

namespace CarBook.webUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public object JsonDataConvert { get; private set; }

        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var JsonData = JsonDataConvert.SerializeObject();


        }
    }
}
