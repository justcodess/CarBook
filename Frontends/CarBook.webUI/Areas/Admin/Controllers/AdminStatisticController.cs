using System.Text;
using CarBook.Dto.StatisticDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace CarBook.webUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminStatistic")]
    public class AdminStatisticController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminStatisticController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Route("Index")]

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            Random random = new Random();

            #region GetCarCount
            var responseMessage = await client.GetAsync("https://localhost:7098/api/Statistic/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                int CarRandomNumber = random.Next(1, 100);
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.CarCount = values.CarCount;
                ViewBag.CarRandomNumber = CarRandomNumber;


            }
            #endregion

            #region GetLocationCount
            var responseMessage2 = await client.GetAsync("https://localhost:7098/api/Statistic/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                int LocationRandomNumber = random.Next(1, 100);
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData2);
                ViewBag.LocationCount = values2.LocationCount;
                ViewBag.LocationRandomNumber = LocationRandomNumber;


            }
            #endregion

            #region GetAuthorCount
            var responseMessage3 = await client.GetAsync("https://localhost:7098/api/Statistic/GetAuthorCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                int AuthorRandomNumber = random.Next(1, 100);
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData3);
                ViewBag.AuthorCount = values3.AuthorCount;
                ViewBag.AuthorRandomNumber = AuthorRandomNumber;


            }
            #endregion

            #region GetBlogCount
            var responseMessage4 = await client.GetAsync("https://localhost:7098/api/Statistic/GetBlogCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                int BlogRandomNumber = random.Next(1, 100);
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData4);
                ViewBag.BlogCount = values4.BlogCount;
                ViewBag.BlogRandomNumber = BlogRandomNumber;


            }
            #endregion

            #region GetBrandCount
            var responseMessage5 = await client.GetAsync("https://localhost:7098/api/Statistic/GetBrandCount");
            if (responseMessage5.IsSuccessStatusCode)
            {
                int BrandRandomNumber = random.Next(1, 100);
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var values5 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData5);
                ViewBag.BrandCount = values5.BrandCount;
                ViewBag.BrandRandomNumber = BrandRandomNumber;


            }
            #endregion

            #region GetDailyAveragePrice
            var responseMessage6 = await client.GetAsync("https://localhost:7098/api/Statistic/GetDailyAveragePrice");
            if (responseMessage6.IsSuccessStatusCode)
            {
                int DailyAvgRandomNumber = random.Next(1, 100);
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                var values6 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData6);
                ViewBag.DailyAvgCount = values6.DailyAveragePrice;
                ViewBag.DailyAvgRandomNumber = DailyAvgRandomNumber;


            }
            #endregion

            #region GetWeeklyAveragePrice
            var responseMessage7 = await client.GetAsync("https://localhost:7098/api/Statistic/GetWeeklyAveragePrice");
            if (responseMessage7.IsSuccessStatusCode)
            {
                int WeeklyAvgRandomNumber = random.Next(1, 100);
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                var values7 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData7);
                ViewBag.WeeklyAvgCount = values7.WeeklyAveragePrice;
                ViewBag.WeeklyAvgRandomNumber = WeeklyAvgRandomNumber;


            }
            #endregion

            #region GetMonthlyAveragePrice
            var responseMessage8 = await client.GetAsync("https://localhost:7098/api/Statistic/GetMonthlyAveragePrice");
            if (responseMessage8.IsSuccessStatusCode)
            {
                int MonthlyAvgRandomNumber = random.Next(1, 100);
                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
                var values8 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData8);
                ViewBag.MonthlyAvgCount = values8.MonthlyAveragePrice;
                ViewBag.MonthlyAvgRandomNumber = MonthlyAvgRandomNumber;


            }
            #endregion

            #region GetAutomaticTransmissionCarCount
            var responseMessage9 = await client.GetAsync("https://localhost:7098/api/Statistic/GetAutomaticTransmissionCarCount");
            if (responseMessage9.IsSuccessStatusCode)
            {
                int AutoTransRandomNumber = random.Next(1, 100);
                var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
                var values9 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData9);
                ViewBag.AutomaticTransmissionCarCount = values9.AutomaticTransmissionCarCount;
                ViewBag.AutoTransRandomNumber = AutoTransRandomNumber;


            }
            #endregion

            #region GetBrandWithMostCars
            var responseMessage00 = await client.GetAsync("https://localhost:7098/api/Statistic/GetBrandWithMostCars");
            if (responseMessage00.IsSuccessStatusCode)
            {
                int BrandWithMostCarsRandomNumber = random.Next(1, 100);
                var jsonData00 = await responseMessage00.Content.ReadAsStringAsync();
                var values00 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData00);
                ViewBag.BrandWithMostCars = values00.BrandWithMostCars;
                ViewBag.BrandWithMostCarsRandomNumber = BrandWithMostCarsRandomNumber;


            }
            #endregion

            #region GetBlogWithMostComments
            var responseMessage11 = await client.GetAsync("https://localhost:7098/api/Statistic/GetBlogWithMostComments");
            if (responseMessage11.IsSuccessStatusCode)
            {
                int BlogWithMostCommentsRandomNumber = random.Next(1, 100);
                var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
                var values11 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData11);
                ViewBag.BlogWithMostComments = values11.BlogWithMostComments;
                ViewBag.BlogWithMostCommentsRandomNumber = BlogWithMostCommentsRandomNumber;


            }
            #endregion

            #region GetCarCountByKmLessThan1000
            var responseMessage22 = await client.GetAsync("https://localhost:7098/api/Statistic/GetCarCountByKmLessThan1000");
            if (responseMessage22.IsSuccessStatusCode)
            {
                int LessThan1kRandomNumber = random.Next(1, 100);
                var jsonData22 = await responseMessage22.Content.ReadAsStringAsync();
                var values22 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData22);
                ViewBag.LessThan1k = values22.CarCountByKmLessThan1000;
                ViewBag.LessThan1kRandomNumber = LessThan1kRandomNumber;


            }
            #endregion

            #region GetCarCountByFuelGasolineOrDiesel
            var responseMessage33 = await client.GetAsync("https://localhost:7098/api/Statistic/GetCarCountByFuelGasolineOrDiesel");
            if (responseMessage33.IsSuccessStatusCode)
            {
                int FuelGasolineOrDieselRandomNumber = random.Next(1, 100);
                var jsonData33 = await responseMessage33.Content.ReadAsStringAsync();
                var values33 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData33);
                ViewBag.FuelGasolineOrDiesel= values33.CarCountByFuelGasolineOrDiesel;
                ViewBag.FuelGasolineOrDieselRandomNumber = FuelGasolineOrDieselRandomNumber;


            }
            #endregion

            #region GetCarCountByFuelElectricOrHybrid
            var responseMessage44 = await client.GetAsync("https://localhost:7098/api/Statistic/GetCarCountByFuelElectricOrHybrid");
            if (responseMessage44.IsSuccessStatusCode)
            {
                int ElectricOrHybridRandomNumber = random.Next(1, 100);
                var jsonData44 = await responseMessage44.Content.ReadAsStringAsync();
                var values44 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData44);
                ViewBag.ElectricOrHybrid = values44.CarCountByFuelElectricOrHybrid;
                ViewBag.ElectricOrHybridRandomNumber = ElectricOrHybridRandomNumber;


            }
            #endregion

            #region GetCarBrandAndModelByRentPriceDailyMax
            var responseMessage55 = await client.GetAsync("https://localhost:7098/api/Statistic/GetCarBrandAndModelByRentPriceDailyMax");
            if (responseMessage55.IsSuccessStatusCode)
            {
                int PriceDailyMaxRandomNumber = random.Next(1, 100);
                var jsonData55 = await responseMessage55.Content.ReadAsStringAsync();
                var values55 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData55);
                ViewBag.PriceDailyMax = values55.CarBrandAndModelByRentPriceDailyMax;
                ViewBag.PriceDailyMaxRandomNumber = PriceDailyMaxRandomNumber;


            }
            #endregion

            #region GetCarBrandAndModelByRentPriceDailyMin
            var responseMessage66 = await client.GetAsync("https://localhost:7098/api/Statistic/GetCarBrandAndModelByRentPriceDailyMin");
            if (responseMessage66.IsSuccessStatusCode)
            {
                int PriceDailyMinRandomNumber = random.Next(1, 100);
                var jsonData66 = await responseMessage66.Content.ReadAsStringAsync();
                var values66 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData66);
                ViewBag.PriceDailyMin = values66.CarBrandAndModelByRentPriceDailyMin;
                ViewBag.PriceDailyMinRandomNumber = PriceDailyMinRandomNumber;


            }
            #endregion


            return View();
        }
    }
}
