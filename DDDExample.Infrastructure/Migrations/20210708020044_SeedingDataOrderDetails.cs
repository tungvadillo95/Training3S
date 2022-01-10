using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DDDExample.Infrastructure.Migrations
{
    public partial class SeedingDataOrderDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("2a423345-e4fe-46b5-8f4e-99e02fe14bf9"), new Guid("8b31feb8-fa3b-49f9-9665-30d38d25971a"), new Guid("b5913f1b-f441-4560-9f11-d71a4b3119db") },
                    { new Guid("eba229c6-4684-4a83-9a55-f3f3dfffdc92"), new Guid("5720f3f1-3b2c-4618-831f-95f26df42af0"), new Guid("b5913f1b-f441-4560-9f11-d71a4b3119db") },
                    { new Guid("46621465-904a-4d23-8fe6-ea40c13faa0d"), new Guid("5720f3f1-3b2c-4618-831f-95f26df42af0"), new Guid("2281051c-c4ad-4cab-aafa-cdedea34ad1e") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("2a423345-e4fe-46b5-8f4e-99e02fe14bf9"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("46621465-904a-4d23-8fe6-ea40c13faa0d"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("eba229c6-4684-4a83-9a55-f3f3dfffdc92"));
        }
    }
}
