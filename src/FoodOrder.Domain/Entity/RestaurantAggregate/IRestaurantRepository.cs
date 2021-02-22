using System.Threading.Tasks;

namespace FoodOrder.Domain.Entity.RestaurantAggregate
{
    public interface IRestaurantRepository : IRepository<Restaurant>
    {
        Restaurant Add(Restaurant restaurant);

        void Update(Restaurant restaurant);

        Task<Restaurant> GetAsync(int restaurantId);
    }
}