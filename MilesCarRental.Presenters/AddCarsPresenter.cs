using MilesCarRental.Interactors.Abstractions.Cars;
using MilesCarRental.Interactors.Abstractions.DTO;

namespace MilesCarRental.Presenters
{
    public class AddCarsPresenter : IAddCarsOutputPort
    {
        public CarsDTO Content { get; private set; }
        public Task Handle(CarsDTO ToAdd)
        {
            Content = ToAdd;
            return Task.CompletedTask;
        }
    }
}
