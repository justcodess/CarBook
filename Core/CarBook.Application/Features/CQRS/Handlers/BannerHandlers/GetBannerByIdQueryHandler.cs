using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.CQRS.Queries.BannerQueries;
using CarBook.Domain.Entities;
using CarBook.Application.Interfaces;
using CarBook.Application.Features.CQRS.Results.BannerResults;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler
    {
        private readonly IRepository<Banner> _repository;
        public GetBannerByIdQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);

            return new GetBannerByIdQueryResult
            {
                BannerId = values.BannerId,
                Title = values.Title,
                Description = values.Description,
                VideoDescription = values.VideoDescription,
                VideoUrl = values.VideoUrl
            };
        }
    }
}
