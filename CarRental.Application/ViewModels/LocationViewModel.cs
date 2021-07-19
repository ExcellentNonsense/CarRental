using CarRental.Domain.Entities;

namespace CarRental.Application.ViewModels
{
    public class LocationViewModel
    {
        public string Name { get; set; }
        public string City { get; set; }

        public static LocationViewModel CreateFromLocation(Location location)
        {
            return new LocationViewModel
            {
                Name = location.Name,
                City = location.City.Name
            };
        }
    }
}
