using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entity;

namespace Service.WebApi.Client
{
    public interface ICartClientProxy<T> : IDisposable where T : EntityBase
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task Post(T entity);
        Task Put(T entity);
        Task Delete(T entity);
    }
}