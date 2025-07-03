namespace OrderSync.Domain.Entities;

public class Order : EntityBase
{
    public int Code { get; private set; }
    public Ulid CustomerId { get; private set; }
    public decimal Value { get; private set; }
    public DateTime DueDate { get; private set; }
    public OrderStatus Status { get; private set; }
    
    public Order(Ulid id, int code, Ulid customerId, decimal value, DateTime dueDate, OrderStatus status) : base(id)
    {
        if(value <= 0)
            throw new ArgumentException("Order must have a value greater than 0", nameof(value));

        if (dueDate < DateTime.UtcNow)
            throw new ArgumentException("Due Date cannot be in the past", nameof(dueDate));
        
        Id  = id;
        Code = code;
        CustomerId = customerId;
        Value = value;
        DueDate = dueDate;
        Status = status;
    }
}

public enum OrderStatus
{
    InProduction,
    Waiting,
    Delayed,
    Cancelled
}