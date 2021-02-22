using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FoodOrder.Business.Dtos;
using FoodOrder.Business.Query;
using FoodOrder.Data.SqlServer;
using FoodOrder.Domain.Entity.OrderAggregate;
using FoodOrder.Domain.Entity.RestaurantAggregate;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodOrder.Business.QueryHandlers
{
    public class GetOrdersQuerySqlQueryHandler : ICancellableAsyncRequestHandler<GetOrderQuery, OrderDto>
    {
        private readonly OrderingContext _context;

        public GetOrdersQuerySqlQueryHandler(OrderingContext context)
        {
            _context = context;
        }

        public async Task<OrderDto> Handle(GetOrderQuery message, CancellationToken cancellationToken)
        {
            var order = await _context.Orders.AsNoTracking()
                .Where(x => x.Id == message.OrderId)
                .Select(x => MapDto(x))
                .FirstOrDefaultAsync(cancellationToken);
            return order;
        }

        private static OrderDto MapDto(Order order)
        {
            return new OrderDto
            {
                
            };
        }
    }
}