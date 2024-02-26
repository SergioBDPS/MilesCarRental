    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Entities.Abstractions.Repositories.Queries
{
    public interface IQueryCarsRepository
    {
        Task<List<Cars>> GetCarsByLocation(Guid Id);

        Task<List<Cars>> GetCarsById(List<Guid> idCars);
    }
}
