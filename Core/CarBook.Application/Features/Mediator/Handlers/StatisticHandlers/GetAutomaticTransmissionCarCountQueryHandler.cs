using CarBook.Application.Features.Mediator.Queries.StatisticQueries;
using CarBook.Application.Features.Mediator.Results.StatisticResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticHandlers
{
    public class GetAutomaticTransmissionCarCountQueryHandler : IRequestHandler<GetAutomaticTransmissionCarCountQuery, GetAutomaticTransmissionCarCountQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetAutomaticTransmissionCarCountQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetAutomaticTransmissionCarCountQueryResult> Handle(GetAutomaticTransmissionCarCountQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAutomaticTransmissionCarCount();
            return new GetAutomaticTransmissionCarCountQueryResult
            {
                AutomaticTransmissionCarCount = value
            };
        }
    }
}
