namespace CarRental.Domain.Entities
{
    public class Car : BaseEntity
    {
        public string RegistrationNumber { get; set; }
        public CarModel Model { get; set; }
        public Location Location { get; set; }

        public int ModelId { get; set; }
        public int LocationId { get; set; }
    }
}
