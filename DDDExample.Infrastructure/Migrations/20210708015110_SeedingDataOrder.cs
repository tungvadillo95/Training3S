using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DDDExample.Infrastructure.Migrations
{
    public partial class SeedingDataOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("8b31feb8-fa3b-49f9-9665-30d38d25971a"), new Guid("03441b82-9fdb-4cbb-8198-473c5cf98d55") },
                    { new Guid("5720f3f1-3b2c-4618-831f-95f26df42af0"), new Guid("0826adac-2df3-4e98-b9c5-2a2534c33e55") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5720f3f1-3b2c-4618-831f-95f26df42af0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8b31feb8-fa3b-49f9-9665-30d38d25971a"));
        }
    }
}
