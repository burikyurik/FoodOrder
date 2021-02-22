using FoodOrder.Domain.Entity.RestaurantAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodOrder.Data.Mapping
{
    internal class MenuItemMap
        : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> m)
        {
            m.ToTable("menuItems");

            m.HasKey(o => o.Id);

            m.Ignore(b => b.DomainEvents);
            m.Property(cr => cr.Name).IsRequired();
            m.Property(cr => cr.Price).IsRequired();
        }
    }
}