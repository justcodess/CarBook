using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.StatisticDtos
{
    public class ResultStatisticDto
    {
        public int CarCount { get; set; }
        public int LocationCount { get; set; }
        public int AuthorCount { get; set; }
        public int BlogCount { get; set; }
        public int BrandCount { get; set; }
        public double DailyAveragePrice { get; set; }
        public double WeeklyAveragePrice { get; set; }
        public double MonthlyAveragePrice { get; set; }
        public int AutomaticTransmissionCarCount { get; set; }
        public string BrandWithMostCars { get; set; }
        public string BlogWithMostComments { get; set; }
        public int CarCountByKmLessThan1000 { get; set; }
        public int CarCountByFuelGasolineOrDiesel { get; set; }
        public int CarCountByFuelElectricOrHybrid { get; set; }
        public string CarBrandAndModelByRentPriceDailyMax { get; set; }
        public string CarBrandAndModelByRentPriceDailyMin { get; set; }
    }
}
