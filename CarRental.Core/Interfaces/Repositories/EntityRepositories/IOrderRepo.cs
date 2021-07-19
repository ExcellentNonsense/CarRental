using CarRental.Domain.Entities;
using System.Collections.Generic;

namespace CarRental.Domain.Interfaces.Repositories
{
    public interface IOrderRepo : IRepository<Order>
    {
         IEnumerable<Order> GetAllWithCarData();
    }
}
