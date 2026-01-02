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
            throw new NotImplementedException();
        }

        public int GetBlogCount()
        {
            var value = _context.Blogs.Count();
            return value;
        }

        public string GetBlogWithMostComments()
        {
            throw new NotImplementedException();
        }

        public int GetBrandCount()
        {
            var value = _context.Brands.Count();
            return value;
        }

        public string GetBrandWithMostCars()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public int GetCarCountByFuelGasolineOrDiesel()
        {
            throw new NotImplementedException();
        }

        public int GetCarCountByKmLessThan1000()
        {
            throw new NotImplementedException();
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
