using OrderSync.Domain.Entities;

namespace OrderSync.Application.Interfaces;

public interface ISapConnector
{
    Task<List<Order>> GetDelayedOrdersAsync();
}