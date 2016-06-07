using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Domain.Entity;

namespace Data.Repository
{
    public interface IRepository<T> where T : EntityBase
    {
        void AddOrUpdate(T entity);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicat, params string[] includes);
        Task<T> Get(object key);
        void Remove(T entity);

    }
}