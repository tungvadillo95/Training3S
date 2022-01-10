using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DDDExample.Infrastructure.Migrations
{
    public partial class SeedingDataProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ProductName" },
                values: new object[,]
                {
                    { new Guid("b5913f1b-f441-4560-9f11-d71a4b3119db"), "Máy tính" },
                    { new Guid("2281051c-c4ad-4cab-aafa-cdedea34ad1e"), "Điện thoại" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2281051c-c4ad-4cab-aafa-cdedea34ad1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5913f1b-f441-4560-9f11-d71a4b3119db"));
        }
    }
}
