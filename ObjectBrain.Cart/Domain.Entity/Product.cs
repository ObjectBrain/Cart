using System;

namespace Domain.Entity
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public Guid Code { get; set; }
        public decimal Price { get; set; }
    }
}