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
    public class GetBlogWithMostCommentsQueryHandler : IRequestHandler<GetBlogWithMostCommentsQuery, GetBlogWithMostCommentsQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetBlogWithMostCommentsQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetBlogWithMostCommentsQueryResult> Handle(GetBlogWithMostCommentsQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetBlogWithMostComments();
            return new GetBlogWithMostCommentsQueryResult
            {
                BlogWithMostComments = value
            };
        }
    }
}
