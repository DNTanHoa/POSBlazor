using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using POSBlazor.Data.Configuration;
using POSBlazor.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace POSSolution.Application.Context
{
    public class POSContext : DbContext
    {
        public POSContext(DbContextOptions<POSContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ShopConfiguration());
            builder.ApplyConfiguration(new RegionConfiguration());
            builder.ApplyConfiguration(new StatusConfiguration());
            builder.ApplyConfiguration(new TableConfiguration());
            builder.ApplyConfiguration(new ItemGroupConfiguration());
            builder.ApplyConfiguration(new UnitConfiguration());
            builder.ApplyConfiguration(new ItemConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new OrderItemConfiguration());

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                        .SetBasePath(Directory.GetCurrentDirectory())
                                                        .AddJsonFile("appsettings.json")
                                                        .Build();

            var connectionString = configurationRoot.GetConnectionString("POSContext");
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Status> ShopStatuses { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Order> TableStatuses { get; set; }
        public DbSet<OrderItem> Menus { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
