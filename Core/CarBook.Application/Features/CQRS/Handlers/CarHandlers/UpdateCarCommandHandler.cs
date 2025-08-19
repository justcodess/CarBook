using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Domain.Entities;
using CarBook.Application.Interfaces;
using CarBook.Application.Features.CQRS.Commands.CarCommands;


namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;
        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repository.GetByIdAsync(command.CarID);

            values.BrandID = command.BrandID;
            values.CoverImgUrl = command.CoverImgUrl;
            values.Model = command.Model;
            values.Km = command.Km;
            values.Transmission = command.Transmission;
            values.Seat = command.Seat;
            values.Luggage = command.Luggage;
            values.Fuel = command.Fuel;
            values.BigImgUrl = command.BigImgUrl;
            await _repository.UpdateAsync(values);
        }
    }
}
