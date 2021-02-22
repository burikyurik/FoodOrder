using System;
using MediatR;

namespace FoodOrder.Business.Command
{
    public class CancelOrderCommand : ICancellableAsyncNotification
    {
        public Guid OrderId { get; }

        public CancelOrderCommand(Guid orderId)
        {
            OrderId = orderId;
        }
    }
}