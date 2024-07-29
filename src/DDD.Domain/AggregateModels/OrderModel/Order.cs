using DDD.Domain.Events;
using DDD.Domain.SeedWork;

namespace DDD.Domain.AggregateModels.OrderModel;

public class Order : BaseEntity, IAggregateRoot
{
    public DateTime OrderDate { get; private set; }
    public string Description { get; private set; }
    public string OrderStatus { get; private set; }

    public string UserName { get; private set; }
    
    public Address Address { get; private set; }

    public ICollection<OrderItem> OrderItems { get; private set; }

    public Order(string description, string orderStatus, Address address, ICollection<OrderItem> orderItems, DateTime orderDate, string userName)
    {
        //Validasyon kuralları
        if (address.City == "")
            throw new Exception("Şehir boş olamaz");

        OrderDate = orderDate;
        Description = description ?? throw new ArgumentNullException(nameof(description));
        OrderStatus = orderStatus ?? throw new ArgumentNullException(nameof(orderStatus));
        UserName = userName ?? throw new ArgumentNullException(nameof(userName));
        Address = address ?? throw new ArgumentNullException(nameof(address));
        OrderItems = orderItems ?? throw new ArgumentNullException(nameof(orderItems));

        AddDomainEvents(new OrderStartedDomainEvent(userName, order: this));
    }

    public void AddOrderItem(int quantity, decimal price, int productId)
    {
        OrderItem item = new(quantity, price, productId);

        OrderItems.Add(item);
    }
}