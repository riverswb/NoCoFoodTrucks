using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NoCoFoodTrucks.Models
{
    public class NoCoFoodTrucksContext : DbContext
    {
        public NoCoFoodTrucksContext (DbContextOptions<NoCoFoodTrucksContext> options)
            : base(options)
        {
        }

        public DbSet<NoCoFoodTrucks.Models.Truck> Truck { get; set; }
    }
}
