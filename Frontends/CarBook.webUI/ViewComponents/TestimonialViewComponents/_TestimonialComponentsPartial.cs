using CarBook.Dto.TestimonialDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace CarBook.webUI.ViewComponents.TestimonialViewComponents
{
    public class _TestimonialComponentsPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _TestimonialComponentsPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7098/api/Testimonial");
            if(responseMessage.IsSuccessStatusCode )
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
                return View(result);
            }
            return View();

        }
    }
}
