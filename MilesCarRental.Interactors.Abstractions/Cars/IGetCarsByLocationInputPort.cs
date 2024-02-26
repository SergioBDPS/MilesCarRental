using MilesCarRental.Interactors.Abstractions.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Interactors.Abstractions.Cars
{
    public interface IGetCarsByLocationInputPort
    {
        Task Handle(Guid idLocation, DateTime dateTimeRent);
    }
}
