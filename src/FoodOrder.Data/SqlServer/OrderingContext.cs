using System;
using System.Threading;
using System.Threading.Tasks;
using FoodOrder.Domain;
using FoodOrder.Domain.Entity.ClientAggregate;
using FoodOrder.Domain.Entity.OrderAggregate;
using FoodOrder.Domain.Entity.RestaurantAggregate;
using Microsoft.EntityFrameworkCore;

namespace FoodOrder.Data.SqlServer
{
    public class OrderingContext: DbContext, IUnitOfWork
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Category> RestaurantCategories { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Client> Clients { get; set; }
        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            var result = await base.SaveChangesAsync(cancellationToken);
            //TODO Dispatch Domain Events collection. 
            return true;
        }

        public OrderingContext(DbContextOptions<OrderingContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
                throw new ArgumentNullException(nameof(modelBuilder));
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
