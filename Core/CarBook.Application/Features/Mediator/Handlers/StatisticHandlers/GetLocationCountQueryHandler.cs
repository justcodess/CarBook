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
    public class GetLocationCountQueryHandler : IRequestHandler<GetLocationCountQuery, GetLocationCountQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetLocationCountQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetLocationCountQueryResult> Handle(GetLocationCountQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetLocationCount();
            return new GetLocationCountQueryResult
            {
                LocationCount = value
            };
        }
    }
}
