﻿using OrderSync.Domain.Entities;

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

    [Theory]
    [InlineData(0)]
    [InlineData(-10)]
    public void Order_WhenCreatedWithInValidValue_ShouldThrowArgumentException(decimal value)
    {
        var exception = Assert.Throws<ArgumentException>(() =>
            new Order(Ulid.NewUlid(), 0, Ulid.NewUlid(), value, DateTime.UtcNow, OrderStatus.InProduction)
        );
        Assert.Equal("value", exception.ParamName);
    }

    [Fact]
    public void Order_WhenDueDateIsDelayed_ShouldThrowArgumentException()
    {
        var delayedDate = DateTime.UtcNow.AddDays(-1);

        var exception = Assert.Throws<ArgumentException>(
            () => new Order(Ulid.NewUlid(), 10, Ulid.NewUlid(), 150.50m, delayedDate, OrderStatus.InProduction)
        );

        Assert.Equal("dueDate", exception.ParamName);
    }
    
    
}