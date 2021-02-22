using FoodOrder.Domain.Entity.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodOrder.Data.SqlServer.Mapping
{
    internal class OrderStatusMap
        : IEntityTypeConfiguration<OrderStatus>
    {
        public void Configure(EntityTypeBuilder<OrderStatus> m)
        {
            m.ToTable("orderstatus");

            m.HasKey(o => o.Id);

            m.Property(o => o.Id)
                .HasDefaultValue(1)
                .ValueGeneratedNever()
                .IsRequired();

            m.Property(o => o.Name)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}