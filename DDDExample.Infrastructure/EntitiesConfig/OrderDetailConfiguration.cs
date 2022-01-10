using DDDExample.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDExample.Infrastructure.EntitiesConfig
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasData(
                new OrderDetail()
                {
                    Id = new Guid("2a423345-e4fe-46b5-8f4e-99e02fe14bf9"),
                    OrderId = new Guid("8b31feb8-fa3b-49f9-9665-30d38d25971a"),
                    ProductId = new Guid("b5913f1b-f441-4560-9f11-d71a4b3119db")
                },
                new OrderDetail()
                {
                    Id = new Guid("eba229c6-4684-4a83-9a55-f3f3dfffdc92"),
                    OrderId = new Guid("5720f3f1-3b2c-4618-831f-95f26df42af0"),
                    ProductId = new Guid("b5913f1b-f441-4560-9f11-d71a4b3119db")
                },
                new OrderDetail()
                {
                    Id = new Guid("46621465-904a-4d23-8fe6-ea40c13faa0d"),
                    OrderId = new Guid("5720f3f1-3b2c-4618-831f-95f26df42af0"),
                    ProductId = new Guid("2281051c-c4ad-4cab-aafa-cdedea34ad1e")
                }
            );
        }
    }
}
