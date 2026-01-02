using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Queries.StatisticQueries;
using CarBook.Application.Features.Mediator.Results.StatisticResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticHandlers
{
    public class GetBrandWithMostCarsQueryHandler : IRequestHandler<GetBrandWithMostCarsQuery, GetBrandWithMostCarsQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetBrandWithMostCarsQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetBrandWithMostCarsQueryResult> Handle(GetBrandWithMostCarsQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetBrandWithMostCars();
            return new GetBrandWithMostCarsQueryResult
            {
                BrandWithMostCars = value
            };
        }
    }
}
