using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.TagCLoudCommands
{
    public class CreateTagCloudCommand : IRequest
    {
        public string Title { get; set; }
        public int BlogID { get; set; }
    }
}
