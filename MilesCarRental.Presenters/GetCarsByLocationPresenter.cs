using MilesCarRental.Interactors.Abstractions.Cars;
using MilesCarRental.Interactors.Abstractions.DTO;


namespace MilesCarRental.Presenters
{
    internal class GetCarsByLocationPresenter : IGetCarsByLocationOutputPort, IPresenter<List<CarsDTO>>
    {
        public List<CarsDTO> Content { get; private set; }

        public Task Handle(List<CarsDTO> cars)
        {
            Content = cars;
            return Task.CompletedTask;
        }
    }
}
