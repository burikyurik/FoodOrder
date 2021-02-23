using MediatR;

namespace FoodOrder.Business.Command
{
    public class RateOrderCommand : INotification
    {
        public int OrderId { get; }
        public int Rate { get; }

        public RateOrderCommand(int orderId, int rate)
        {
            OrderId = orderId;
            Rate = rate;
        }
    }
}