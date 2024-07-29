using DDD.Application.Repository;
using DDD.Domain.AggregateModels.BuyerModel;
using DDD.Domain.Events;
using MediatR;

namespace DDD.Application.DomainEventHandlers;

public class OrderStartedDomainEventHandIer : INotificationHandler<OrderStartedDomainEvent>
{
    private readonly IBuyerRepository _buyerRepository;
    public OrderStartedDomainEventHandIer(IBuyerRepository buyerRepository)
    {
        _buyerRepository = buyerRepository ?? throw new ArgumentNullException(nameof(buyerRepository));
    }

    public Task Handle(OrderStartedDomainEvent notification, CancellationToken cancellationToken)
    {
        if (notification.Order.UserName == "")
        {
            Buyer buyer = new Buyer(notification.BuyerUserName);
            // _buyerRepository.Add(buyer) // yeni bir buyer oluştur

            // buyerId ile orderı set et
        }
        return Task.CompletedTask;
    }
}