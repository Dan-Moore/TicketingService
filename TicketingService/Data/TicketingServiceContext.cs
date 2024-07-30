using System;
using System.Collections.Generic;
using System.Linq;
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

        public DbSet<TicketingService.Models.User> User { get; set; } = default!;
    }
}
