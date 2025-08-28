using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Application.Features.Mediator.Results.CarPricingWithCarsResults;
using CarBook.Application.Interfaces.CarPricingInterface;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingWithCarsHandlers
{
    public class GetCarPricingWithCarsQueryHandler : IRequestHandler<GetCarPricingWithCarsQuery,
        List<GetCarPricingWithCarsQueryResult>>
    {
        private readonly ICarPricingRepository _repository;
        public GetCarPricingWithCarsQueryHandler(ICarPricingRepository repository)
        {
            _repository = repository;
        }



        public async Task<List<GetCarPricingWithCarsQueryResult>> Handle(GetCarPricingWithCarsQuery request, CancellationToken cancellationToken)
        {
            var values= _repository.GetCarPricingWithCars();
            return values.Select(x => new GetCarPricingWithCarsQueryResult
            {
                Price = x.Price,
                CarPricingID = x.CarPricingID,
                CoverImageUrl = x.Car.CoverImgUrl,
                Brand = x.Car.Brand.Name,
                Model = x.Car.Model

            }).ToList();
        }
    }
}

