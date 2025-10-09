namespace Assignment_1___COMP2139.Models;

public class PurchaseEvent
{
    public int PurchaseId { get; set; }
    public required Purchase Purchase { get; set; }

    public int EventId { get; set; }
    public required Event Event { get; set; }
}