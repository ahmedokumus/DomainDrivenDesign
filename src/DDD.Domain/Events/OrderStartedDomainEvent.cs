using DDD.Domain.AggregateModels.OrderModel;
using MediatR;

namespace DDD.Domain.Events;

public class OrderStartedDomainEvent : INotification
{
    public string BuyerUserName { get; private set; }
    public Order Order { get; set; }

    public OrderStartedDomainEvent(string buyerUserName, Order order)
    {
        BuyerUserName = buyerUserName ?? throw new ArgumentNullException(nameof(buyerUserName));
        Order = order;
    }
}