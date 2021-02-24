namespace FoodOrder.Api.Models
{
    public class OrderRequest
    {
        public int? ClientId { get; set; }
        public OrderData[] Orders { get; set; }
    }

    public class OrderData
    {
        public int RestaurantId { get; set; }
        public ItemData[] Items { get; set; }
    }

    public class ItemData
    {
        public int MenuItemId { get; set; }
    }
}
