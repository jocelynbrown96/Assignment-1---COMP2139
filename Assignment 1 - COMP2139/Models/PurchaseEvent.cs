namespace Assignment1.Models;

public class PurchaseEvent
{
    public int PurchaseId { get; set; }
    public Purchase Purchase { get; set; }

    public int EventId { get; set; }
    public Event Event { get; set; }
}