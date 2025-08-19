using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly IRepository<Car> _repository;
        public GetCarWithBrandQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCarWithBrandQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCarWithBrandQueryResult
            {
                BigImgUrl = x.BigImgUrl,
                BrandID = x.BrandID,
                BrandName = x.Brand.Name, // Assuming the Brand navigation property is available
                CarID = x.CarID,
                CoverImgUrl = x.CoverImgUrl,
                Fuel = x.Fuel,
                Km = x.Km,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Transmission = x.Transmission


            }).ToList();
        }
    }
}
