using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TicketingService.Models;

namespace TicketingService.Data
{
    public class TicketingServiceContext : DbContext
    {
        public TicketingServiceContext (DbContextOptions<TicketingServiceContext> options)
            : base(options)
        {
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>()
                .HasMany(e => e.Comments)
                .WithOne(e => e.Ticket)
                .HasForeignKey(e => e.Ticket_id)
                .HasPrincipalKey(e => e.Id);
        }
        
        public DbSet<TicketingService.Models.User> User { get; set; } = default!;
    }
}
