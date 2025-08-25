using MediatR;
using CarBook.Application.Features.Mediator.Results.SocialMediaResults;

namespace CarBook.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaQuery: IRequest<List<GetSocialMediaQueryResult>>
    {
    }
}
