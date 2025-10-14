using Assignment_1___COMP2139.Data;
using Assignment_1___COMP2139.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1___COMP2139.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PurchaseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Purchase/Create?eventId=#
        public async Task<IActionResult> Create(int? eventId)
        {
            if (eventId == null)
                return NotFound();

            var ev = await _context.Events.FindAsync(eventId.Value);
            if (ev == null)
                return NotFound();

            var model = new PurchaseViewModel
            {
                EventId = ev.Id,
                EventTitle = ev.Title,
                EventDate = ev.Date,
                AvailableTickets = ev.AvailableTickets,
                TicketPrice = ev.TicketPrice
            };

            return View(model);
        }

        // POST: Purchase/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PurchaseViewModel model)
        {
            var ev = await _context.Events.FindAsync(model.EventId);
            if (ev == null)
            {
                ModelState.AddModelError("", "Event not found.");
                return View(model);
            }

            if (!ModelState.IsValid || model.Quantity > ev.AvailableTickets)
            {
                if (model.Quantity > ev.AvailableTickets)
                    ModelState.AddModelError("", "Not enough tickets available.");

                // Keep event info in the model for redisplay
                model.EventTitle = ev.Title;
                model.EventDate = ev.Date;
                model.TicketPrice = ev.TicketPrice;
                model.AvailableTickets = ev.AvailableTickets;

                return View(model);
            }

            var purchase = new Purchase
            {
                GuestName = model.GuestName,
                GuestEmail = model.GuestEmail,
                PurchaseDate = DateTime.UtcNow,
                PurchaseEvents = new List<PurchaseEvent>
                {
                    new PurchaseEvent
                    {
                        EventId = ev.Id,
                        Quantity = model.Quantity
                    }
                }
            };

            ev.AvailableTickets -= model.Quantity;

            _context.Purchases.Add(purchase);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = purchase.Id });
        }

        // GET: Purchase/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var purchase = await _context.Purchases
                .Include(p => p.PurchaseEvents)
                    .ThenInclude(pe => pe.Event)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (purchase == null)
                return NotFound();

            return View(purchase);
        }
    }
}



