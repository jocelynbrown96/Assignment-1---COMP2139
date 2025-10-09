using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models;

public class Event
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public decimal TicketPrice { get; set; }

    [Range(0, int.MaxValue)]
    public int AvailableTickets { get; set; }

    // Foreign key
    public int CategoryId { get; set; }
    public Category? Category { get; set; }

    // Relationships
    public ICollection<PurchaseEvent> PurchaseEvents { get; set; } = new List<PurchaseEvent>();
}