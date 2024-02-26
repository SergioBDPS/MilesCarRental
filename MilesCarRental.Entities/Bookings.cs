using MilesCarRental.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Entities
{
    public class Bookings : IEntity
    {
        public Guid Id { get; set; }
        public Users User { get; set; }
        public Cars Car { get; set; }
        public Guid CarId { get; set; }
        public DateTime RentTime { get; set; }
        public DateTime ReturnTime { get; set; }
        public Locations RentLocation { get; set; }
        public Boolean DiferentLocation { get; set; }
        public Locations? ReturnLocation { get; set; }
        public Guid? ReturnLocationId { get; set; }

        public void SetRentTime(DateTime rentTime)
        {
            RentTime = rentTime;
        }
        public void SetReturnTime(DateTime returnTime)
        {
            ReturnTime = returnTime;
        }
        public void SetDiferetLocation(Boolean diferetLocation)
        {
            DiferentLocation = diferetLocation;
        }

    }
}
