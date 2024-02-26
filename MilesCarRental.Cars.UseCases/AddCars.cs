using MilesCarRental.Builders;
using MilesCarRental.Entities.Abstractions.Repositories;
using MilesCarRental.Interactors.Abstractions.Cars;
using MilesCarRental.Interactors.Abstractions.DTO;

namespace MilesCarRental.Cars.UseCases
{
    public class AddCars : IAddCarsInputPort
    {
        private readonly IAddCarsOutputPort AddCarsOutputPort;
        private readonly ICarsRepository carsRepository;
        private readonly CarsBuilder carsBuilder;

        public AddCars(IAddCarsOutputPort AddCarsOutputPort, ICarsRepository carsRepository, CarsBuilder carsBuilder)
        {
            this.AddCarsOutputPort = AddCarsOutputPort;
            this.carsRepository = carsRepository;
            this.carsBuilder = carsBuilder;
        }
        public async Task Handle(CarsDTO ToAdd)
        {
            var ToRegistry = carsBuilder.Convert(ToAdd);
            await carsRepository.Add(ToRegistry);
            await AddCarsOutputPort.Handle(ToAdd);
        }
    }
}
