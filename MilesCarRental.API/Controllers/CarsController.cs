using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilesCarRental.Interactors.Abstractions.Cars;
using MilesCarRental.Interactors.Abstractions.DTO;
using MilesCarRental.Presenters;

namespace MilesCarRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IAddCarsInputPort addCarsInputPort;
        private readonly IAddCarsOutputPort addCarsOutputPort;
        private readonly IGetCarsByLocationInputPort getCarsByLocationInputPort;
        private readonly IGetCarsByLocationOutputPort getCarsByLocationOutputPort;

        public CarsController(IAddCarsInputPort addCarsInputPort, IAddCarsOutputPort addCarsOutputPort, IGetCarsByLocationInputPort getCarsByLocationInputPort,
            IGetCarsByLocationOutputPort getCarsByLocationOutputPort)
        {
            this.addCarsInputPort = addCarsInputPort;
            this.addCarsOutputPort = addCarsOutputPort;
            this.getCarsByLocationInputPort = getCarsByLocationInputPort;
            this.getCarsByLocationOutputPort = getCarsByLocationOutputPort;

        }
        [HttpPost("CreteCar")]
        public async Task<IActionResult> AddCar(CarsDTO carsDTO)
        {
            await addCarsInputPort.Handle(carsDTO);
            var response = ((IPresenter<List<CarsDTO>>)addCarsOutputPort).Content;
            return Ok(response);
        }
        [HttpGet("CarsAvailable")]
        public async Task<IActionResult> GetCarsByAvailable(Guid idLocation, DateTime dateTimeRent)
        {
            await getCarsByLocationInputPort.Handle(idLocation, dateTimeRent);
            var response = ((IPresenter<List<CarsDTO>>)getCarsByLocationOutputPort).Content;
            return Ok(response);
        }

    }
}
