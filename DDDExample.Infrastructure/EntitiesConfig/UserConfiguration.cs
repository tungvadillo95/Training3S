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
        }
    }
}
