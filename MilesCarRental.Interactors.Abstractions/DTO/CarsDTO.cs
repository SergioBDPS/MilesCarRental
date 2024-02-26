
namespace MilesCarRental.Interactors.Abstractions.DTO
{
    public class CarsDTO
    {
        public Guid Id { get; set; }
        public string Plate { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Category { get; set; }
        public Guid CarLocationId { get; set; }
        public string? LocationDescrip { get; set; }
        public Boolean IsAvailable { get; set; }
    }
}
