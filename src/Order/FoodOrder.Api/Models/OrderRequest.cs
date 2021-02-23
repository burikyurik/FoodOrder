using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrder.Api.Models
{
    public class OrderRequest
    {
        public int? ClientId { get; set; }
        public ICollection<(int restaurantId, int[] menuItemInts)> Orders { get; set; }
    }
}
