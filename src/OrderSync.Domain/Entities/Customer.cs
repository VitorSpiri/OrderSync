namespace OrderSync.Domain.Entities;

public class Customer(string name)
{
    public string Name { get; private set; } = name;
}