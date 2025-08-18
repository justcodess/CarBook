using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using CarBook.Application.Features.CQRS.Commands.BannerCommands;

namespace CarBook.Application.Features.CQRS.Handlers.valuesHandlers
{
    public class UpdatevaluesCommandHandler
    {
        private readonly IRepository<Banner> _repository;
        public UpdatevaluesCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateBannerCommand command)
        {
            var values = await _repository.GetByIdAsync(command.BannerId);
            
            values.Title = command.Title;
            values.Description = command.Description;
            values.VideoDescription = command.VideoDescription;
            values.VideoUrl = command.VideoUrl;
            await _repository.UpdateAsync(values);
        }
    }
}
