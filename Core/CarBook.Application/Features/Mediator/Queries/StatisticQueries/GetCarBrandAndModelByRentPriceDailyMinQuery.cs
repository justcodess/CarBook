using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Results.StatisticResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.StatisticQueries
{
    public class GetCarBrandAndModelByRentPriceDailyMinQuery:IRequest<GetCarBrandAndModelByRentPriceDailyMinQueryResult>
    {
    }
}
