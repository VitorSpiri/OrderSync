namespace OrderSync.Domain.Entities;

public abstract class EntityBase
{
    public Ulid Id { get; protected set; }

    protected EntityBase(Ulid id)
    {
        Id = id;
    }
    
    public override bool Equals(object obj)
    {
        if (obj is EntityBase other)
            return Id == other.Id;
        return false;
    }
}