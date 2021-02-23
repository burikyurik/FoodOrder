using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrder.Shared.Models.IntegrationEvents;
using FoodOrder.Shared.Models.Models;

namespace FoodOrder.Delivery.Api.Events
{
    [Serializable]
    public class OrderDelivered: IOrderDelivered
    {
        public OrderDelivered(Guid correlationId, Order order)
        {
            CorrelationId = correlationId;
            Order = order;
        }

        public Guid CorrelationId { get; }
        public Order Order { get; }
    }
}
