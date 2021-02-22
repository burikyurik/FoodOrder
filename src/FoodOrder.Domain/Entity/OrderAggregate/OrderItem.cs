namespace FoodOrder.Domain.Entity.OrderAggregate
{
    public class OrderItem : Entity
    {
        public OrderItem(int menuItemId, decimal unitPrice, decimal discount, int units=1)
        {
            //TODO add validation
            MenuItemId = menuItemId;
            UnitPrice = unitPrice;
            Discount = discount;
            Units = units;
        }

        public int MenuItemId { get; private set; }
        public decimal UnitPrice { get; private set; }
        public decimal Discount { get; private set; }
        public int Units { get; private set; }
    }
}