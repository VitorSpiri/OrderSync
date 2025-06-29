using OrderSync.Domain.Entities;

namespace UnitTests;

public class TestableEntity(Ulid id) : EntityBase(id);

public class EntityBaseTests
{
    [Fact]
    public void EntityBase_WhenCreatedWithValidId_ShouldSetIdCorrectly()
    {
        var id = Ulid.NewUlid();
        
        var entity = new TestableEntity(id);
        
        Assert.Equal(id, entity.Id);
    }
    
    
    [Fact]
    public void EntityBase_WhenCreatedWithSameId_ShouldHaveCorrectProperties()
    {
        var id = Ulid.NewUlid();
        var firstEntityId = new TestableEntity(id);
        var secondEntityId = new TestableEntity(id);
        
        Assert.Equal(firstEntityId, secondEntityId);
        Assert.True(firstEntityId.Equals(secondEntityId));
    }

    [Fact]
    public void EntityBase_WhenCreatedWithDifferentId_ShouldNotHaveCorrectProperties()
    {
        var firstEntityId = new TestableEntity(Ulid.NewUlid());
        var secondEntityId = new TestableEntity(Ulid.NewUlid());
        
        Assert.NotEqual(firstEntityId, secondEntityId);
        Assert.False(firstEntityId.Equals(secondEntityId));
    }

    [Fact]
    public void EntityBase_WhenCreatedWithNullableData_ShouldNotHaveCorrectProperties()
    {
        var id = Ulid.NewUlid();
        var entity = new TestableEntity(id);
        
        Assert.False(entity.Equals(null));
    }
}