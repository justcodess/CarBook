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
    public class GetWeeklyAveragePriceQueryHandler : IRequestHandler<GetWeeklyAveragePriceQuery, GetWeeklyAveragePriceQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetWeeklyAveragePriceQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetWeeklyAveragePriceQueryResult> Handle(GetWeeklyAveragePriceQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetWeeklyAveragePrice();
            return new GetWeeklyAveragePriceQueryResult
            {
                WeeklyAveragePrice = Convert.ToInt32(Math.Round(value))
            };
        }
    }
}
