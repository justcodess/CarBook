using System;
using System.Collections.Generic;
using System.Linq;
using CarBook.Application.Features.Mediator.Queries.CarPricingWithCarsQueries;
using CarBook.Application.Features.Mediator.Results.CarPricingWithCarsResults;
using CarBook.Application.Interfaces.CarPricingInterface;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingWithCarsHandlers
{
    public class GetCarPricingWithTimePeriodQueryHandler : IRequestHandler<GetCarPricingWithTimePeriodQuery, List<GetCarPricingWithTimePeriodQueryResult>>
    {
        private readonly ICarPricingRepository _repository;
        public GetCarPricingWithTimePeriodQueryHandler(ICarPricingRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCarPricingWithTimePeriodQueryResult>> Handle(GetCarPricingWithTimePeriodQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarPricingWiewModelList();
            return values.Select(x => new GetCarPricingWithTimePeriodQueryResult
            {
                Model = x.Model,
                DailyPrice = x.Price[0],
                WeeklyPrice = x.Price[1],
                MontlyPrice = x.Price[2]
            }).ToList();
        }
    }
}
