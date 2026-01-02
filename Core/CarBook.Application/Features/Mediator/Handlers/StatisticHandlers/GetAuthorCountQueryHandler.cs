using CarBook.Application.Features.Mediator.Queries.StatisticQueries;
using CarBook.Application.Features.Mediator.Results.StatisticResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;

namespace AuthorBook.Application.Features.Mediator.Handlers.StatisticHandlers
{
    public class GetAuthorCountQueryHandler : IRequestHandler<GetAuthorCountQuery, GetAuthorCountQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetAuthorCountQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetAuthorCountQueryResult> Handle(GetAuthorCountQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAuthorCount();
            return new GetAuthorCountQueryResult
            {
                AuthorCount = value
            };
        }
    }
}
