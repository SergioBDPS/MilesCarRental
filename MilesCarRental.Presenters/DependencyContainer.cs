using Microsoft.Extensions.DependencyInjection;
using MilesCarRental.Interactors.Abstractions.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<IAddCarsOutputPort, AddCarsPresenter>();
            services.AddScoped<IGetCarsByLocationOutputPort, GetCarsByLocationPresenter>();
            return services;
        }
    }
}
