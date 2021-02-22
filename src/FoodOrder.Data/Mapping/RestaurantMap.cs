using FoodOrder.Domain.Entity.RestaurantAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodOrder.Data.Mapping
{
    internal class RestaurantMap
        : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> m)
        {
            m.ToTable("restaurants");

            m.HasKey(o => o.Id);

            m.Ignore(b => b.DomainEvents);
            m.Property(cr => cr.Name).IsRequired();
            m.Property(cr => cr.City).IsRequired();
            m.HasMany(x => x.Categories).WithOne().OnDelete(DeleteBehavior.Cascade);
            //TODO add all properties mapping explicitly
        }
    }
}