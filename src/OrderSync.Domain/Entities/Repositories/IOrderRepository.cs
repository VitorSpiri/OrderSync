namespace OrderSync.Domain.Entities.Repositories;

public interface IOrderRepository
{
    Task<Order> GetByIdAsync(Ulid id);
    Task<IEnumerable<Order>> GetAllAsync();
    Task AddAsync(Order order);
    Task UpdateAsync(Order order);
}