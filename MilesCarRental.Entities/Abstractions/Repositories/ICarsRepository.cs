using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Entities.Abstractions.Repositories
{
    public interface ICarsRepository
    {
        Task<Cars> Add(Cars car);
    }
}
