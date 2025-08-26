using CarBook.Application.Features.Mediator.Results.TestimonialResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialQuery:IRequest<List<GetTestimonialQueryResult>>
    {

    }
}
