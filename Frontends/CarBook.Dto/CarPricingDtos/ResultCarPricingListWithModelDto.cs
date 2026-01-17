using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.CarPricingDtos
{
    public class ResultCarPricingListWithModelDto
    {
        public string BrandName { get; set; }
        public string CoverImgUrl { get; set; }
        public string Model { get; set; }
        public decimal DailyPrice { get; set; }
        public decimal WeeklyPrice { get; set; }
        public decimal MontlyPrice { get; set; }
    }
}
