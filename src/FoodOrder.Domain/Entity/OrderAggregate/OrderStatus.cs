using System;
using System.Collections.Generic;
using System.Linq;
using FoodOrder.Domain.Exceptions;
using FoodOrder.Domain.ValueObject;

namespace FoodOrder.Domain.Entity.OrderAggregate
{
    public class OrderStatus
        : Enumeration
    {
        public static OrderStatus Created = new OrderStatus(1, nameof(Created).ToLowerInvariant());
        public static OrderStatus Accepted = new OrderStatus(2, nameof(Accepted).ToLowerInvariant());
        public static OrderStatus Cooked = new OrderStatus(3, nameof(Cooked).ToLowerInvariant());
        public static OrderStatus Paid = new OrderStatus(4, nameof(Paid).ToLowerInvariant());
        public static OrderStatus Delivered = new OrderStatus(5, nameof(Delivered).ToLowerInvariant());
        public static OrderStatus Cancelled = new OrderStatus(6, nameof(Cancelled).ToLowerInvariant());

        public OrderStatus(int id, string name)
            : base(id, name)
        {
        }

        public static IEnumerable<OrderStatus> List() =>
            new[] { Created, Accepted, Cooked, Paid, Delivered, Cancelled };

        public static OrderStatus FromName(string name)
        {
            var state = List()
                .SingleOrDefault(s => string.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            {
                throw new OrderingDomainException($"Possible values for OrderStatus: {string.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }

        public static OrderStatus From(int id)
        {
            var state = List().SingleOrDefault(s => s.Id == id);

            if (state == null)
            {
                throw new OrderingDomainException($"Possible values for OrderStatus: {string.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }
    }
}