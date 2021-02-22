using System.Collections.Generic;

namespace FoodOrder.Domain.Entity.RestaurantAggregate
{
    public class Category : Entity
    {
        public Category(string name, int restaurantId)
        {
            Name = name;
            RestaurantId = restaurantId;
            MenuItems = new List<MenuItem>();
        }

        public string Name { get; private set; }
        public int RestaurantId { get; private set; }
        public Restaurant Restaurant { get; private set; }
        public ICollection<MenuItem> MenuItems { get; private set; }
    }
}