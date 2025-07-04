using OrderSync.Application.Interfaces;
using OrderSync.Domain.Entities;

namespace OrderSync.Infrastructure.Connectors;

public class MockSapConnector : ISapConnector
{
    public Task<List<Order>> GetDelayedOrdersAsync()
    {
        throw new NotImplementedException();
    }
}