using Microsoft.EntityFrameworkCore;
using MilesCarRental.Entities;
using MilesCarRental.Entities.Abstractions.Repositories.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Repository.EFCore
{
    public class BookingsRepository : IQueryBookingsRepositoy
    {
        private readonly DatabaseContext context;

        public BookingsRepository(DatabaseContext context)
        {
            this.context = context;
        }
        public async Task<List<Bookings>> GetByReturnLocation(Guid idLocation, DateTime pickupdate)
        {

            var bookings = await context.Bookings.Where(b => b.ReturnLocationId == idLocation && b.ReturnTime < pickupdate).ToListAsync();

            return bookings;

        }
    }
}
