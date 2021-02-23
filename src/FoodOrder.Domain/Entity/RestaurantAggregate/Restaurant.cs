using System.Collections.Generic;

namespace FoodOrder.Domain.Entity.RestaurantAggregate
{
    public class Restaurant : Entity, IAggregateRoot
    {
        public Restaurant()
        {
            Categories = new List<Category>();
        }

        public Restaurant(string name, string city, string suburb, string logoPath, int rank):this()
        {
            Name = name;
            City = city;
            Suburb = suburb;
            LogoPath = logoPath;
            Rank = rank;
        }

        public string Name { get; private set; }
        public string City { get; private set; }
        public string Suburb { get; private set; }
        public string LogoPath { get; private set; }
        public int Rank { get; private set; }
        public ICollection<Category> Categories { get; private set; }
    }
}
