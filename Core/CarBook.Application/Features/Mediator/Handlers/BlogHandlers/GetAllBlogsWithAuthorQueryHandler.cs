using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Features.Mediator.Results.CarPricingWithCarsResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetAllBlogsWithAuthorQueryHandler : IRequestHandler<GetAllBlogsWithAuthorQuery, List<GetAllBlogsWithAuthorQueryResult>>
    {
        private readonly IRepository<Blog> _repository;
        public GetAllBlogsWithAuthorQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAllBlogsWithAuthorQueryResult>> Handle(GetAllBlogsWithAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetAllBlogsWithAuthor();
            return values.Select(x => new GetAllBlogsWithAuthorQueryResult
            {
                Title = x.Title,
                AuthorID = x.AuthorID,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                BlogID = x.BlogID,
                CategoryID = x.CategoryID,
                CategoryName= x.Category.CategoryName,
                AuthorName = x.Author.Name 


            }).ToList();
        }
    }
}
