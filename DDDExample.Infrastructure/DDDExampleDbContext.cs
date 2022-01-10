using DDDExample.Infrastructure.Entities;
using DDDExample.Infrastructure.EntitiesConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDExample.Infrastructure
{
    public class DDDExampleDbContext : DbContext, IDDDExampleDbContext
    {
        public DDDExampleDbContext(DbContextOptions<DDDExampleDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());

            //modelBuilder.Entity<Role>()
            //            .HasMany<User>(r => r.Users)
            //            .WithOne(u => u.Role)
            //            .HasForeignKey(u => u.RoleId)
            //            .OnDelete(DeleteBehavior.Cascade);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
