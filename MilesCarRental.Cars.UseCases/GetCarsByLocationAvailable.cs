using MilesCarRental.Builders;
using MilesCarRental.Entities.Abstractions.Repositories;
using MilesCarRental.Entities.Abstractions.Repositories.Queries;
using MilesCarRental.Interactors.Abstractions.Cars;
using MilesCarRental.Interactors.Abstractions.DTO;

namespace MilesCarRental.Cars.UseCases
{
    internal class GetCarsByLocationAvailable : IGetCarsByLocationInputPort
    {
       private readonly IGetCarsByLocationOutputPort getCarsByLocationOutputPort;
       private readonly IQueryCarsRepository queryCarsRepository;
       private readonly CarsBuilder carsBuilder;
        private readonly BookingsBuilder bookingsBuilder;
        private readonly IQueryBookingsRepositoy queryBookingsRepositoy;

        public GetCarsByLocationAvailable(IGetCarsByLocationOutputPort getCarsByLocationOutputPort, IQueryCarsRepository queryCarsRepository, CarsBuilder carsBuilder,
            BookingsBuilder bookingsBuilder, IQueryBookingsRepositoy queryBookingsRepositoy)
        {
           this.getCarsByLocationOutputPort = getCarsByLocationOutputPort;
           this.queryCarsRepository = queryCarsRepository;
           this.carsBuilder = carsBuilder;
           this.bookingsBuilder = bookingsBuilder;
           this.queryBookingsRepositoy = queryBookingsRepositoy;
        }
        public async Task Handle(Guid IdLocation, DateTime dateTimeRent)
        {
            var carsAvailable = await queryCarsRepository.GetCarsByLocation(IdLocation);
            var bookingsReturn = await queryBookingsRepositoy.GetByReturnLocation(IdLocation, dateTimeRent);
            if (bookingsReturn != null)
            {
                List<Guid> lisCarsId = bookingsReturn.Select(x => x.CarId).ToList();
                var carsReturns = await queryCarsRepository.GetCarsById(lisCarsId);
                var carsAllAvilable = carsAvailable.Concat(carsReturns).ToList();
                var ToList = carsBuilder.Convert(carsAllAvilable);
                await getCarsByLocationOutputPort.Handle(ToList);

            }
            else
            {
                var carsAllAvilable = carsAvailable.ToList();
                var ToList = carsBuilder.Convert(carsAllAvilable);
                await getCarsByLocationOutputPort.Handle(ToList);
            }

        }


    }
}
