using CarBook.Dto.BlogDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.webUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Blogs";
            ViewBag.v2 = "Our Blogs";

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7098/api/Blogs/GetAllBlogsWithAuthorList");
            Console.WriteLine(responseMessage.StatusCode);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<ResultAllBlogsWithAuthorDto>>(jsonData);
                return View(result);
            }

            return View();
        }
        public IActionResult BlogDetails(int id)
        {
            if (id == 0)
                return RedirectToAction("Index");

            ViewBag.v1 = "Blogs";
            ViewBag.v2 = "Blog Details";
            ViewBag.blogid = id;

            return View();
        }


    }
}
