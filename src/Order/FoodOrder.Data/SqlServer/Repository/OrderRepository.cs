using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FoodOrder.Domain;
using FoodOrder.Domain.Entity.OrderAggregate;
using Microsoft.EntityFrameworkCore;

namespace FoodOrder.Data.SqlServer.Repository
{
    public class OrderRepository:IOrderRepository
    {
        private readonly OrderingContext _context;

        public OrderRepository(OrderingContext context)
        {
            _context = context;
        }
        public IUnitOfWork UnitOfWork => _context;
        public Order Add(Order order)
        {
            return _context.Orders.Add(order).Entity;
        }

        public void Update(Order order)
        {
            _context.Entry(order).State = EntityState.Modified;
        }

        public async Task<Order> GetAsync(int orderId, CancellationToken token = default)
        {
            var order = await _context
                .Orders
                //.Include(x => x.Address)
                .FirstOrDefaultAsync(o => o.Id == orderId, cancellationToken: token);
            
            if (order != null)
            {
                await _context.Entry(order)
                    .Collection(i => i.OrderItems).LoadAsync(token);
                await _context.Entry(order)
                    .Reference(i => i.OrderStatus).LoadAsync(token);
            }

            return order;
        }
    }
}
