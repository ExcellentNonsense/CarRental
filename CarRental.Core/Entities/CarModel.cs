using System.Collections.Generic;

namespace CarRental.Domain.Entities
{
    public class CarModel : BaseEntity
    {
        public string Name { get; set; }
        public CarBrand Brand { get; set; }
        public VehicleType Type { get; set; }
        public bool HasAutomaticTransmission { get; set; }
        public bool HasAirConditioner { get; set; }
        public bool HasGps { get; set; }
        public int SitsNumber { get; set; }
        public int DoorsNumber { get; set; }
        public int SuitcasesNumber { get; set; }
        public bool IsPremium { get; set; }

        public int CarBrandId { get; set; }
        public int VehicleTypeId { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
