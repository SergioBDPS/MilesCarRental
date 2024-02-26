using Microsoft.EntityFrameworkCore;
using MilesCarRental.Entities;
using MilesCarRental.Entities.Abstractions.Repositories;
using MilesCarRental.Entities.Abstractions.Repositories.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Repository.EFCore
{
    public class CarsRepository : ICarsRepository, IQueryCarsRepository
    {
        private readonly DatabaseContext context;

        public CarsRepository(DatabaseContext context)
        {
            this.context = context;
        }
        public async Task<List<Cars>> GetCarsByLocation(Guid id)
        {
            return await context.Cars.Where(c => c.CarLocationId == id && c.IsAvailable == true).ToListAsync();
        }
        public async Task<List<Cars>> GetCarsById(List<Guid> idCars)
        {
            return await context.Cars.Where(c => idCars.Contains(c.Id)).ToListAsync();
        }
        public async Task<Cars> Add(Cars car)
        {
            await context.Cars.AddAsync(car);
            await context.SaveChangesAsync();
            return car;
        }
    }
}   
