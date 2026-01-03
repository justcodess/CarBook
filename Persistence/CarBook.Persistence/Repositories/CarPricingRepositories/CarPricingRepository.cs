using CarBook.Application.Interfaces.CarPricingInterface;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories.CarPricingRepositories
{
    public class CarPricingRepository : ICarPricingRepository
    {
        private readonly CarBookContext _context;
        public CarPricingRepository(CarBookContext context)
        {
            _context = context;
        }


        public List<CarPricing> GetCarPricingWithCars()
        {
            return _context.CarPricings
                .Include(x => x.Car)
                    .ThenInclude(y => y.Brand)
                .Include(z => z.Pricing)
                .ToList();
        }

    }


}
