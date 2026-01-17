using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.ViewModels
{
    public class CarPricingViewModel
    {
        public CarPricingViewModel()
        {
            Price = new List<Decimal>();
        }
        public List< Decimal> Price { get; set; }
        public string Model { get; set; }

    }
}
