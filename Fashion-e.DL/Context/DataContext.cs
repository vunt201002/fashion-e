using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.Common.Entities.Configuration;
using Fashion_e.Common.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fashion_e.DL.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new SizeProductConfig());
            modelBuilder.ApplyConfiguration(new ColorProductConfig());
            modelBuilder.ApplyConfiguration(new GalleryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new SizeColorProductConfig());
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new ShipperConfig());
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<SizeProduct> SizeProduct { get; set; }
        public DbSet<ColorProduct> ColorProduct { get; set; }
        public DbSet<Gallery> Gellery { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<SizeColorProduct> SizeColorProduct { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Shipper> Shipper { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}
