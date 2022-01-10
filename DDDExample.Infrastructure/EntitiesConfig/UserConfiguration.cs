using DDDExample.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDExample.Infrastructure.EntitiesConfig
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //builder.Property(r => r.UserName)
            //   .HasColumnType("varchar(100)")
            //   .HasMaxLength(100)
            //   .IsRequired();
            builder.HasData(
               new User
               {
                   Id = new Guid("b3c15103-4c81-4bd9-af6c-d5bb5d0509e4"),
                   UserName = "tungndn",
                   FullName = "Tùng Nguyễn",
                   Password = "12345",
                   RoleId = new Guid("a600280d-e519-41d5-998f-82fd428af9f3")

               },
               new User
               {
                   Id = new Guid("03441b82-9fdb-4cbb-8198-473c5cf98d55"),
                   UserName = "longpt",
                   FullName = "Long Phan",
                   Password = "12345",
                   RoleId = new Guid("a02a928b-425c-45dc-9441-82cae13dc44a")
               }
           );
        }
    }
}
