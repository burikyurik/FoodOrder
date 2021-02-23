using System;
using FoodOrder.Shared.Models.Models;

namespace FoodOrder.Shared.Models
{
    public interface IMessage
    {
        Guid CorrelationId { get; }

        Order Order { get; }
    }
}
