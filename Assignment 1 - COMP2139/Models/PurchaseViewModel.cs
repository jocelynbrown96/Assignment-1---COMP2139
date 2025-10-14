using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment_1___COMP2139.Models
{
    public class PurchaseViewModel
    {
        public int EventId { get; set; }

        public string EventTitle { get; set; }

        public DateTime EventDate { get; set; }

        public int AvailableTickets { get; set; }

        public decimal TicketPrice { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a quantity of at least 1.")]
        public int Quantity { get; set; } = 1;

        [Required(ErrorMessage = "Your name is required.")]
        public string GuestName { get; set; }

        [Required(ErrorMessage = "Your email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string GuestEmail { get; set; }
    }
}