using System.Threading.Tasks;
using FoodOrder.Data.SqlServer;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace FoodOrder.Data.Tests
{
    public class OrderingDbContextTests
    {
        [Test]
        public static async Task OrderingDb_EnsureCreated_SqlServer()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<OrderingContext>()
                .UseSqlServer("Server=.;Database=FoodOrdering.UnitTest;Trusted_Connection=True;")
                .Options;

            await using var ctx = new OrderingContext(options);
            // Act
            await ctx.Database.EnsureDeletedAsync();
            await ctx.Database.EnsureCreatedAsync();
        }
    }
}