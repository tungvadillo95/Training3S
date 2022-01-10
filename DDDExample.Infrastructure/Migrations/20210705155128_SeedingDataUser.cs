using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DDDExample.Infrastructure.Migrations
{
    public partial class SeedingDataUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FullName", "Password", "RoleId", "UserName" },
                values: new object[,]
                {
                    { new Guid("b3c15103-4c81-4bd9-af6c-d5bb5d0509e4"), "Tùng Nguyễn", "12345", new Guid("a600280d-e519-41d5-998f-82fd428af9f3"), "tungndn" },
                    { new Guid("03441b82-9fdb-4cbb-8198-473c5cf98d55"), "Long Phan", "12345", new Guid("a02a928b-425c-45dc-9441-82cae13dc44a"), "longpt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("03441b82-9fdb-4cbb-8198-473c5cf98d55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3c15103-4c81-4bd9-af6c-d5bb5d0509e4"));
        }
    }
}
