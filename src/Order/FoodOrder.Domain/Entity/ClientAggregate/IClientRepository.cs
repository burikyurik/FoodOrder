using System.Threading;
using System.Threading.Tasks;
using FoodOrder.Domain.Entity.OrderAggregate;

namespace FoodOrder.Domain.Entity.ClientAggregate
{
    public interface IClientRepository : IRepository<Client>
    {
        Client Add(Client client);

        void Update(Client client);

        Task<Client> GetAsync(int clientId, CancellationToken token = default);
    }
}