using System;
using System.Threading;
using System.Threading.Tasks;
using FoodOrder.Business.Command;
using MediatR;

namespace FoodOrder.Business.CommandHandlers
{
    public class CancelOrderCommandHandler : ICancellableAsyncNotificationHandler<CancelOrderCommand>
    {
        public async Task Handle(CancelOrderCommand notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}