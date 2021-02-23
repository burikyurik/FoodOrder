using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using FoodOrder.Domain.Entity.RestaurantAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodOrder.Data.SqlServer.Mapping
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
            m.HasMany(x => x.Categories)
                .WithOne(x => x.Restaurant)
                .OnDelete(DeleteBehavior.Cascade);
            //TODO add all properties mapping explicitly

        }
    }
}