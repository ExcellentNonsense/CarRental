using CarRental.Domain.Entities;
using System.Collections.Generic;

namespace CarRental.Domain.Interfaces.Repositories
{
    public interface ICarRepo : IRepository<Car>
    {
        IEnumerable<Car> GetAllWithFullData();
    }
}
