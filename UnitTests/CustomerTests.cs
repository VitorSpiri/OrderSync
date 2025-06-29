using FluentAssertions;
using OrderSync.Domain.Entities;

namespace UnitTests;

public class CustomerTests
{
    [Fact]
    public void Customer_WhenCreatedWithValidData_ShouldHaveCorrectProperties()
    {
        //Arrange
        var customerId = new Ulid();
        var customerName = "Customer";

        //Act
        var customer = new Customer(customerId, customerName);

        //Assert
        customer.Name.Should().Be(customerName);
    }
}