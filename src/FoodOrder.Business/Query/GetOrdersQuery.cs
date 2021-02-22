using System;
using System.Collections.Generic;
using FoodOrder.Business.Dtos;
using MediatR;

namespace FoodOrder.Business.Query
{
    public class GetOrderQuery : ICancellableAsyncRequest<OrderDto>
    {
        public GetOrderQuery(Guid orderId)
        {
            OrderId = orderId;
        }

        public Guid OrderId { get; }
    }
}