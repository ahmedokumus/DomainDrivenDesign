using MediatR;

namespace DDD.Domain.SeedWork;

public abstract class BaseEntity
{
    public int Id { get; set; }

    private ICollection<INotification> _domainEvents = null!;
    public ICollection<INotification> DomainEvents => _domainEvents;

    public void AddDomainEvents(INotification notification)
    {
        _domainEvents ??= new List<INotification>();
        _domainEvents.Add(notification);
    }

}