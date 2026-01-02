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
    public class GetCarCountByKmLessThan1000QueryHandler : IRequestHandler<GetCarCountByKmLessThan1000Query, GetCarCountByKmLessThan1000QueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarCountByKmLessThan1000QueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetCarCountByKmLessThan1000QueryResult> Handle(GetCarCountByKmLessThan1000Query request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByKmLessThan1000();
            return new GetCarCountByKmLessThan1000QueryResult
            {
                CarCountByKmLessThan1000 = value
            };
        }
    }
}
