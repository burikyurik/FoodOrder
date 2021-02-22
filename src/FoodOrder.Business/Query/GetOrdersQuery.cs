using System;
using FoodOrder.Business.Dtos;
using MediatR;

namespace FoodOrder.Business.Query
{
    public class GetOrderQuery : ICancellableAsyncRequest<OrderDto>
    {
        public GetOrderQuery(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; }
    }
}