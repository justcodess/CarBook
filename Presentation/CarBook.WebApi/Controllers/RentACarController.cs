using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using CarBook.Application.Features.Mediator.Queries.RentACarQueries;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentACarController : ControllerBase
    {
        private readonly IMediator _mediator;
        public RentACarController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpPost]
        public async Task<IActionResult> GetRentACarListByLocation(GetRentACarQuery query)
        {
            var values = await _mediator.Send(query);
            return Ok(values);
        }

    }
}
