using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Repository;
using Domain.Entity;

namespace Domain.Model
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> _customerRepository;

        public CustomerService(IRepository<Customer> customeRepository)
        {
            _customerRepository = customeRepository;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _customerRepository.GetAll();
        }

        public void AddOrUpdate(Customer customer)
        {
            _customerRepository.AddOrUpdate(customer);
        }

        public void Remove(Customer customer)
        {
            _customerRepository.Remove(customer);
        }

        public async Task<Customer> Get(int id)
        {
            return await _customerRepository.Get(id);
        }
    }
}
