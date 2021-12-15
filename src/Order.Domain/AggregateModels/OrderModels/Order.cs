using Order.Domain.Events;
using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class Order:BaseEntity,IAggregateRoot
    {
        public DateTime OrderDate { get; private set; }
        public int Quantity { get; private set; }
        public string Description { get; private set; }
        public Address Address { get; private set; }
        public string UserName { get; private set; }
        public string OrderStatus { get; private set; }
        public List<OrderItem> OrderItems { get; private set; }
        public Order(DateTime orderDate, int quantity, string description, Address address, string userName, string orderStatus, List<OrderItem> orderItems)
        {
            if (OrderDate < DateTime.Now)
                throw new Exception("OrderDate şimdiki zamandan küçük olamaz ! ");
            if(Address.City ==null)
                throw new Exception("Şehir alanı boş olamaz !");
            OrderDate = orderDate;
            Quantity = quantity;
            Description = description;
            Address = address;
            UserName = userName;
            OrderStatus = orderStatus;
            OrderItems = orderItems;


            AddDomainEvents(new OrderStartedDomainEvent(userName,this));
        }

        public void OrderItemAdd(int quantity,decimal price,Guid productId)
        {
            OrderItem item = new(quantity,price,productId);
            OrderItems.Add(item);
        }

    }
}
