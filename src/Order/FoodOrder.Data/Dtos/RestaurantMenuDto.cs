using System.Collections.Generic;

namespace FoodOrder.Data.Dtos
{
    public class RestaurantMenuDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Suburb { get; set; }
        public int Rank { get; set; }
        public string Logo { get; set; }
        public ICollection<MenuItemDto> Items { get; set; }
    }
}
