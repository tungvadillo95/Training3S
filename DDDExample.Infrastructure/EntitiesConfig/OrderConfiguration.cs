using DDDExample.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDExample.Infrastructure.EntitiesConfig
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
               new Order
               {
                   Id = new Guid("8b31feb8-fa3b-49f9-9665-30d38d25971a"),
                   UserId = new Guid("03441b82-9fdb-4cbb-8198-473c5cf98d55")
                   //OrderDetails = new List<OrderDetail>()
                   //{
                   //    new OrderDetail()
                   //    {
                   //        Id = new Guid(),
                   //        OrderId = id,
                   //        ProductId = new Guid("b5913f1b-f441-4560-9f11-d71a4b3119db")
                   //    },
                   //    new OrderDetail()
                   //    {
                   //        Id = new Guid(),
                   //        OrderId = id,
                   //        ProductId = new Guid("2281051c-c4ad-4cab-aafa-cdedea34ad1e")
                   //    }
                   //}
               },
               new Order
               {
                   Id = new Guid("5720f3f1-3b2c-4618-831f-95f26df42af0"),
                   UserId = new Guid("0826adac-2df3-4e98-b9c5-2a2534c33e55")
               }
           );
        }
    }
}
