using MilesCarRental.Entities;
using MilesCarRental.Interactors.Abstractions.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Builders
{
    public class BookingsBuilder : BuilderBase<Bookings, BookingsDTO>
    {
        public override Bookings Convert(BookingsDTO param)
        {
            return new Bookings()
            {
                Id = param.IdBooking,
                CarId = param.CarId,
                ReturnTime = param.ReturnTime,
                ReturnLocationId = param.ReturnLocationId
            };
        }
        public override BookingsDTO Convert(Bookings param)
        {
            return new BookingsDTO()
            {
                IdBooking = param.Id,
                CarId = param.CarId,
                ReturnTime = param.ReturnTime,
                ReturnLocationId = param.ReturnLocationId
            };
        }
    }
}
