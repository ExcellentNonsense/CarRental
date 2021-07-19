using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace CarRental.Infrastructure.Data.Repositories
{
    class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly DbContext ctx;

        public EfRepository(DbContext context)
        {
            ctx = context;
        }

        public void Add(T entity)
        {
            ctx.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            ctx.Set<T>().AddRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return ctx.Set<T>().Where(predicate);
        }

        public T Get(int id)
        {
            return ctx.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return ctx.Set<T>().ToList();
        }

        public void Remove(T entity)
        {
            ctx.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            ctx.Set<T>().RemoveRange(entities);
        }
    }
}
