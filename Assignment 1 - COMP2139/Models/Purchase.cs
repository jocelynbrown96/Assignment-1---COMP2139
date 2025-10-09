using System.ComponentModel.DataAnnotations;

namespace Assignment_1___COMP2139.Models;

public class Purchase
{
    public int Id { get; set; }

    [Required]
    public DateTime PurchaseDate { get; set; }

    [Range(0, double.MaxValue)]
    public decimal TotalCost { get; set; }

    [Required]
    public string GuestName { get; set; } = string.Empty;

    [Required, EmailAddress]
    public string GuestEmail { get; set; } = string.Empty;

    public ICollection<PurchaseEvent> PurchaseEvents { get; set; } = new List<PurchaseEvent>();
}