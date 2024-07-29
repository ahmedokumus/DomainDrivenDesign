using DDD.Application.Repository;

namespace DDD.Infrastructure.Repository;

public class OrderRepository : IOrderRepository
{
    public Task<int> SaveChangesAsync()
    {
        return Task.FromResult(1);
    }
}