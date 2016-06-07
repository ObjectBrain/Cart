using System.Data.Entity;
using Domain.Entity;

namespace Data.Context
{
    public class CartContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
    }
}
