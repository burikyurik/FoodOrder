using System;
using System.Threading;
using System.Threading.Tasks;
using FoodOrder.Business.Command;
using MediatR;

namespace FoodOrder.Business.CommandHandlers
{
    public class CreateOrdersCommandHandler: INotificationHandler<CreateOrdersCommand>
    {
        public async Task Handle(CreateOrdersCommand notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
