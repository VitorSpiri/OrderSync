namespace OrderSync.Domain.Entities;

public class Customer(Ulid id, string name) : EntityBase(id)
{
    public string Name { get; private set; } = name;
}