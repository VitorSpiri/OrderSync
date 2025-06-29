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


    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    public void Customer_WhenCreatedWithNullName_ShouldThrowArgumentNullException(string? emptyName)
    {
        var customerId = new Ulid();
        
        Action act = () => new Customer( customerId, emptyName);
        act.Should().Throw<ArgumentException>().And.ParamName.Should().Be("name");
        
    }
    
}