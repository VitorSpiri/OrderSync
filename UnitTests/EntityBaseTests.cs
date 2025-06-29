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
        var firstEntityId = id;
        var secondEntityId = id;
        
        Assert.Equal(id, firstEntityId);
        Assert.Equal(id, secondEntityId);
        Assert.Equal(firstEntityId, secondEntityId);
        Assert.True(firstEntityId.Equals(secondEntityId));
    }

    [Fact]
    public void EntityBase_WhenCreatedWithDifferentId_ShouldNotHaveCorrectProperties()
    {
        var firstEntityId = Ulid.NewUlid();
        var secondEntityId = Ulid.NewUlid();
        
        Assert.NotEqual(firstEntityId, secondEntityId);
        Assert.False(firstEntityId.Equals(secondEntityId));
    }
}