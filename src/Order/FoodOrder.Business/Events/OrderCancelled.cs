using System;
using FoodOrder.Shared.Models.IntegrationEvents;
using FoodOrder.Shared.Models.Models;

namespace FoodOrder.Business.Events
{
    [Serializable]
    public class OrderCancelled : IOrderCancelled
    {
        public OrderCancelled(Guid correlationId, Order order)
        {
            CorrelationId = correlationId;
            Order = order;
        }

        public Guid CorrelationId { get; }
        public Order Order { get; }
    }
}
