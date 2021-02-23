using System;

namespace FoodOrder.Data.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
    }
}