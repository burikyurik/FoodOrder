using System;
using System.Collections.Generic;
using System.Text;

namespace FoodOrder.Business.Dtos
{
    public class RestaurantMenuDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Suburb { get; set; }
        public int Rank { get; set; }
        public Uri Logo { get; set; }
        public ICollection<MenuItemDto> Items { get; set; }
    }
}
