using DDDExample.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDExample.Infrastructure.EntitiesConfig
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            //builder.Property(r => r.RoleName)
            //    .HasColumnType("varchar(100)")
            //    .HasMaxLength(100)
            //    .IsRequired();

            builder.HasData(
                new Role
                {
                    Id = new Guid(),
                    RoleName = "Admin"
                },
                new Role
                {
                    Id = new Guid(),
                    RoleName = "Employee"
                }
            );
        }
    }
}
