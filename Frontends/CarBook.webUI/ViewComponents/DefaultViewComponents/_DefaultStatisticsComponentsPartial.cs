using CarBook.Dto.StatisticDtos;
using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace CarBook.webUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultStatisticsComponentsPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DefaultStatisticsComponentsPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task< IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            #region GetCarCount
            var responseMessage = await client.GetAsync("https://localhost:7098/api/Statistic/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values1 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.CarCount = values1.CarCount;
            }
            #endregion

            #region GetLocationCount
            var responseMessage2 = await client.GetAsync("https://localhost:7098/api/Statistic/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData2);
                ViewBag.LocationCount = values2.LocationCount;

            }
            #endregion

            #region GetBrandCount
            var responseMessage5 = await client.GetAsync("https://localhost:7098/api/Statistic/GetBrandCount");
            if (responseMessage5.IsSuccessStatusCode)
            {
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var values5 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData5);
                ViewBag.BrandCount = values5.BrandCount;


            }
            #endregion

            #region GetDailyAveragePrice
            var responseMessage6 = await client.GetAsync("https://localhost:7098/api/Statistic/GetDailyAveragePrice");
            if (responseMessage6.IsSuccessStatusCode)
            {
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                var values6 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData6);
                ViewBag.DailyAvgCount = values6.DailyAveragePrice;


            }
            #endregion


            return View();
        }
    }
}
