using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RockyGroomingApp.Models
{
    public class RockyGroomingAppContext : DbContext
    {
        public RockyGroomingAppContext (DbContextOptions<RockyGroomingAppContext> options)
            : base(options)
        {
        }

        public DbSet<RockyGroomingApp.Models.Dog> Dog { get; set; }
    }
}
