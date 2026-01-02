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
    public class GetMonthlyAveragePriceQueryHandler : IRequestHandler<GetMonthlyAveragePriceQuery, GetMonthlyAveragePriceQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetMonthlyAveragePriceQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetMonthlyAveragePriceQueryResult> Handle(GetMonthlyAveragePriceQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetMonthlyAveragePrice();
            return new GetMonthlyAveragePriceQueryResult
            {
                MonthlyAveragePrice = Convert.ToInt32(Math.Round(value))
            };
        }
    }
}
