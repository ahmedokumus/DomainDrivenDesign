using DDD.Domain.SeedWork;

namespace DDD.Domain.AggregateModels.BuyerModel;

public class Buyer : BaseEntity
{
    public string UserName { get; private set; }

    public Buyer(string userName)
    {
        UserName = userName ?? throw new ArgumentNullException(nameof(userName));
    }
}