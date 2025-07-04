using OrderSync.Domain.Entities;
using OrderSync.Domain.Entities.Repositories;

namespace OrderSync.Infrastructure.Repositories;

public class OrderRepository : IOrderRepository
{
    public Task<Order> GetByIdAsync(Ulid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Order>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Order order)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Order order)
    {
        throw new NotImplementedException();
    }
}