using DDDExample.Infrastructure.Entities;
using DDDExample.Infrastructure.EntitiesConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDExample.Infrastructure
{
    public class DDDExampleDbContext : DbContext
    {
        public DDDExampleDbContext(DbContextOptions<DDDExampleDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());

            //modelBuilder.Entity<Role>()
            //            .HasMany<User>(r => r.Users)
            //            .WithOne(u => u.Role)
            //            .HasForeignKey(u => u.RoleId)
            //            .OnDelete(DeleteBehavior.Cascade);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
