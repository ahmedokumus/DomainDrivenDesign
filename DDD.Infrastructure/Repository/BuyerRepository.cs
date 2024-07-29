using DDD.Application.Repository;

namespace DDD.Infrastructure.Repository;

public class BuyerRepository : IBuyerRepository
{
    public Task<int> SaveChangesAsync()
    {
        return Task.FromResult(1);
    }
}