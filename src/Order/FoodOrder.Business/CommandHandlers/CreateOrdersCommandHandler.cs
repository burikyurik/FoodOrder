using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FoodOrder.Business.Command;
using FoodOrder.Data.SqlServer;
using FoodOrder.Domain.Entity.OrderAggregate;
using MediatR;

namespace FoodOrder.Business.CommandHandlers
{
    public class CreateOrdersCommandHandler: INotificationHandler<CreateOrdersCommand>
    {
        private readonly IOrderRepository _orderRepository;

        public CreateOrdersCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task Handle(CreateOrdersCommand message, CancellationToken cancellationToken)
        {
            //TODO create delivery address
            //Address address = null;
            //var menuItemsIds = message.Orders.SelectMany(x => x.menuItemInts);
            //var menuItems = _context.MenuItems.AsNoTracking()
            //    .Include(x => x.Category).ThenInclude(x => x.Restaurant)
            //    .Where(x => menuItemsIds.Contains(x.Id))
            //    .ToListAsync(cancellationToken);
            foreach (var (restaurantId, menuItemInts) in message.Orders)
            {
                var order = new Order(DateTime.UtcNow, OrderStatus.Created.Id, message.ClientId, string.Empty, restaurantId, new List<OrderItem>());

                _orderRepository.Add(order);
            }

            await _orderRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        }
    }
}
