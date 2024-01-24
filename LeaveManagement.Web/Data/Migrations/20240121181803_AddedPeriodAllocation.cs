using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedPeriodAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "7c1458f6-c799-4143-969a-866794ee211b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "28f8d3b6-900e-4fa1-816a-d2182e6a13ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f74c4688-c245-439a-94b0-ef6006e6ece1", "AQAAAAEAACcQAAAAEJxvL/19jkNn6ibDQwVkjqS3FHnsI1wZqXLz07R5DRvzvauPMSfB+TENQMsRiH5c6A==", "a8598bf4-1f39-440c-bbae-583bad77238c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf4ac030-6962-45db-af1a-e6787ceb99e7", "AQAAAAEAACcQAAAAEB6ErrK/9xLG5FDpnwIdgAZdZD2NZDJq8c6hEqej52U0vnGgfjK4snq4KL7hvUdTMg==", "d8e74596-d033-41ec-b1a2-d704485e1f61" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "550d6b8b-3320-44af-99d1-601fcd0abce2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "7995f36d-a1e5-4da3-8eeb-cb8789f3c684");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ee258f4-52c6-4315-970c-dbd3072232bb", "AQAAAAEAACcQAAAAEGFyHgaLxjZeIjzWPqY04hRwb8DXsDp+hpSKUkSsfGzJBcbfIxYazLGoxCg8K0Xycg==", "0c284d65-5601-4213-80ea-63f402e4fe35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aaf70aec-f5af-480a-a595-98a19516ad4a", "AQAAAAEAACcQAAAAEPrjEzZn7AM4NH7xayyXqd4aWwL9BDQfyAWeWaG128PbfKZi/HShxlEKYaRRwEUZBg==", "c38062db-1840-4aff-b228-da12f3385b4a" });
        }
    }
}
