using CarBook.Application.Interfaces.CarPricingInterface;
using CarBook.Application.ViewModels;
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
            return _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand).Include(z => z.Pricing).ToList();
        }

        public List<CarPricing> GetCarPricingWithTimePeriod()
        {
            throw new NotImplementedException();
        }

        public List<CarPricingViewModel> GetCarPricingWiewModelList()
        {
            List<CarPricingViewModel> values = new List<CarPricingViewModel>();
            using (var command = _context.Database.GetDbConnection().CreateCommand()) { 
            command.CommandText = "Select * From (Select Model,PricingID,Price From CarPricings Inner Join Cars On Cars.CarID = CarPricings.CarID  " +
                "Inner Join Brands On Brands.BrandID = Cars.BrandID) As SourceTable Pivot (Sum(Price) For PricingID In([1], [2], [1001] ) )As PivotTable; ";
                command.CommandType = System.Data.CommandType.Text;
                _context.Database.OpenConnection();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CarPricingViewModel carPricingViewModel = new CarPricingViewModel();
                        Enumerable.Range(1,3).ToList().ForEach(x =>
                        {
                            carPricingViewModel.Model = reader[0].ToString();
                            if (DBNull.Value.Equals(reader[x]))
                                {
                                carPricingViewModel.Price.Add(0);
                            }
                            else
                            {
                                carPricingViewModel.Price.Add(reader.GetDecimal(x));
                            }
                        });
                        values.Add(carPricingViewModel);
                    }
                }
                _context.Database.CloseConnection();
                return values;
            }
                
        }

    }


}
