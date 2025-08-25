using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.PricingCommands
{
    public class CreatePricingCommand: IRequest
    {
        public string Name { get; set; }
    }
}
