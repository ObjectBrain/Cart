using System.Collections.Generic;
using Data.Repository;
using Domain.Entity;

namespace Domain.Model
{
    public class CartService : ICartService
    {
        private readonly IRepository<Order> _orderRepository;

        public CartService(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        private readonly Customer _customer;
        private readonly IEnumerable<OrderLine> _lines;

        public CartService(Customer customer, IEnumerable<OrderLine> lines)
        {
            _customer = customer;
            _lines = lines;
        }

        public void CheckOut()
        {
            Order order = new Order(_lines);

            _orderRepository.AddOrUpdate(order);
        }

    }
}
