using System;
using System.Threading;
using System.Threading.Tasks;
using FoodOrder.Domain;
using FoodOrder.Domain.Entity.RestaurantAggregate;
using Microsoft.EntityFrameworkCore;

namespace FoodOrder.Data.SqlServer.Repository
{
    public class RestaurantRepository: IRestaurantRepository
    {
        private readonly OrderingContext _context;

        public RestaurantRepository(OrderingContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;
        public Restaurant Add(Restaurant restaurant)
        {
            return _context.Restaurants.Add(restaurant).Entity;
        }

        public void Update(Restaurant restaurant)
        {
            _context.Entry(restaurant).State = EntityState.Modified;
        }

        public async Task<Restaurant> GetAsync(int restaurantId, CancellationToken token = default)
        {
            var restaurant = await _context.Restaurants
                .Include(x=>x.Categories)
                .ThenInclude(x=>x.MenuItems)
                .AsSplitQuery()
                .FirstOrDefaultAsync(o => o.Id == restaurantId, cancellationToken: token);

            return restaurant;
        }
    }
}
