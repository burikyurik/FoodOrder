namespace FoodOrder.Domain.Entity.ClientAggregate
{
    public class Client : Entity,IAggregateRoot
    {
        public Client(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        //TODO add payment methods, delivery details, order history ...
    }
}
