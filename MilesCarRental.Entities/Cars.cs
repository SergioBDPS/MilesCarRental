using MilesCarRental.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MilesCarRental.Entities
{
    public class Cars : IEntity
    {
        public Guid Id { get; set; }
        public string Plate { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Category { get; set; }
        public Guid? CarLocationId { get; set; }
        public Locations? CarLocation { get; set; }
        public Boolean? IsAvailable { get; set; }

        public void SetPlate(string plate)
        {
            Plate = plate;
        }
        public void SeBarnd(string brand)
        {
            Brand = brand;
        }
        public void SetColor(string color)
        {
            Color = color;
        }
        public void SetCategory(string category)
        {
            Category = category;
        }
        public void SetIsAvailable(Boolean isAvailable)
        { 
            IsAvailable = isAvailable;
        }
    }
}
