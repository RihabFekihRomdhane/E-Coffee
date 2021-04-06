using ECoffee.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECoffee.Data.Services
{
    public class ECoffeeDbContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
    }
}
