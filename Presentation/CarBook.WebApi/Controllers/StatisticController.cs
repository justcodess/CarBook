using CarBook.Application.Features.Mediator.Queries.StatisticQueries;
using CarBook.Application.Interfaces.CarInterfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StatisticController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCarCount")]
        public async Task<IActionResult> GetCarCount()
        {
            var values = await _mediator.Send(new GetCarCountQuery());
            return Ok(values);
        }

        [HttpGet("GetAuthorCount")]
        public async Task<IActionResult> GetAuthorCount()
        {
            var values = await _mediator.Send(new GetAuthorCountQuery());
            return Ok(values);
        }

        [HttpGet("GetLocationCount")]
        public async Task<IActionResult> GetLocationCount()
        {
            var values = await _mediator.Send(new GetLocationCountQuery());
            return Ok(values);
        }

        [HttpGet("GetBlogCount")]
        public async Task<IActionResult> GetBlogCount()
        {
            var values = await _mediator.Send(new GetBlogCountQuery());
            return Ok(values);
        }

        [HttpGet("GetBrandCount")]
        public async Task<IActionResult> GetBrandCount()
        {
            var values = await _mediator.Send(new GetBrandCountQuery());
            return Ok(values);
        }

        [HttpGet("GetDailyAveragePrice")]
        public async Task<IActionResult> GetDailyAveragePrice()
        {
            var values = await _mediator.Send(new GetDailyAveragePriceQuery());
            return Ok(values);
        }

        [HttpGet("GetWeeklyAveragePrice")]
        public async Task<IActionResult> GetWeeklyAveragePrice()
        {
            var values = await _mediator.Send(new GetWeeklyAveragePriceQuery());
            return Ok(values);
        }

        [HttpGet("GetMonthlyAveragePrice")]
        public async Task<IActionResult> GetMonthlyAveragePrice()
        {
            var values = await _mediator.Send(new GetMonthlyAveragePriceQuery());
            return Ok(values);
        }

        [HttpGet("GetAutomaticTransmissionCarCount")]
        public async Task<IActionResult> GetAutomaticTransmissionCarCount()
        {
            var values = await _mediator.Send(new GetAutomaticTransmissionCarCountQuery());
            return Ok(values);
        }

        [HttpGet("GetBrandWithMostCars")]
        public async Task<IActionResult> GetBrandWithMostCars()
        {
            var values = await _mediator.Send(new GetBrandWithMostCarsQuery());
            return Ok(values);
        }

        [HttpGet("GetBlogWithMostComments")]
        public async Task<IActionResult> GetBlogWithMostComments()
        {
            var values = await _mediator.Send(new GetBlogWithMostCommentsQuery());
            return Ok(values);
        }

        [HttpGet("GetCarCountByKmLessThan1000")]
        public async Task<IActionResult> GetCarCountByKmLessThan1000()
        {
            var values = await _mediator.Send(new GetCarCountByKmLessThan1000Query());
            return Ok(values);
        }

        [HttpGet("GetCarCountByFuelGasolineOrDiesel")]
        public async Task<IActionResult> GetCarCountByFuelGasolineOrDiesel()
        {
            var values = await _mediator.Send(new GetCarCountByFuelGasolineOrDieselQuery());
            return Ok(values);
        }

        [HttpGet("GetCarCountByFuelElectricOrHybrid")]
        public async Task<IActionResult> GetCarCountByFuelElectricOrHybrid()
        {
            var values = await _mediator.Send(new GetCarCountByFuelElectricOrHybridQuery());
            return Ok(values);
        }

        [HttpGet("GetCarBrandAndModelByRentPriceDailyMax")]
        public async Task<IActionResult> GetCarBrandAndModelByRentPriceDailyMax()
        {
            var values = await _mediator.Send(new GetCarBrandAndModelByRentPriceDailyMaxQuery());
            return Ok(values);
        }

        [HttpGet("GetCarBrandAndModelByRentPriceDailyMin")]
        public async Task<IActionResult> GetCarBrandAndModelByRentPriceDailyMin()
        {
            var values = await _mediator.Send(new GetCarBrandAndModelByRentPriceDailyMinQuery());
            return Ok(values);
        }




    }

}

