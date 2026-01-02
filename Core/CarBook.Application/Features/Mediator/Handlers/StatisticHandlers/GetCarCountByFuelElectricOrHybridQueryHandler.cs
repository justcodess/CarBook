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
    public class GetCarCountByFuelElectricOrHybridQueryHandler : IRequestHandler<GetCarCountByFuelElectricOrHybridQuery, GetCarCountByFuelElectricOrHybridQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarCountByFuelElectricOrHybridQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetCarCountByFuelElectricOrHybridQueryResult> Handle(GetCarCountByFuelElectricOrHybridQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByFuelElectricOrHybrid();
            return new GetCarCountByFuelElectricOrHybridQueryResult
            {
                CarCountByFuelElectricOrHybrid = value
            };
        }
    }
}
