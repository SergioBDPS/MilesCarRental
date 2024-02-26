using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Builders
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddBuilders(this IServiceCollection services)
        {
            services.AddScoped<CarsBuilder>();
            services.AddScoped<BookingsBuilder>();
            return services;
        }
    }
}
