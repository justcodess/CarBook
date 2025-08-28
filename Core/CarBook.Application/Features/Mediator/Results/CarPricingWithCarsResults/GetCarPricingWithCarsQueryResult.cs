using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.CarPricingWithCarsResults
{
    public class GetCarPricingWithCarsQueryResult
    {
        public int CarPricingID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string CoverImageUrl { get; set; }
    }
}
