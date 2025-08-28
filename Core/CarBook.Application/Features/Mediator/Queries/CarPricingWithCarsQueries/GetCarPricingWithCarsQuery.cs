using CarBook.Application.Features.Mediator.Results.CarPricingWithCarsResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.CarPricingQueries
{
    public class GetCarPricingWithCarsQuery:IRequest<List<GetCarPricingWithCarsQueryResult>>
    {
    }
}
