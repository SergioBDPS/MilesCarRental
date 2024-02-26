using MilesCarRental.Abstractions.Entities;

namespace MilesCarRental.Entities
{
    public class Users : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Address {  get; private set; }
        public Locations UserLocations { get; private set; }

        public void SetName(string name)
        {
            Name = name;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
        public void SetAddress(string address)
        {
            Address = address;
        }
    }
}
