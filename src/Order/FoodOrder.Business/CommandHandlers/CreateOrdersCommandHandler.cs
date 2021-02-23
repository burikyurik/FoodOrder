using System;
using System.Threading;
using System.Threading.Tasks;
using FoodOrder.Business.Command;
using FoodOrder.Data.SqlServer;
using FoodOrder.Domain.Entity.OrderAggregate;
using FoodOrder.Domain.Entity.RestaurantAggregate;
using FoodOrder.Domain.ValueObject;
using MediatR;

namespace FoodOrder.Business.CommandHandlers
{
    public class CreateOrdersCommandHandler: INotificationHandler<CreateOrdersCommand>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly OrderingContext _context;

        public CreateOrdersCommandHandler(IOrderRepository orderRepository, OrderingContext context)
        {
            _orderRepository = orderRepository;
            _context = context;
        }

        public async Task Handle(CreateOrdersCommand message, CancellationToken cancellationToken)
        {
            //TODO create delivery address
            //Address address = null;
            foreach (var messageOrder in message.Orders)
            {
                var order = new Order(DateTime.UtcNow, OrderStatus.Created.Id, message.ClientId, string.Empty, messageOrder.restaurantId, messageOrder.menuItemInts);

                _orderRepository.Add(order)
            }

        }
    }
}
