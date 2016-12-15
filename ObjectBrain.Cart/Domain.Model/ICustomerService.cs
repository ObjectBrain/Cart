using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entity;

namespace Domain.Model
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAll();
        void AddOrUpdate(Customer customer);
        void Remove(Customer customer);
        Task<Customer> Get(int id);
    }
}