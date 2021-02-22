using FoodOrder.Domain.Entity.ClientAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodOrder.Data.SqlServer.Mapping
{
    internal class ClientMap
        : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> m)
        {
            m.ToTable("categories");

            m.HasKey(o => o.Id);

            m.Ignore(b => b.DomainEvents);
            m.Property(cr => cr.Name).IsRequired();
            //TODO add all properties mapping explicitly
        }
    }
}