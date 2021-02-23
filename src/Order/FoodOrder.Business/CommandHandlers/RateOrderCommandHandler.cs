using System;
using System.Threading;
using System.Threading.Tasks;
using FoodOrder.Business.Command;
using MediatR;

namespace FoodOrder.Business.CommandHandlers
{
    public class RateOrderCommandHandler : INotificationHandler<RateOrderCommand>
    {
        public async Task Handle(RateOrderCommand notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}