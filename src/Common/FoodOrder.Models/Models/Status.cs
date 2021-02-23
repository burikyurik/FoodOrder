using System;

namespace FoodOrder.Shared.Models.Models
{
    [Serializable]
    public enum Status
    {
        Created,
        Accepted,
        Cooked,
        Paid,
        Delivered,
        Cancelled
    }
}