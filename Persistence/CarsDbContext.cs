using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Models;
using Cars.Controllers.Resources;

namespace Cars.Persistence
{
    public class CarsDbContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public CarsDbContext(DbContextOptions<CarsDbContext> options)
         : base(options)
        {
            
    }
        
    }
}
