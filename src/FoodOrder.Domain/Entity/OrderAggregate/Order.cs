using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using FoodOrder.Domain.ValueObject;

namespace FoodOrder.Domain.Entity.OrderAggregate
{
    public class Order : Entity, IAggregateRoot
    {
        public Order(DateTime orderDate, Address address, OrderStatus orderStatus, int? clientId, string description, int restaurantId, IList<OrderItem> orderItems)
        {
            //TODO add validation
            OrderDate = orderDate;
            Address = address;
            OrderStatus = orderStatus;
            ClientId = clientId;
            Description = description;
            RestaurantId = restaurantId;
            OrderItems = new ReadOnlyCollection<OrderItem>(orderItems);
        }

        public DateTime OrderDate { get; private set; }
        public Address Address { get; private set; }
        public OrderStatus OrderStatus { get; private set; }
        public int? ClientId { get; private set; }
        public string Description { get; private set; }
        public int RestaurantId { get; private set; }
        public IReadOnlyCollection<OrderItem> OrderItems { get; private set; }
    }
}
