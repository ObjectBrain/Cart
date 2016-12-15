using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Domain.Entity
{
    public class Order : EntityBase
    {
        public Order(IEnumerable<OrderLine> lines)
        {
            Lines = lines;
        }

        public int CustomerId { get; set; }
        public string CustomerEmail { get; set; }
        [ForeignKey("CustomerId,CustomerEmail")]
        public Customer Customer { get; set; }

        public IEnumerable<OrderLine> Lines { get; set; }

        public decimal Total => Lines.Sum(x => x.Quantity * x.Product.Price);


    }
}
