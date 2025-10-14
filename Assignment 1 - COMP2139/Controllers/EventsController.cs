using Assignment_1___COMP2139.Data;
using Assignment_1___COMP2139.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1___COMP2139.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ✅ Index (with search + category filter)
        public async Task<IActionResult> Index(string searchString, int? categoryId)
        {
            var categories = await _context.Categories.ToListAsync();
            ViewBag.Categories = categories;
            ViewBag.SelectedCategory = categoryId;

            var events = _context.Events.Include(e => e.Category).AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                events = events.Where(e =>
                    e.Title.ToLower().Contains(searchString.ToLower()) ||
                    e.Location.ToLower().Contains(searchString.ToLower()));
            }

            if (categoryId.HasValue)
            {
                events = events.Where(e => e.CategoryId == categoryId.Value);
            }

            return View(await events.ToListAsync());
        }

        // ✅ Details
        public async Task<IActionResult> Details(int id)
        {
            var eventItem = await _context.Events
                .Include(e => e.Category)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (eventItem == null)
                return NotFound();

            return View(eventItem);
        }

        // ✅ Create (GET)
        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        // ✅ Create (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Event newEvent)
        {
            if (ModelState.IsValid)
            {
                // Ensure DateTime is UTC for PostgreSQL
                newEvent.Date = DateTime.SpecifyKind(newEvent.Date, DateTimeKind.Utc);

                _context.Events.Add(newEvent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Categories = _context.Categories.ToList();
            return View(newEvent);
        }

        // ✅ Edit (GET)
        public async Task<IActionResult> Edit(int id)
        {
            var eventItem = await _context.Events.FindAsync(id);
            if (eventItem == null)
                return NotFound();

            ViewBag.Categories = _context.Categories.ToList();
            return View(eventItem);
        }

        // ✅ Edit (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Event updatedEvent)
        {
            if (id != updatedEvent.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    // Ensure DateTime is UTC
                    updatedEvent.Date = DateTime.SpecifyKind(updatedEvent.Date, DateTimeKind.Utc);

                    _context.Update(updatedEvent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Events.Any(e => e.Id == updatedEvent.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Categories = _context.Categories.ToList();
            return View(updatedEvent);
        }

        // ✅ Delete (GET)
        public async Task<IActionResult> Delete(int id)
        {
            var eventItem = await _context.Events
                .Include(e => e.Category)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (eventItem == null)
                return NotFound();

            return View(eventItem);
        }

        // ✅ Delete (POST)
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eventItem = await _context.Events.FindAsync(id);
            if (eventItem != null)
            {
                _context.Events.Remove(eventItem);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}




