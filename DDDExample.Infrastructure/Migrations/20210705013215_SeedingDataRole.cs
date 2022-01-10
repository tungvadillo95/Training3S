using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DDDExample.Infrastructure.Migrations
{
    public partial class SeedingDataRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("a600280d-e519-41d5-998f-82fd428af9f3"), "Admin" },
                    { new Guid("a02a928b-425c-45dc-9441-82cae13dc44a"), "Employee" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a02a928b-425c-45dc-9441-82cae13dc44a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a600280d-e519-41d5-998f-82fd428af9f3"));
        }
    }
}
