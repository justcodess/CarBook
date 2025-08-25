using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.ServicesQueries
{
    public class GetServiceByIdQuery: IRequest<GetServiceByIdQuery>
    {
        public int Id { get; set; }
        public GetServiceByIdQuery(int id)
        {
            Id = id;
        }
    }
}
