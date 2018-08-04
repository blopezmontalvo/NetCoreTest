using Domain.Entities.Inventory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Context.Inventory
{
    public class InventoryDB:DbContext
    {
        static readonly string DEFAULT_CONNECTION_STRING = "data source=.;initial catalog=EntityFrameworkCoreExample;integrated security=True";
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DEFAULT_CONNECTION_STRING);
            }
            base.OnConfiguring(optionsBuilder);
        }

    }
}
