using MilesCarRental.Entities;
using MilesCarRental.Interactors.Abstractions.DTO;

namespace MilesCarRental.Builders
{
    public class CarsBuilder : BuilderBase<Cars, CarsDTO>
    {
        public override Cars Convert(CarsDTO param)
        {
            return new Cars()
            {
                Brand = param.Brand,
                Category = param.Category,
                Color = param.Color,
                Id = param.Id,
                Plate = param.Plate,
                CarLocationId = param.CarLocationId
            };
        }
        public override CarsDTO Convert(Cars param)
        {
            return new CarsDTO()
            {
                Brand = param.Brand,
                Category = param.Category,
                Color = param.Color,
                Id = param.Id,
                Plate = param.Plate
            };
        }
    }
}
