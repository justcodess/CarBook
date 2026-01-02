using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using CarBook.Persistence.Context;

namespace CarBook.Persistence.Repositories.StatisticsRepositories
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly CarBookContext _context;
        public StatisticsRepository(CarBookContext context)
        {
            _context = context;
        }

        public int GetAuthorCount()
        {
            var value = _context.Authors.Count();
            return value;
        }

        public int GetAutomaticTransmissionCarCount()
        {
            var value = _context.Cars.Where(x => x.Transmission == "Automatic").Count();
            return value;
        }

        public int GetBlogCount()
        {
            var value = _context.Blogs.Count();
            return value;
        }

        public string GetBlogWithMostComments()
        {
            var value = _context.Blogs
                .OrderByDescending(b => b.Comments.Count)
                .Select(b => b.Title)
                .FirstOrDefault();
            return value;
        }

        public int GetBrandCount()
        {
            var value = _context.Brands.Count();
            return value;
        }

        public string GetBrandWithMostCars()
        {
            var value = _context.Brands
                .OrderByDescending(b => b.Cars.Count)
                .Select(b => b.Name)
                .FirstOrDefault();
            return value;
        }

        public string GetCarBrandAndModelByRentPriceDailyMax()
        {
            throw new NotImplementedException();
        }

        public string GetCarBrandAndModelByRentPriceDailyMin()
        {
            throw new NotImplementedException();
        }

        public int GetCarCount()
        {
            var value = _context.Cars.Count();
            return value;
        }

        public int GetCarCountByFuelElectricOrHybrid()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Electric" || x.Fuel == "Hybrid").Count();
            return value;
        }

        public int GetCarCountByFuelGasolineOrDiesel()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Gasoline" || x.Fuel == "Diesel").Count();
            return value;
        }

        public int GetCarCountByKmLessThan1000()
        {
            var value = _context.Cars.Where(x => x.Km < 1000).Count();
            return value;
        }

        public int GetLocationCount()
        {
            var value = _context.Locations.Count();
            return value;
        }

        public double GetDailyAveragePrice()
        {
            int id=_context.Pricings.Where(y=>y.Name=="Daily").Select(x => x.PricingID).FirstOrDefault();
            var value = _context.CarPricings.Where(w=>w.PricingID==id).Average(x => x.Price);
            return (double)value;
        }


        public double GetMonthlyAveragePrice()
        {
            int id = _context.Pricings.Where(y => y.Name == "Montly").Select(x => x.PricingID).FirstOrDefault();
            var value = _context.CarPricings.Where(w => w.PricingID == id).Average(x => x.Price);
            return (double)value;
        }

        public double GetWeeklyAveragePrice()
        {
            int id = _context.Pricings.Where(y => y.Name == "Weekly").Select(x => x.PricingID).FirstOrDefault();
            var value = _context.CarPricings.Where(w => w.PricingID == id).Average(x => x.Price);
            return (double)value;
        }
    }
}
