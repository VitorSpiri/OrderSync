namespace OrderSync.Domain.Entities;

public class Customer : EntityBase
{
    public string Name { get; private set; }
    public Customer(Ulid id, string name) : base(id)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Customer must have a name", nameof(name));
        
        Name = name;
    }

    
    
}