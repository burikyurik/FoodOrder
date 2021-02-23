using System;
using System.Threading;
using System.Threading.Tasks;
using FoodOrder.Business.Command;
using FoodOrder.Domain.Entity.OrderAggregate;
using FoodOrder.Domain.Entity.RestaurantAggregate;
using FoodOrder.Domain.ValueObject;
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
            Address address = null;
            foreach (var messageOrder in message.Orders)
            {
                var order = new Order(DateTime.UtcNow, address, OrderStatus.Created.Id, message.ClientId, string.Empty, messageOrder.restaurantId, messageOrder.menuItemInts);

                _orderRepository.Add(order)
            }
            
        }
    }
}
