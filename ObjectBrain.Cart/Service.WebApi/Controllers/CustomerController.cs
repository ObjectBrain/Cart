using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Domain.Entity;
using Domain.Model;

namespace Service.WebApi.Controllers
{
    public class CustomerController : ApiController
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/Customer
        public async Task<IEnumerable<Customer>> Get()
        {
            var result = await _customerService.GetAll();
            return result;
        }

        // GET: api/Customer/5
        public async Task<Customer> Get(int id)
        {
            return await _customerService.Get(id);
        }

        // POST: api/Customer
        public void Post([FromBody]Customer value)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            _customerService.AddOrUpdate(value);
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]Customer value)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            _customerService.AddOrUpdate(value);
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
            var c = new Customer { Id = id };
            _customerService.Remove(c);
        }
    }
}
