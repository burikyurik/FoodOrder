using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodOrder.Data.Mapping
{
    internal class OrderItemMap : IEntityTypeConfiguration<Domain.Entity.OrderAggregate.OrderItem>
    {
        public void Configure(EntityTypeBuilder<Domain.Entity.OrderAggregate.OrderItem> m)
        {
            m.ToTable("OrderItems");
            m.HasKey(x => x.Id);
            m.Ignore(b => b.DomainEvents);
            //TODO add all properties mapping explicitly
        }
    }
}