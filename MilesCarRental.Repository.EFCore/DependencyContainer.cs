using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MilesCarRental.Entities.Abstractions.Repositories;
using MilesCarRental.Entities.Abstractions.Repositories.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Repository.EFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddEFCoreRespositories(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlServer(config["Connection"], op =>
                {
                    op.EnableRetryOnFailure(maxRetryCount: 5, maxRetryDelay: TimeSpan.FromSeconds(60), null);
                });
            });
            services.AddScoped<ICarsRepository, CarsRepository>();
            services.AddScoped<IQueryCarsRepository, CarsRepository>();
            services.AddScoped<IQueryBookingsRepositoy, BookingsRepository>();
            return services;
        }
    }
}
