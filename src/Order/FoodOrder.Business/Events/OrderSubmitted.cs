using System;
using FoodOrder.Shared.Models.IntegrationEvents;
using FoodOrder.Shared.Models.Models;

namespace FoodOrder.Business.Events
{
    [Serializable]
    public class OrderSubmitted : IOrderSubmitted
    {
        public OrderSubmitted(Guid correlationId, Order order)
        {
            CorrelationId = correlationId;
            Order = order;
        }

        public Guid CorrelationId { get; }
        public Order Order { get; }
    }
}