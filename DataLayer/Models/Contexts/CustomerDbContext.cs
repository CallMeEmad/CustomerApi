using CustomerApi.DataLayer.Models.Entities;
using CustomerApi.DataLayer.Models.Entities.Configurations;
using Microsoft.EntityFrameworkCore;


namespace CustomerApi.DataLayer.Models.Context
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
            : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        }
    }
}
