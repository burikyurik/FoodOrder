using System.Threading;
using System.Threading.Tasks;

namespace FoodOrder.Domain.Entity.OrderAggregate
{
    public interface IOrderRepository : IRepository<Order>
    {
        Order Add(Order order);

        void Update(Order order);

        Task<Order> GetAsync(int orderId, CancellationToken token = default);
    }
}