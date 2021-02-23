using System;
using FoodOrder.Shared.Models.IntegrationEvents;
using FoodOrder.Shared.Models.Models;

namespace FoodOrder.Business.Events
{
    [Serializable]
    public class OrderProcessed : IOrderProcessed
    {
        public OrderProcessed(Guid correlationId, Order order)
        {
            this.CorrelationId = correlationId;
            this.Order = order;
        }
        public Guid CorrelationId { get; }

        public Order Order { get; }
    }
}