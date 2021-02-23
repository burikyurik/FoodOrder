using System.Threading.Tasks;
using FoodOrder.Shared.Models.Command;
using FoodOrder.Shared.Models.IntegrationEvents;
using FoodOrder.Shared.Models.Models;
using MassTransit;

namespace FoodOrder.Payment.Api.Consumers
{
    public class ProcessPaymentConsumer : IConsumer<IProcessPayment>
    {
        public ProcessPaymentConsumer()
        {
        }
        public async Task Consume(ConsumeContext<IProcessPayment> context)
        {
            //TODO deliver order
            await Task.Delay(2000);
            this.UpdateOrderState(context.Message.Order);
            await context.Publish<IPaymentProcessed>(new
            {
                CorrelationId = context.Message.CorrelationId,
                Order = context.Message.Order
            });
        }

        private void UpdateOrderState(Order order)
        {
            order.Status = Status.Paid;
        }
    }
}