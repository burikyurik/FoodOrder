using System;
using FoodOrder.Shared.Models.IntegrationEvents;
using FoodOrder.Shared.Models.Models;

namespace FoodOrder.Payment.Api.Events
{
    [Serializable]
    public class PaymentProcessed : IPaymentProcessed
    {
        public PaymentProcessed(Guid correlationId, Order order)
        {
            CorrelationId = correlationId;
            Order = order;
        }

        public Guid CorrelationId { get; }
        public Order Order { get; }
    }
}
