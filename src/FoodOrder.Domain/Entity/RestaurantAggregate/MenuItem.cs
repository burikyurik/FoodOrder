namespace FoodOrder.Domain.Entity.RestaurantAggregate
{
    public class MenuItem : Entity
    {
        public MenuItem(string name, decimal price)
        {
            //TODO add price validation
            Name = name;
            Price = price;
        }

        public string Name { get; private set; }
        public decimal Price { get; private set; }
    }
}