using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journey.Models
{
    public class JournyDbContext : DbContext
    {
        public JournyDbContext(DbContextOptions<JournyDbContext> options) : base(options)
        { }
        public DbSet<User> Users { get; set; }

    }
}

