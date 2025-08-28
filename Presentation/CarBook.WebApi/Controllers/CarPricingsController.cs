using MediatR;
using Microsoft.AspNetCore.Mvc;
using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarPricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }        

       
        [HttpGet]
        public async Task<IActionResult> GetCarPricingWithCarsList()
        {
            var values = await _mediator.Send(new GetCarPricingWithCarsQuery());
            return Ok(values);
        }

    }
}
