using Microsoft.Extensions.DependencyInjection;
using MilesCarRental.Interactors.Abstractions.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Cars.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddCarsUseCases(this IServiceCollection services)
        {
            services.AddScoped<IAddCarsInputPort, AddCars>();
            services.AddScoped<IGetCarsByLocationInputPort, GetCarsByLocationAvailable>();
            //services.AddScoped<IGe>
            return services;
        }
    }
}
