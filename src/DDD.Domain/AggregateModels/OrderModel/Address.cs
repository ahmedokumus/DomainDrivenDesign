using DDD.Domain.SeedWork;

namespace DDD.Domain.AggregateModels.OrderModel;

public class Address : ValueObject
{
    public string City { get; set; }
    public string Country { get; set; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return new object[]
        {
            City, 
            Country
        };
    }
}