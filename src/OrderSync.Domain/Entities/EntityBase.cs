namespace OrderSync.Domain.Entities;

public class EntityBase
{
    public Ulid Id { get; protected set; }

    protected EntityBase(Ulid id)
    {
        Id = id;
    }
}