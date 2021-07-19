using CarRental.Domain.Entities;

namespace CarRental.Application.ViewModels
{
    public class CarViewModel
    {
        public string RegistrationNumber { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public bool HasAutomaticTransmission { get; set; }
        public bool HasAirConditioner { get; set; }
        public bool HasGps { get; set; }
        public int SitsNumber { get; set; }
        public int DoorsNumber { get; set; }
        public int SuitcasesNumber { get; set; }
        public bool IsPremium { get; set; }
        public string Location { get; set; }
        public string City { get; set; }

        public static CarViewModel CreateFromCar(Car car)
        {
            return new CarViewModel
            {
                RegistrationNumber = car.RegistrationNumber,
                Model = car.Model.Name,
                Brand = car.Model.Brand.Name,
                Type = car.Model.Type.Name,
                HasAutomaticTransmission = car.Model.HasAutomaticTransmission,
                HasAirConditioner = car.Model.HasAirConditioner,
                HasGps = car.Model.HasGps,
                SitsNumber = car.Model.SitsNumber,
                DoorsNumber = car.Model.DoorsNumber,
                SuitcasesNumber = car.Model.SuitcasesNumber,
                IsPremium = car.Model.IsPremium,
                Location = car.Location.Name,
                City = car.Location.City.Name
            };
        }
    }
}
