using System;
using MediatR;

namespace FoodOrder.Business.Command
{
    public class CancelOrderCommand : INotification
    {
        public int OrderId { get; }

        public CancelOrderCommand(int orderId)
        {
            OrderId = orderId;
        }
    }
}