using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sigovia_backend.api.Models;

namespace sigovia_backend.api.Data
{
    public class ApplicationDBContext : DbContext
    {
         public ApplicationDBContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
        }

        public DbSet<Booking> Bookings { get; set; }
    }
}