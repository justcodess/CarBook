using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Results.CarPricingWithCarsResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.CarPricingWithCarsQueries
{
    public class GetCarPricingWithTimePeriodQuery: IRequest<List<GetCarPricingWithTimePeriodQueryResult>>
    {
    }
}
