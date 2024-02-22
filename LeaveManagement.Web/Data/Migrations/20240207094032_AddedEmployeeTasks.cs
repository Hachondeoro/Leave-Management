using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedEmployeeTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssigneeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTasks", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "8b9424df-d2a8-40a7-bfbd-788be1c8a79d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "d1de38f3-3ba7-49c1-b025-18bbc845bd33");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fddef782-78d9-45c9-b541-15d2fc0abd87", "AQAAAAEAACcQAAAAEAYVYizPPnQcb5cPpFHi9EWw6amA5KzU/hUxtCEzauHU0XaQEsMSspcED2jHrk0pxw==", "7c9ac04f-7d1f-4ddc-acd9-766751680dd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "689b9dc9-1285-4f07-b91b-79fb7a735334", "AQAAAAEAACcQAAAAELUJ/YAWebAAhrJu0qZdb+5Fnwh1hdRcSLs++7A+2ufAqTg09YpkdIH20U7NORMOWQ==", "acf7aa44-bf5e-4ff0-ba0a-148d2aec1e89" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeTasks");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "3602a427-40cf-4073-b597-aeb11ee89223");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "92d06654-21a1-4a37-a61a-36d0246310cc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4ce9077-e952-4202-8c20-b296d6ce0c3a", "AQAAAAEAACcQAAAAEC+f5/DJVAXZ6UGnuJmc5IoBASO7g9K4pb/skvLcuF0bx8rdhyWj5JFwU3zYknglSg==", "778a12d7-9eb6-4c0c-b7c2-6dc63f384cbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ef3f4c6-7beb-4659-9b25-0941f285734a", "AQAAAAEAACcQAAAAEFJEmr2Wz+EaRn1sXwMXhxMH9MhBly7iTGaecZttNRW84DQXD3gnLpfoCqcgfQgPTg==", "d38336d4-d486-4dba-a0dd-8e9ba914f095" });
        }
    }
}
