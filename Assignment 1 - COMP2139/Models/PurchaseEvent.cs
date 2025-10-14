using System.ComponentModel.DataAnnotations;

namespace Assignment_1___COMP2139.Models
{
    public class PurchaseEvent
    {
        public int PurchaseId { get; set; }
        public Purchase Purchase { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }
    }
}