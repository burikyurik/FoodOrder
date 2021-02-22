namespace FoodOrder.Domain.Entity.RestaurantAggregate
{
    public class MenuItem : Entity
    {
        public MenuItem(string name, decimal price, int categoryId)
        {
            //TODO add price validation
            Name = name;
            Price = price;
            CategoryId = categoryId;
        }

        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public int CategoryId { get; private set; }
        public Category Category { get; private set; }
    }
}