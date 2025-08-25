using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.ServiceCommands
{
    public class RemoveServiceCommand: IRequest
    {
        public int Id { get; set; }

        public RemoveServiceCommand(int id)
        {
            Id = id;
        }
    }
}
