using System.Text;
using CarBook.Dto.BlogDtos;
using CarBook.Dto.CommentDtos;
using CarBook.Dto.LocationDtos;
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
        public async Task<IActionResult> BlogDetails(int id)
        {

            if (id == 0)
                return RedirectToAction("Index");

            ViewBag.v1 = "Blogs";
            ViewBag.v2 = "Blog Details";
            ViewBag.blogid = id;

            var client = _httpClientFactory.CreateClient();
            var responseMessage2 = await client.GetAsync($"https://localhost:7098/api/Comments/CommentCountByBlog?id=" + id);
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.commentCount = jsonData2;

            return View();
        }
        [HttpGet]
        public PartialViewResult  AddComment(int id)
        {
            ViewBag.blogid = id;
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> AddComment(CreateCommentDto createCommentDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createCommentDto);

            StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");

            var responseMessage = await client.PostAsync(
                "https://localhost:7098/api/Comments/CreateCommentWithMediator",
                stringContent);


            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Default");
            }

            return View();

        }

    }
}
