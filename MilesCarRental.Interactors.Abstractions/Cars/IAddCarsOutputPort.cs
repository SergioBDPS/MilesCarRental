using MilesCarRental.Interactors.Abstractions.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Interactors.Abstractions.Cars
{
    public interface IAddCarsOutputPort
    {
        Task Handle(CarsDTO ToAdd);
        CarsDTO Content { get; }
    }
}
