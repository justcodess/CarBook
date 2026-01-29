using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using CarBook.Application.Interfaces.CarFeatureInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories.CarFeatureRepositories
{
    public class CarFeatureRepository : ICarFeatureRepository
    { 
        private readonly CarBookContext _context;
        public CarFeatureRepository(CarBookContext context)
        {
            _context = context;
        }

        public void ChangeCarFeatureAvailableToFalse(int id)
        {
            var value = _context.CarFeatures.Where(cf => cf.CarFeatureID == id).FirstOrDefault();
            value.Available = false;
            _context.SaveChanges();
        }

        public void ChangeCarFeatureAvailableToTrue(int id)
        {
            var value = _context.CarFeatures.Where(cf => cf.CarFeatureID == id).FirstOrDefault();
            value.Available = true;
            _context.SaveChanges();
        }

        public List<CarFeature> GetCarFeatureByCarId(int carID)
        {
            var values = _context.CarFeatures.Include(cf => cf.Feature).Where(cf => cf.CarID == carID).ToList();
            return values;
        }
    }
}
