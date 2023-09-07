using EventManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventManager.Infrastructure.Persistence
{
    public class RegistrationDbContext : DbContext
    {
        public RegistrationDbContext(DbContextOptions<RegistrationDbContext> options) : base(options) { }

        public DbSet<EventLog> EventLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventLog>()
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<EventLog>()
                .HasOne(e => e.EventType)
                .WithMany(et => et.EventLogs)
                .HasForeignKey(e => e.EventTypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}