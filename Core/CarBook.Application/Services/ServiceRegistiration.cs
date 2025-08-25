using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;


namespace CarBook.Application.Services
{
    public static class ServiceRegistiration
    {
        public static void AddApplicationService(this IServiceCollection services,
            IConfiguration configiration)
        {
            services.AddMediatR(cfg=>cfg.RegisterServicesFromAssembly 
            (typeof(ServiceRegistiration).Assembly));
        }
            
    }
}
