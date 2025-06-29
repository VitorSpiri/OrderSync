using OrderSync.Domain.Entities;

namespace UnitTests;

public class OrderTests
{
    [Fact]
    public void Order_WhenCreatedWithValidData_ShouldHaveCorrectProperties()
    {
        var id = Ulid.NewUlid();
        var code = 100;
        var customerId = Ulid.NewUlid();
        var value = 140.50m;
        var dueDate = DateTime.UtcNow.AddDays(8);
        var status = OrderStatus.InProduction;
        
        var order = new Order(id, code, customerId, value, dueDate, status);

        Assert.NotNull(order);
        Assert.Equal(order.Id, id);
        Assert.Equal(order.Code, code);
        Assert.Equal(order.CustomerId, customerId);
        Assert.Equal(order.Value, value);
        Assert.StrictEqual(order.DueDate, dueDate);
        Assert.StrictEqual(order.Status, status);
    }
    
    
}