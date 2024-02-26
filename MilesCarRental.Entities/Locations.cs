using MilesCarRental.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Entities
{
    public class Locations : IEntity
    {
        public Guid Id { get; set ; }
        public string? Description { get; set; }

        public void SetDescription (string description)
        { 
            Description = description; 
        }
    }
}
