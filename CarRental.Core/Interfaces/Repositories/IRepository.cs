using CarRental.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CarRental.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
