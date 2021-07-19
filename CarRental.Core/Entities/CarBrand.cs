using System.Collections.Generic;

namespace CarRental.Domain.Entities
{
    public class CarBrand : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<CarModel> CarModels { get; set; }
    }
}
