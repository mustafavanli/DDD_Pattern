using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class OrderItem: BaseEntity
    {
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public Guid ProductId { get; private set; }
        public OrderItem(int quantity, decimal price, Guid productId)
        {
            
            //validation ...
            Quantity = quantity;
            Price = price;
            ProductId = productId;
            
        }
    }
}
