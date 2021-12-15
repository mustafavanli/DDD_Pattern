using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Events
{
    public class OrderStartedDomainEvent:INotification
    {

        public string UserName { get; private set; }
        public AggregateModels.OrderModels.Order Order { get; private set; }

        public OrderStartedDomainEvent(string userName, AggregateModels.OrderModels.Order order)
        {
            UserName = userName;
            Order = order;
        }
    }
}
