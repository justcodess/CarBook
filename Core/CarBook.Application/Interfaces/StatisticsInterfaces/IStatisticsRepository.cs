using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.StatisticsInterfaces
{
    public interface IStatisticsRepository
    {
        int GetCarCount();
        int GetAuthorCount();
        int GetLocationCount();
        int GetBlogCount();
        int GetBrandCount();
        double GetDailyAveragePrice();
        double GetWeeklyAveragePrice();
        double GetMonthlyAveragePrice();
        int GetAutomaticTransmissionCarCount();
        string  GetBrandWithMostCars();
        string GetBlogWithMostComments();
        int GetCarCountByKmLessThan1000();
        int GetCarCountByFuelGasolineOrDiesel();
        int GetCarCountByFuelElectricOrHybrid();
        string GetCarBrandAndModelByRentPriceDailyMax();
        string GetCarBrandAndModelByRentPriceDailyMin();


    }
}
