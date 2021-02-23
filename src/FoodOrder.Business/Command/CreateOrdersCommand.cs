using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace FoodOrder.Business.Command
{
    public class CreateOrdersCommand : ICancellableAsyncNotification
    {
        public CreateOrdersCommand(int? clientId, ICollection<(int restaurantId, int[] menuItemInts)> orders)
        {
            ClientId = clientId;
            Orders = orders;
        }

        public int? ClientId { get; }
        public ICollection<(int restaurantId, int[] menuItemInts)> Orders { get; }
        //TODO delivery and payment information
    }
}
