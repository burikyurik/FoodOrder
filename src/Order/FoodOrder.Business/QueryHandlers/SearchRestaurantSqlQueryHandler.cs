using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FoodOrder.Business.Query;
using FoodOrder.Data.Dtos;
using FoodOrder.Data.SqlServer;
using FoodOrder.Domain.Entity.RestaurantAggregate;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodOrder.Business.QueryHandlers
{
    public class SearchRestaurantSqlQueryHandler : IRequestHandler<SearchRestaurantQuery, ICollection<RestaurantMenuDto>>
    {
        private readonly OrderingContext _context;

        public SearchRestaurantSqlQueryHandler(OrderingContext context)
        {
            _context = context;
        }

        public async Task<ICollection<RestaurantMenuDto>> Handle(SearchRestaurantQuery message, CancellationToken cancellationToken)
        {
            //TODO move query to repository
            var result = new List<RestaurantMenuDto>();
            var restaurantsIds = await _context.Restaurants
                .AsNoTracking()
                .Where(x => EF.Functions.Like(x.City, message.Location))
                .Select(x => x.Id)
                .ToListAsync(cancellationToken);
            if (!restaurantsIds.Any())
                return result;
            var menuItemsWithCategory = await _context.RestaurantCategories.Include(x=>x.Restaurant).Include(x=>x.MenuItems).AsNoTracking()
                .Where(x => restaurantsIds.Contains(x.Restaurant.Id) && EF.Functions.Like(x.Name, message.KeyWord))
                .Select(x => MapDto(x))
                .ToListAsync(cancellationToken);
            result.AddRange(menuItemsWithCategory);

            var selectedMenuItemsIds = menuItemsWithCategory.Select(x => x.Id).Distinct().ToHashSet();
            var menuItems = await _context.MenuItems.AsNoTracking()
                .Where(x => restaurantsIds.Contains(x.Category.Restaurant.Id) && EF.Functions.Like(x.Name, message.KeyWord) && !selectedMenuItemsIds.Contains(x.Id))
                .Select(x => MapDto(x.Category))
                .ToListAsync(cancellationToken);
            result.AddRange(menuItems);

            return result;
        }

        private static RestaurantMenuDto MapDto(Category category)
        {
            return new RestaurantMenuDto
            {
                Id = category.RestaurantId,
                Name = category.Restaurant.Name,
                Logo = category.Restaurant.LogoPath,
                Rank = category.Restaurant.Rank,
                Suburb = category.Restaurant.Suburb,
                Items = category.MenuItems.Select(x => new MenuItemDto
                {
                    Id = x.Id,
                    Price = x.Price,
                    Name = x.Name
                }).ToList()
            };
        }
    }
}
