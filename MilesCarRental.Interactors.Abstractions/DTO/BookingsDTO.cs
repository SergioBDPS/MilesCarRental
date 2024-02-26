using MilesCarRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Interactors.Abstractions.DTO
{
    public class BookingsDTO
    {
        public Guid IdBooking { get; set; }
        public Guid CarId { get; set; }
        public DateTime ReturnTime { get; set; }
        public Boolean DiferentLocation { get; set; }
        public Guid? ReturnLocationId { get; set; }

    }
}
