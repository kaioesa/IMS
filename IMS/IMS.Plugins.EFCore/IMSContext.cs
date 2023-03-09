using IMS.CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Plugins.EFCore
{
    public class IMSContext : DbContext
    {
        public IMSContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Inventory> Inventories { get; set; };

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seeding data
            modelBuilder.Entity<Inventory>().HasData(
                new Inventory { InventoryId = 1, InventoryName = "Test1", Price = 1000, Quantity = 1 },
                new Inventory { InventoryId = 2, InventoryName = "Test2", Price = 2000, Quantity = 1 },
                new Inventory { InventoryId = 3, InventoryName = "Test3", Price = 3000, Quantity = 1 },
                );
        }
    }
}
