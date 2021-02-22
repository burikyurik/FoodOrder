using System.Collections.Generic;

namespace FoodOrder.Domain.Entity.RestaurantAggregate
{
    public class Category : Entity
    {
        public Category(string name, ICollection<MenuItem> menuItems)
        {
            Name = name;
            MenuItems = menuItems;
        }

        public string Name { get; private set; }
        public ICollection<MenuItem> MenuItems { get; private set; }

    }
}