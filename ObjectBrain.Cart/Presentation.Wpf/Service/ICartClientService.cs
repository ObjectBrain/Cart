using System;
using System.Collections.Generic;

namespace Presentation.Wpf.Service
{
    public interface ICartClientService<T>
    {
        IObservable<IEnumerable<T>> GetAll();
        IObservable<T> Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}