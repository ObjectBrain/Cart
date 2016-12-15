using System;
using System.Collections.Generic;
using System.Reactive.Threading.Tasks;
using Domain.Entity;
using Service.WebApi.Client;

namespace Presentation.Wpf.Service
{
    public class CartClientService<T> : ICartClientService<T> where T : EntityBase
    {
        private readonly ICartClientProxy<T> _proxy;

        public CartClientService(ICartClientProxy<T> proxy)
        {
            _proxy = proxy;
        }

        public IObservable<IEnumerable<T>> GetAll()
        {
            return _proxy.GetAll().ToObservable();
        }

        public IObservable<T> Get(int id)
        {
            return _proxy.Get(id).ToObservable();
        }

        public void Add(T entity)
        {
            _proxy.Post(entity);
        }

        public void Update(T entity)
        {
            _proxy.Put(entity);
        }

        public void Remove(T entity)
        {
            _proxy.Delete(entity);
        }
    }
}