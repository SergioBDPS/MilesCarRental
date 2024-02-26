using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Entities.Abstractions.Repositories.Queries
{
    public interface IQueryBookingsRepositoy
    {
        Task<List<Bookings>> GetByReturnLocation(Guid Id, DateTime dateTime);
    }
}
