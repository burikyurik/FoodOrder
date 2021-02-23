using System;
using FoodOrder.Data.Dtos;
using MediatR;

namespace FoodOrder.Business.Query
{
    public class GetOrderQuery : IRequest<OrderDto>
    {
        public GetOrderQuery(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; }
    }
}