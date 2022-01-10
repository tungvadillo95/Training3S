using DDDExample.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDExample.Infrastructure.EntitiesConfig
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
               new Product
               {
                   Id = new Guid("b5913f1b-f441-4560-9f11-d71a4b3119db"),
                   ProductName = "Máy tính"
               }, 
               new Product
               {
                   Id = new Guid("2281051c-c4ad-4cab-aafa-cdedea34ad1e"),
                   ProductName = "Điện thoại"
               }
           );
        }
    }
}
