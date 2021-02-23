using System.Threading;
using System.Threading.Tasks;
using FoodOrder.Domain;
using FoodOrder.Domain.Entity.ClientAggregate;
using Microsoft.EntityFrameworkCore;

namespace FoodOrder.Data.SqlServer.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly OrderingContext _context;

        public ClientRepository(OrderingContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;
        public Client Add(Client client)
        {
            return _context.Clients.Add(client).Entity;
        }

        public void Update(Client client)
        {
            _context.Entry(client).State = EntityState.Modified;
        }

        public async Task<Client> GetAsync(int clientId, CancellationToken token = default)
        {
            var restaurant = await _context.Clients
                .FirstOrDefaultAsync(o => o.Id == clientId, cancellationToken: token);

            return restaurant;
        }
    }
}