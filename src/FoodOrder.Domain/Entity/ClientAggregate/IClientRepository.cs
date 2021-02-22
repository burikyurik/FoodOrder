using System.Threading.Tasks;
using FoodOrder.Domain.Entity.OrderAggregate;

namespace FoodOrder.Domain.Entity.ClientAggregate
{
    public interface IClientRepository : IRepository<Client>
    {
        Order Add(Client order);

        void Update(Client order);

        Task<Client> GetAsync(int orderId);
    }
}