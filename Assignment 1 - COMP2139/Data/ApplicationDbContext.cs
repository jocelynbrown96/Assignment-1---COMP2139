using Assignment_1___COMP2139.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1___COMP2139.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseEvent> PurchaseEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Many-to-Many
            modelBuilder.Entity<PurchaseEvent>()
                .HasKey(pe => new { pe.PurchaseId, pe.EventId });

            modelBuilder.Entity<PurchaseEvent>()
                .HasOne(pe => pe.Purchase)
                .WithMany(p => p.PurchaseEvents)
                .HasForeignKey(pe => pe.PurchaseId);

            modelBuilder.Entity<PurchaseEvent>()
                .HasOne(pe => pe.Event)
                .WithMany(e => e.PurchaseEvents)
                .HasForeignKey(pe => pe.EventId);

            // Optional seed data
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Music", Description = "Live music events" },
                new Category { Id = 2, Name = "Tech", Description = "Technology conferences" }
            );

            modelBuilder.Entity<Event>().HasData(
                new Event 
                { 
                    Id = 1, 
                    Title = "Jazz Night", 
                    Date = DateTime.UtcNow.AddDays(10), 
                    TicketPrice = 25.00M, 
                    AvailableTickets = 100, 
                    CategoryId = 1 
                },
                new Event 
                { 
                    Id = 2, 
                    Title = "AI Summit", 
                    Date = DateTime.UtcNow.AddDays(20), 
                    TicketPrice = 99.00M, 
                    AvailableTickets = 50, 
                    CategoryId = 2 
                }
            );
        }
    }
}