using System.Collections.Generic;

namespace CarRental.Domain.Entities
{
    public class Location : BaseEntity
    {
        public string Name { get; set; }
        public City City { get; set; }

        public int CityId { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
