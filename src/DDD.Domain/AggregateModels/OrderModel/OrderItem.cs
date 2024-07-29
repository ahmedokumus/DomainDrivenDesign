using DDD.Domain.SeedWork;

namespace DDD.Domain.AggregateModels.OrderModel;

public class OrderItem : BaseEntity
{
    public int Quantity { get; private set; }
    public decimal Price { get; private set; }
    public int ProductId { get; private set; }

    public OrderItem(int quantity, decimal price, int productId)
    {
        //Validasyon kuralları

        Quantity = quantity;
        Price = price;
        ProductId = productId;
    }
}