using FoodOrder.Domain.Entity.RestaurantAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodOrder.Data.SqlServer.Mapping
{
    internal class CategoryMap
        : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> m)
        {
            m.ToTable("categories");

            m.HasKey(o => o.Id);

            m.Ignore(b => b.DomainEvents);
            m.Property(cr => cr.Name).IsRequired();
            m.HasMany(x => x.MenuItems).WithOne(x=>x.Category).HasForeignKey(x=>x.CategoryId).OnDelete(DeleteBehavior.Cascade);
            //TODO add all properties mapping explicitly
        }
    }
}