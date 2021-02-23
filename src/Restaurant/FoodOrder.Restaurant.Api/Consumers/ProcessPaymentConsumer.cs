using System.Threading.Tasks;
using FoodOrder.Shared.Models.Command;
using FoodOrder.Shared.Models.IntegrationEvents;
using FoodOrder.Shared.Models.Models;
using MassTransit;

namespace FoodOrder.Restaurant.Api.Consumers
{
    public class PrepareOrderConsumer : IConsumer<IPrepareOrder>
    {
        public PrepareOrderConsumer()
        {
        }
        public async Task Consume(ConsumeContext<IPrepareOrder> context)
        {
            //TODO prepare order
            await Task.Delay(2000);
            this.UpdateOrderState(context.Message.Order);
            await context.Publish<IOrderPrepared>(new
            {
                CorrelationId = context.Message.CorrelationId,
                Order = context.Message.Order
            });
        }

        private void UpdateOrderState(Order order)
        {
            order.Status = Status.Cooked;
        }
    }
}