namespace OrderSync.Domain.Entities;

public abstract class EntityBase
{
    public Ulid Id { get; protected set; }

    protected EntityBase(Ulid id)
    {
        Id = id;
    }
}