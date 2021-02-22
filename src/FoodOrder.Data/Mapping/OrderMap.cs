using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodOrder.Data.Mapping
{
    internal class OrderMap: IEntityTypeConfiguration<Domain.Entity.OrderAggregate.Order>
    {
        public void Configure(EntityTypeBuilder<Domain.Entity.OrderAggregate.Order> m)
        {
            m.ToTable("Orders");
            m.HasKey(x => x.Id);
            m.OwnsOne(o => o.Address, a =>
            {
                a.Property<int>("OrderId");
                a.WithOwner();
            });
            m.Ignore(b => b.DomainEvents);
            m.HasMany(x => x.OrderItems).WithOne().HasForeignKey(x => x.OrderId);
            m.HasOne(x => x.OrderStatus).WithMany().HasForeignKey(x => x.OrderStatusId);
            m.HasOne(x => x.Client).WithMany().HasForeignKey(x => x.ClientId);
            //TODO add all properties mapping explicitly
        }
    }
}
