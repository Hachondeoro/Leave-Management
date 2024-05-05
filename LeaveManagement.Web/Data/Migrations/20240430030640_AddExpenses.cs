using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddExpenses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpenseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "d8c34be0-b679-4761-b887-7bca73ec6953");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "fa6631cc-4d52-4f8a-8880-0fa76c87b5fd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6b0a09f-4581-47c9-a12d-d6fd2b7670ff", "AQAAAAEAACcQAAAAEGVFNDBa+EcJc24XgIsL3G2pesQpBDmjdMPlGwnbAkeBBm9CH7mkWIBN2u8fHU2rkQ==", "0aeff7dc-41d9-4d1c-a437-874c6415c46d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f94e8b4e-fb48-438d-b336-0e89a4946756", "AQAAAAEAACcQAAAAEF6nxfBoWWr23MhVexDhXY19lVQkl76MagkCm8az5MLMMfhUKcLKG8HoymnfbXSj/Q==", "d7be61b5-a2c6-4aeb-8a7d-61de25751bf9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");

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
    }
}
