using System;

namespace FoodOrder.Shared.Models.Models
{
    [Serializable]
    public class MenuItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}